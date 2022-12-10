using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IVaccinationCenterRepository
    {
        List<Vaccinationcenter> GetAllVaccinationCenter();
        void CreateVaccinationCenter(Vaccinationcenter vaccinationcenter);
        void UpdateVaccinationCenter(Vaccinationcenter vaccinationcenter);
        void DeleteVaccinationCenter(int id);
        Vaccinationcenter GetVaccinationCenterById (int id);
        int TotalCenter();
    }
}
