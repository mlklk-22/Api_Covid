using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
<<<<<<< HEAD
        public IActionResult login(Useraccount useraccount)
=======
        [Route("auth")]

        public IActionResult Auth ([FromBody] Useraccount useraccount)
>>>>>>> 69e81198af0e6254c6c8afc78823ab6dfd0fd40b
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
  

