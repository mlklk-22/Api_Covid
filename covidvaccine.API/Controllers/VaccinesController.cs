using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace covidvaccine.API.Controllers
{
    public class VaccinesController : GenericController<Vaccines>
    {
       public VaccinesController(IGenericService<Vaccines> genericService) : base(genericService)
        {

        }
        
    }
}
