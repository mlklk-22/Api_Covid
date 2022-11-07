using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Vaccines
    {
        public Vaccines()
        {
            Reservations = new HashSet<Reservation>();
            VacCenters = new HashSet<VacCenter>();
        }

        public decimal Vaccineid { get; set; }
        public string Vaccinename { get; set; }
        public decimal? Vaccinedoses { get; set; }
        public DateTime? Vaccineexp { get; set; }
        public decimal? VacCenterid { get; set; }

        public virtual VacCenter VacCenter { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<VacCenter> VacCenters { get; set; }
    }
}
