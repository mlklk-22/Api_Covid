using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
   public interface IJWTService
    {
        string login(Useraccount useraccount);
    }
}
