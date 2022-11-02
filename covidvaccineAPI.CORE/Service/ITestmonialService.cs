using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
    public interface ITestmonialService
    {
        void CreateTestmonial(Testmonial reservation);
        List<Testmonial> GetAllTestmonial();
        Testmonial GetTestmonialById(int id);
        void UpdateTestmonial(Testmonial reservation);
        void DeleteTestmonial(int id);
    }
}
