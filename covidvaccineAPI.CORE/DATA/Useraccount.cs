using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Useraccount
    {
        public Useraccount()
        {
            Reservations = new HashSet<Reservation>();
            Testmonials = new HashSet<Testmonial>();
            Vaccinehistories = new HashSet<Vaccinehistory>();
        }

        public static object USERNAME { get; set; }
        public decimal Userid { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public decimal? Phonenumber { get; set; }
        public decimal? Numberofvaccines { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Age { get; set; }
        public decimal? Roleid { get; set; }
        public string vaccinename { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Testmonial> Testmonials { get; set; }
        public virtual ICollection<Vaccinehistory> Vaccinehistories { get; set; }
    }
}
