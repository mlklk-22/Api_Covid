using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.DTO
{
   public class UserReservation
    {
        public decimal Userid { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public decimal? Numberofvaccines { get; set; }
        public decimal Reserveid { get; set; }
        public DateTime Actualdatedose1 { get; set; }
        public DateTime Actualdatedose2 { get; set; }
        public string massage { get; set; }
        public string Status { get; set; }
    }
}
