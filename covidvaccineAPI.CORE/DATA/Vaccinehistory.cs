using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Vaccinehistory
    {
        public Vaccinehistory()
        {
            Reservations = new HashSet<Reservation>();
        }

        public decimal Vaccinehistoryid { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Reserveid { get; set; }

        public virtual Reservation Reserve { get; set; }
        public virtual Useraccount User { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
