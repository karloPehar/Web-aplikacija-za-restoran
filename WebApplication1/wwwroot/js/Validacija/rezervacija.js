
$(function () {

    $.validator.addMethod("validanTelefon", function (value, element) {
        return this.optional(element) ||
            (/([0-9]){9}/).test(value);
    }, "Molimo unesite validan broj telefona.");
    

    $("form").validate(
        {
            rules: {
                PoslovnicaID: {
                    required: true

                },

                Ime: {
                    required: true,
                    maxlength: 50,
                    minlength: 2
                },
                Prezime: {
                    required: true,
                    maxlength: 50,
                    minlength: 2
                },
                Email: {
                    required: true,
                    maxlength: 320,
                    email: true
                },
                brojOsobaID: {
                    required: true

                },
                BrojTelefona: {
                    required: true,
                    validanTelefon: true

                },
                DatumRezervacije: {
                    required: true

                },
                TerminRezervacijeID: {
                    required: true

                },
                Napomena: {

                    maxlength: 256,
                    minlength: 10
                }
            },
            messages: {

                PoslovnicaID: {
                    required: "Polje je obavezno."

                },
                Ime: {
                    required: "Polje je obavezno.",
                    maxlength: "Unjeli ste maksimalnu duzinu imena",
                    minlength: "Ime se mora sastojati on minimalno 3 karaktera"
                },
                Prezime: {
                    required: "Polje je obavezno.",
                    maxlength: "Unjeli ste maksimalnu duzinu prezimena",
                    minlength: "Ime se mora sastojati on minimalno 3 karaktera"
                },
                Email: {
                    required: "Polje je obavezno.",
                    maxlength: "Unjeli ste maksimalnu duzinu email adrese.",
                    email:"Molimo unesite validnu email adresu."
                },
                brojOsobaID: {
                    required: "Polje je obavezno."

                },
                BrojTelefona: {
                    required: "Polje je obavezno."


                },
                DatumRezervacije: {
                    required: "Polje je obavezno"

                },
                TerminRezervacijeID: {
                    required: "Polje je obavezno"

                },
                Napomena: {

                    maxlength: "Unjeli ste maksimalan broj karaktera",
                    minlength: "Morate unjeti minimalno 10 karaktera"
                }
               
            }
        });
});