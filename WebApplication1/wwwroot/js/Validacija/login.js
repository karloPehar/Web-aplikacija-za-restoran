
$(function () {

    

    $("#formPr").validate(
        {
            rules: {


                Email: {
                    required: true,
                    maxlength: 320,
                    minlength: 10,
                    email: true
                },
                Lozinka: {

                    required: true,
                    maxlength: 50,
                    minlength: 6,
                  
                }
            },
            messages: {

                Email: {
                    required: "Molimo unesite email adresu.",
                    maxlength: "Unjeli ste maksimalan broj karaktera.",
                    minlength: "Adresa se mora sastojati od minimalno 10 karaktera.",
                    email:"Unesite validnu e mail adresu"
                },
                Lozinka: {
                    required: "Molimo unesite lozinku.",
                    maxlength: "Molimo unesite lozinku dozvoljene velicine.",
                    minlength: "Lozinka se mora sastojati od minimalno 6 karaktera"
                }
               
            }
        });
});