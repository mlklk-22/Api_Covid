using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
   public interface IJWTRepository
    {
        Useraccount Auth(Useraccount useraccount);
    }
}
