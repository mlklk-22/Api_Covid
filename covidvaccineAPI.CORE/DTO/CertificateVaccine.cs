using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.DTO
{
    public class CertificateVaccine
    {
        public string FULLNAME { get; set; }
        public int NUMBEROFVACCINES { get; set; }
        public string VACCINENAME { get; set; }
        public string CENTERNAME { get; set; }
        public DateTime FirstDateDose{ get; set; }
        public DateTime SecondDateDose { get; set; }
    }
}
