using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class FooterService : IFooterService
    {
        private readonly IFooterRepository _footerRepository;

        public FooterService(IFooterRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }
        public void CreateFooter(Footer footer)
        {
            _footerRepository.CreateFooter(footer);
        }

        public void DeleteFooter(int id)
        {
            _footerRepository.DeleteFooter(id);
        }

        public List<Footer> GetAllFooter()
        {
            return _footerRepository.GetAllFooter();
        }

        public void UpdateFooter(Footer footer)
        {
            _footerRepository.UpdateFooter(footer); ;
        }
    }
}
