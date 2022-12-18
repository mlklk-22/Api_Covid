using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

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
        [Route("ShowAll")]
        public List<ShowAllTestmonial> ShowAllTestmonial()
        {
            return _testmonialService.ShowAllTestmonial();
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

        [HttpPost]
        [Route("uploadImage")]

        public Testmonial UploadIMage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\lastvision\\Desktop\\Angular_Covid\\src\\assets\\images\\", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Testmonial item = new Testmonial();
            item.Image = fileName;
            return item;
        }
    }
}
