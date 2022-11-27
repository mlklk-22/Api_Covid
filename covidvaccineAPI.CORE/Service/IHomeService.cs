using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
    public interface IHomeService
    {
        void CreateHome(Home home);
        List<Home> GetAllHome();
        void UpdateHome(Home home);
        void DeleteHome(int id);
    }
}
