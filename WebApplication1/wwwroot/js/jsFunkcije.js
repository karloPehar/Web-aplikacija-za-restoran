
//prikazivanje rezervacija modalnog prozora
//$(function () {
//    var placeholderElement = $('#modal-placeholder');
//    $('button[data-toggle="ajax-modal"]').click(function (event) {
//        var url = $(this).data('url');
//        $.get(url).done(function (data) {
//            placeholderElement.html(data);
//            placeholderElement.find('.modal').modal('show');
//        });
//    });
//});

//$(function () {
//    var placeholderElement = $('#modal-placeholder');
//    $('button[data-toggle="ajax-modal"]').click(function (event) {
//        var url = $(this).data('url');
//        $.get(url).done(function (data) {
//            placeholderElement.html(data);
//            placeholderElement.find('.modal').modal('show');
//        });
//    });
//});

//$(function () {
//    var placeholderElement = $('#unos-komentar-placeholder');
//    $('a[data-toggle="ajax-modal"]').click(function (event) {
//        var url = $(this).data('href');
//        $.get(url).done(function (data) {
//            placeholderElement.html(data);
//            placeholderElement.find('.modal').modal('show');
//        });
//    });
//});
//$(function () {
//    var placeholderElement = $('#modal-placeholder');
//    $('button[data-toggle="ajax-modal"]').submit(function (event) {
//        var url = $(this).data('url');
//        $.get(url).done(function (data) {
//            placeholderElement.html(data);
//            placeholderElement.find('.modal').modal('show');
//        });
//    });
//});



function DodajAjaxEvente() {
    $("button[ajax-poziv='da']").click(function (event) {
        $(this).attr("ajax-poziv", "dodan");

        event.preventDefault();
        var urlZaPoziv = $(this).attr("ajax-url");
        var divZaRezultat = $(this).attr("ajax-rezultat");
        

        $.get(urlZaPoziv, function (data, status) {
            $("#" + divZaRezultat).html(data);
           
            
        });
    });

    $("button[ajax-modalni='da']").click(function (event) {
        $(this).attr("ajax-modalni", "dodan");

        event.preventDefault();
        var urlZaPoziv = $(this).attr("ajax-url");
        var divZaRezultat = $(this).attr("ajax-rezultat");
        //var modalni = $(this).attr("modalni");

        $.get(urlZaPoziv, function (data, status) {
            $("#" + divZaRezultat).html(data);
            $("#" + divZaRezultat).find('.modal').modal('show');

        });
    });

    $("a[ajax-poziv='da']").click(function (event) {
        $(this).attr("ajax-poziv", "dodan");
        event.preventDefault();
        var urlZaPoziv1 = $(this).attr("ajax-url");
        var urlZaPoziv2 = $(this).attr("href");
        var divZaRezultat = $(this).attr("ajax-rezultat");

        var urlZaPoziv;

        if (urlZaPoziv1 instanceof String)
            urlZaPoziv = urlZaPoziv1;
        else
            urlZaPoziv = urlZaPoziv2;

        $.get(urlZaPoziv, function (data, status) {
            $("#" + divZaRezultat).html(data);
        });
    });

    $("form[ajax-poziv='da']").submit(function (event) {
        $(this).attr("ajax-poziv", "dodan");
        event.preventDefault();
        var urlZaPoziv1 = $(this).attr("ajax-url");
        var urlZaPoziv2 = $(this).attr("action");
        var divZaRezultat = $(this).attr("ajax-rezultat");

        var urlZaPoziv;
        if (urlZaPoziv1 instanceof String)
            urlZaPoziv = urlZaPoziv1;
        else
            urlZaPoziv = urlZaPoziv2;

        var form = $(this);

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
$(document).ready(function () {
    // izvršava nakon što glavni html dokument bude generisan
    DodajAjaxEvente();
});

$(document).ajaxComplete(function () {
    // izvršava nakon bilo kojeg ajax poziva
    DodajAjaxEvente();
});
