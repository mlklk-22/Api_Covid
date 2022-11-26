using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestmonialController : ControllerBase
    {
        private readonly ITestmonialService _testmonialService;

        public TestmonialController(ITestmonialService testmonialService)
        {
            _testmonialService = testmonialService;
        }
        [HttpPost]
        public void CreateTestmonial(Testmonial testmonial)
        {
            _testmonialService.CreateTestmonial(testmonial);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteTestmonial(int id)
        {
            _testmonialService.DeleteTestmonial(id);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Testmonial> GetAllTestmonial()
        {
            return _testmonialService.GetAllTestmonial();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Testmonial GetTestmonialById(int id)
        {
            return _testmonialService.GetTestmonialById(id);
        }
        [HttpPut]
        public void UpdateTestmonial(Testmonial testmonial)
        {
            _testmonialService.UpdateTestmonial(testmonial);
        }
    }
}
