using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class VacCenter
    {
        public VacCenter()
        {
            Vaccinationcenters = new HashSet<Vaccinationcenter>();
            Vaccines = new HashSet<Vaccine>();
        }

        public decimal VacCenterid { get; set; }
        public decimal? Centerid { get; set; }
        public decimal? Vaccineid { get; set; }

        public virtual Vaccinationcenter Center { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public virtual ICollection<Vaccinationcenter> Vaccinationcenters { get; set; }
        public virtual ICollection<Vaccine> Vaccines { get; set; }
    }
}
