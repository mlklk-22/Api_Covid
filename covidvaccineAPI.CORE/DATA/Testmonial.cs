using System;
using System.Collections.Generic;

#nullable disable

namespace covidvaccineAPI.CORE.Data
{
    public partial class Testmonial
    {
        public decimal Idtest { get; set; }
        public string Message { get; set; }
        public decimal? Userid { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }

        public virtual Useraccount User { get; set; }
    }
}
