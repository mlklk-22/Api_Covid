using System;
using System.Collections.Generic;
using covidvaccineAPI.CORE.Data;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IVaccinesRepository
    {
        List<Vaccines> GetAllVaccine();
        Vaccines GetVaccinesById(int id);
        void CreateVaccines(Vaccines vaccines);
        void UpdateVaccines(Vaccines vaccines);
        void DeleteVaccines(int id);
    }
}
