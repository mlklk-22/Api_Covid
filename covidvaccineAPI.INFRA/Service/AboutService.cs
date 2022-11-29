using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public void CreateAbout(About about)
        {
            _aboutRepository.CreateAbout(about);
        }

        public void DeleteAbout(int id)
        {
            _aboutRepository.DeleteAbout(id);
        }

        public List<About> GetAllAbout()
        {
           return _aboutRepository.GetAllAbout();
        }

        public void UpdateAbout(About about)
        {
           _aboutRepository.UpdateAbout(about);
        }
    }
}
