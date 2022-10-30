using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Vaccinationcenter
    {
        public Vaccinationcenter()
        {
            Reservations = new HashSet<Reservation>();
            VacCenters = new HashSet<VacCenter>();
        }

        public decimal Centerid { get; set; }
        public string Centername { get; set; }
        public decimal? Centerusercapacity { get; set; }
        public decimal? Centervaccinecapacity { get; set; }
        public string Centeraddres { get; set; }
        public decimal? VacCenterid { get; set; }

        public virtual VacCenter VacCenter { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<VacCenter> VacCenters { get; set; }
    }
}
