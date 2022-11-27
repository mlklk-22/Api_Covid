using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public void CreateHome(Home home)
        {
            _homeRepository.CreateHome(home);
        }

        public void DeleteHome(int id)
        {
            _homeRepository.DeleteHome(id);
        }

        public List<Home> GetAllHome()
        {
           return _homeRepository.GetAllHome();
        }

        public void UpdateHome(Home home)
        {
            _homeRepository.UpdateHome(home);
        }
    }
}
