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
        public DateTime actualdatedose1 { get; set; }
        public DateTime actualdatedose2 { get; set; }
    }
}
