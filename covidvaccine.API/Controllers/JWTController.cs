using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace covidvaccine.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {



        private readonly IJWTService jwtservice;
        public JWTController(IJWTService jwtservice)
        {
            this.jwtservice = jwtservice;
        }
      

        [HttpPost]
        public IActionResult Auth(Useraccount useraccount )
        {


            var token = jwtservice.Auth(useraccount);

            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }

        }
    }


}
  

