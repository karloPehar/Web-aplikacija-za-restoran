
$(function () {

    $.validator.addMethod("validanTelefon", function (value, element) {
        return this.optional(element) ||
            (/([0-9]){9}/).test(value);
    }, "Molimo unesite validan broj telefona.");
    

    $("form").validate(
        {
            rules: {
               

                Ime: {
                    required: true,
                    maxlength: 50,
                    minlength: 2
                },
               
                EmailAdresa: {
                    required: true,
                    maxlength: 320,
                    email: true
                },
               
                Sadrzaj: {
                    required:true,
                    maxlength: 256,
                    minlength: 15
                }
            },
            messages: {

               
                Ime: {
                    required: "Polje je obavezno.",
                    maxlength: "Unjeli ste maksimalnu duzinu imena",
                    minlength: "Ime se mora sastojati on minimalno 3 karaktera"
                },
               
                EmailAdresa: {
                    required: "Molimo unesite email adresu.",
                    maxlength: "Molimo unesite email adresu sa dozvoljenim brojem karaktera.",
                    email:"Molimo unesite validnu email adresu"
                },
               
                Sadrzaj: {
                    
                    maxlength: "Unjeli ste maksimalan broj karaktera",
                    minlength: "Morate unjeti minimalno 10 karaktera",
                    required:"Polje je obavezno."
                }
            }
        }
    );
});