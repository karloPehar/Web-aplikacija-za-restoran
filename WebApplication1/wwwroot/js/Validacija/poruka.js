
$(function () {

    

    $("#porukaForma").validate(
        {
            rules: {



                Poruka: {

                    required: true,
                    maxlength: 256,
                    minlength: 1
                }
            },
            messages: {


                Poruka: {
                    required: "Unos je obavezan.",
                    maxlength: "Unjeli ste maximalan broj karaktera.",
                    minlength: "Morate unjeti minimalno 3 karaktera. "
                }

            }
        });
});