using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class CertificateVaccineService : ICertificateVaccineService
    {
        private readonly ICertificateVaccineRepository _certificateVaccineRepository;

        public CertificateVaccineService(ICertificateVaccineRepository certificateVaccineRepository)
        {
            _certificateVaccineRepository = certificateVaccineRepository;
        }

        public List<CertificateVaccine> GetCertificateVaccine()
        {
           return _certificateVaccineRepository.GetCertificateVaccine();
        }
    }
}
