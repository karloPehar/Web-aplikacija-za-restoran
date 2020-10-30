using System;

namespace ClassLibrary1.Models
{
    public class Email
    {
        public int EmailID { get; set; }

        public User User { get; set; }

        public int? UserID { get; set; }

        public string EmailAdresa { get; set; }

        public string Sadrzaj { get; set; }

        public DateTime VrijemeSlanja { get; set; }
    }
}
