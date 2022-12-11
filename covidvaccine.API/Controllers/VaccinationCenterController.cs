using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using covidvaccineAPI.INFRA.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationCenterController : ControllerBase
    {
        private readonly IVaccinationCenterService _VaccinationCenterService;
        public VaccinationCenterController(IVaccinationCenterService vaccinationCenterService)
        {
            _VaccinationCenterService = vaccinationCenterService;
        }
        [HttpPost]
        public void CreateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            _VaccinationCenterService.CreateVaccinationCenter(vaccinationcenter);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void DeleteVaccinationCenter(int id)
        {
            _VaccinationCenterService.DeleteVaccinationCenter(id);
        }
        [HttpGet]
        public List<Vaccinationcenter> GetAllVaccinationCenter()
        {
            return _VaccinationCenterService.GetAllVaccinationCenter();
        }
        [HttpGet]
        [Route ("GetById/{id}")]
        public Vaccinationcenter GetVaccinationCenterById(int id)
        {
            return _VaccinationCenterService.GetVaccinationCenterById(id);
        }
        [HttpPut]
        public void UpdateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            _VaccinationCenterService.UpdateVaccinationCenter(vaccinationcenter);
        }


        [HttpGet]
        [Route("totalCenters")]
        public int TotalCenter()
        {
            return _VaccinationCenterService.TotalCenter();
        }
        [HttpGet]
        [Route("SearchVaccinationCenter/{name}")]
        public List<Vaccinationcenter> SearchVaccinationCenter(string name)
        {
            return _VaccinationCenterService.SearchVaccinationCenter(name);
        }
    }
}
