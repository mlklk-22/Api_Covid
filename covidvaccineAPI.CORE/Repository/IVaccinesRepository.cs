using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IVaccinesRepository
    {
        List<Vaccines> GetAllVaccines();
        Vaccines GetVaccinesById(int id);
        void CreateVaccines(Vaccines vaccines);
        void UpdateVaccines(Vaccines vaccines);
        void DeleteVaccines(int id);
        List<Vaccines> SearchVaccine(string name);

    }
}
