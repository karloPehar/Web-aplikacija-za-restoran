



function DodajAjaxEvente() {

            ////dodavanje komentara
            $("button[ajax-poziv='da']").click(function (event) {
                $(this).attr("ajax-poziv", "dodan");
                event.preventDefault();
               
                console.log(". .");

                var urlZaPoziv = $(this).attr("ajax-url");
                var divZaRezultat = $(this).attr("ajax-rezultat");
        

                $.get(urlZaPoziv, function (data, status) {
                    $("#" + divZaRezultat).html(data);
           
            
                });
            });
            $("a[ajax-poziv='da']").click(function (event) {
                $(this).attr("ajax-poziv", "dodan");

                event.preventDefault();
                var urlZaPoziv = $(this).attr("href");
                var divZaRezultat = $(this).attr("ajax-rezultat");
                console.log(". . .");

                $.get(urlZaPoziv, function (data, status) {
                    $("#" + divZaRezultat).html(data);


                });
            });
           
            $("form[ajax-poziv='da']").submit(function (event) {
                $(this).attr("ajax-poziv", "dodan");
                event.preventDefault();

                var forma = $(this).attr("forma-id");
                //if (forma) {
                //    console.log(" je instance")
                //} else {console.log("nije")}
                if (forma) {
                    console.log(forma);
                    if (!$("#" + forma).valid()) {
                       
                    return false;
                    }
                }
                
                var urlZaPoziv1 = $(this).attr("ajax-url");
                var urlZaPoziv2 = $(this).attr("action");
                var divZaRezultat = $(this).attr("ajax-rezultat");

                var urlZaPoziv;
                if (urlZaPoziv1 instanceof String)
                    urlZaPoziv = urlZaPoziv1;
                else
                    urlZaPoziv = urlZaPoziv2;

                var form = $(this);
                console.log(". . . .")
                $.ajax({
                    type: "POST",
                    url: urlZaPoziv,
                    data: form.serialize(),
                    success: function (data) {
                        $("#" + divZaRezultat).html(data);
                    }
                });
            });

   
}


function modalniButton() {
  
   
 
    $(function () {
        var placeholderElement = $('#PrijavaPlaceholder');
        //var placeholderElement = $(this).attr("ajax-rezultat");

        $("button[ajax-modalni='da']").click(function (event) {

            event.preventDefault();
            var urlZaPoziv = $(this).attr("ajax-url");
            $.get(urlZaPoziv).done(function (data) {
                placeholderElement.html(data);
                //if (placeholderElement.data('bs.modal') && !placeholderElement.data('bs.modal').isShown) {
                //    placeholderElement.find('.modal').modal('show');
                //}
                if (!placeholderElement.hasClass("in"))
                    {
                    placeholderElement.find('.modal').modal('show');
                    }

            });
        });

        placeholderElement.on('click', '[data-save="modal"]', function (event) {
            event.preventDefault();

            var form = $(this).parents('.modal').find('form');
            //console.log("ide data save");

            //var formaID = form.attr("id");

            //if (formaID) {
            //    console.log(formaID);
            //    if (!$("#" + formaID).valid()) {
            //        console.log("nije validna");
            //        return false;
            //    }
            //}
            var actionUrl = form.attr('action');
            var dataToSend = form.serialize();

            $.post(actionUrl, dataToSend).done(function (data) {
                var newBody = $('.modal-body', data);
                placeholderElement.find('.modal-body').replaceWith(newBody);

                var isValid = newBody.find('[name="IsValid"]').val() == 'True';
                var pogresanUnos = newBody.find('[name="PogresanUnos"]').val();
                if (isValid && pogresanUnos=="") {
                    if (placeholderElement) {
                        //placeholderElement.find('.modal').modal('hide');
                        if (placeholderElement.hasClass("in")) {
                            placeholderElement.find('.modal').modal('hide');
                        }
                        console.log("validan");
                        location.reload();
                    }
                   
                    
                }
            });
           
        });
        //$("#prijavaModal").on('hide.bs.modal', function () {
        //    location.reload();
        //});
    });
   
}
$(document).ready(function () {
    // izvršava nakon što glavni html dokument bude generisan
    DodajAjaxEvente();
   modalniButton();
    
   
  
});

$(document).ajaxComplete(function () {
    // izvršava nakon bilo kojeg ajax poziva
    DodajAjaxEvente();
   // modalniButton();
   
   
   
});


