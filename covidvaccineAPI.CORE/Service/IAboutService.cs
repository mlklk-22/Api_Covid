using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
    public interface IAboutService
    {
        void CreateAbout(About about);
        List<About> GetAllAbout();
        void UpdateAbout(About about);
        void DeleteAbout(int id);
    }
}
