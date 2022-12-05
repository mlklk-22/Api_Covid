using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateVaccineController : ControllerBase
    {
        private readonly ICertificateVaccineService _certificateVaccineService;

        public CertificateVaccineController(ICertificateVaccineService certificateVaccineService)
        {
            _certificateVaccineService = certificateVaccineService;
        }

        [HttpGet]
        public List<CertificateVaccine> GetCertificateVaccine()
        {
            return _certificateVaccineService.GetCertificateVaccine();
        }
    }
}
