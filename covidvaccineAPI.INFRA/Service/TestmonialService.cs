using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class TestmonialService : ITestmonialService
    {
        private readonly ITestmonialRepository _testmonialRepository;

        public TestmonialService(ITestmonialRepository testmonialRepository)
        {
            _testmonialRepository = testmonialRepository;
        }

        public void CreateTestmonial(Testmonial testmonial)
        {
            _testmonialRepository.CreateTestmonial(testmonial);
        }

        public void DeleteTestmonial(int id)
        {
            _testmonialRepository.DeleteTestmonial(id);
        }

        public List<Testmonial> GetAllTestmonial()
        {
           return _testmonialRepository.GetAllTestmonial();
        }

        public Testmonial GetTestmonialById(int id)
        {
            return _testmonialRepository.GetTestmonialById(id);
        }

        public List<ShowAllTestmonial> ShowAllTestmonial()
        {
            return _testmonialRepository.ShowAllTestmonial();
        }

        public void UpdateTestmonial(Testmonial testmonial)
        {
            _testmonialRepository.UpdateTestmonial(testmonial);
        }
    }
}
