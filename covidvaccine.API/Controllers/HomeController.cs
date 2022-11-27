using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpPost]
        public void CreateHome(Home home)
        {
            _homeService.CreateHome(home);
        }
        [HttpDelete]
        public void DeleteHome(int id)
        {
            _homeService.DeleteHome(id);
        }
        [HttpGet]
        public List<Home> GetAllHome()
        {
            return _homeService.GetAllHome();
        }
        [HttpPut]
        public void UpdateHome(Home home)
        {
            _homeService.UpdateHome(home);
        }
    }
}
