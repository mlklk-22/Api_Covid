using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IFooterRepository
    {
        void CreateFooter(Footer footer);
        List<Footer> GetAllFooter();
        void UpdateFooter(Footer footer);
        void DeleteFooter(int id);
    }
}
