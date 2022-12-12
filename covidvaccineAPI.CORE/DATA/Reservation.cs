using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Reservation
    {
        public Reservation()
        {
            Vaccinehistories = new HashSet<Vaccinehistory>();
        }

        public decimal Reserveid { get; set; }
        public DateTime? Actualdatedose1 { get; set; }
        public DateTime? Actualdatedose2 { get; set; }
        public string massage { get; set; }
        public string Status { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Vaccineid { get; set; }
        public decimal? Centerid { get; set; }
        public decimal? Idvaccinehistory { get; set; }

        public virtual Vaccinationcenter Center { get; set; }
        public virtual Vaccinehistory IdvaccinehistoryNavigation { get; set; }
        public virtual Useraccount User { get; set; }
        public virtual Vaccines Vaccine { get; set; }
        public virtual ICollection<Vaccinehistory> Vaccinehistories { get; set; }
    }
}
