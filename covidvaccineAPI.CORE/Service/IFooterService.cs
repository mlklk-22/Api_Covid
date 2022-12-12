using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
    public interface IFooterService
    {
        void CreateFooter(Footer footer);
        List<Footer> GetAllFooter();
        void UpdateFooter(Footer footer);
        void DeleteFooter(int id);
    }
}
