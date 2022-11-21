﻿using covidvaccineAPI.CORE.Data;
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
        public IActionResult login([FromBody] Useraccount useraccount)
        {
            var token = jwtservice.login(useraccount);
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
  
