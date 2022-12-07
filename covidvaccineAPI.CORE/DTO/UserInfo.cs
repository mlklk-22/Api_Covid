using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.DTO
{
  public  class UserInfo
    {
        public decimal Userid { get; set; }
        public string Fullname { get; set; }
        public decimal? Numberofvaccines { get; set; }
        public decimal Vaccineid { get; set; }
        public string VACCINENAME { get; set; }
        public decimal Centerid { get; set; }
        public string Centername { get; set; }
        public DateTime FirstDateDose { get; set; }
        public DateTime SecondDateDose { get; set; }
        public string Centeraddres { get; set; }
        public decimal? VacCenterid { get; set; }


        public string Username { get; set; }
        public decimal? Phonenumber { get; set; }
      
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal? Age { get; set; }
        public decimal? Roleid { get; set; }

    }
}
