using covidvaccineAPI.CORE.DTO;
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
    public class userReservationController : ControllerBase
    {


        private readonly IUserReservationService _userReservationService;

        public userReservationController(IUserReservationService userReservationService)
        {
            _userReservationService = userReservationService;
        }

        [HttpGet]
        public List<UserReservation> userReservations()
        {
            return _userReservationService.userReservations();
        }
    }
}
