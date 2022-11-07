using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IVaccinesRepository
    {
        List<Vaccine> GetAllVaccine();
        Vaccine GetVaccinesById(int id);
        void CreateVaccines(Vaccine vaccines);
        void UpdateVaccines(Vaccine vaccines);
        void DeleteVaccines(int id);
    }
}
