


$(function () {



  


    $("form").validate(
        {
            rules: {



                Sadrzaj: {

                    required: true,
                    maxlength: 256,
                    minlength: 20
                    
                }
            },
            messages: {


                Sadrzaj: {
                    required: "Unos je obavezan.",
                    maxlength: "Presli ste dozvoljenu velicinu komentara.",
                    minlength: "Komentar se mara sastojati od minimalno 20 slova."
                    
                }

            }
        });
});