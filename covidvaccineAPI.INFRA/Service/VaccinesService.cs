using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;

namespace covidvaccineAPI.INFRA.Service
{
    public class VaccinesService : IGenericService<Vaccine>
    {
        private readonly IVaccinesRepository _vaccinesRepository;

        public VaccinesService(IVaccinesRepository vaccinesRepository)
        {
            _vaccinesRepository = vaccinesRepository;
        }

        public void Create(Vaccine item)
        {

            _vaccinesRepository.CreateVaccines(item);

        }

       

        public void Delete(int id)
        {
            _vaccinesRepository.DeleteVaccines(id);

        }

        public List<Vaccine> GetAll()
        {
            return _vaccinesRepository.GetAllVaccine();
        }

        public Vaccine GetById(int id)
        {
            return _vaccinesRepository.GetVaccinesById(id);
        }

        public void Update(Vaccine item)
        {
            _vaccinesRepository.UpdateVaccines(item);
        }

       

        List<Vaccine> IGenericService<Vaccine>.GetAll()
        {
            throw new NotImplementedException();
        }

        Vaccine IGenericService<Vaccine>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

