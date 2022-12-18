using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
    public interface ITestmonialRepository
    {
        void CreateTestmonial(Testmonial testmonial);
        List<Testmonial> GetAllTestmonial();
        Testmonial GetTestmonialById(int id);
        void UpdateTestmonial(Testmonial testmonial);
        void DeleteTestmonial(int id);
        List<ShowAllTestmonial> ShowAllTestmonial();

    }
}
