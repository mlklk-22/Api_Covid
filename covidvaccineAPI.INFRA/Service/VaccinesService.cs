using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;

namespace covidvaccineAPI.INFRA.Service
{
    public class VaccinesService : IGenericService<Vaccines>
    {
        private readonly IVaccinesRepository _vaccinesRepository;

        public VaccinesService(IVaccinesRepository vaccinesRepository)
        {
            _vaccinesRepository = vaccinesRepository;
        }

        public void Create(Vaccines item)
        {

            _vaccinesRepository.CreateVaccines(item);

        }

        public void Delete(int id)
        {
            _vaccinesRepository.DeleteVaccines(id);

        }

        public List<Vaccines> GetAll()
        {
            return _vaccinesRepository.GetAllVaccines();
        }

        public Vaccines GetById(int id)
        {
            return _vaccinesRepository.GetVaccinesById(id);
        }

        public List<Vaccines> Search(string name)
        {
            return _vaccinesRepository.SearchVaccine( name);
        }

   

        public void Update(Vaccines item)
        {
            _vaccinesRepository.UpdateVaccines(item);
        }

       

    }
}

