using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IVaccinesRepository
    {
        List<Vaccine> GetAllVaccines();
        Vaccine GetVaccinesById(int id);
        void CreateVaccines(Vaccine vaccines);
        void UpdateVaccines(Vaccine vaccines);
        void DeleteVaccines(int id);
        List<Vaccine> SearchVaccine(string name);

    }
}
