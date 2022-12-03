using covidvaccineAPI.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
  public  interface IUserReservationService
    {
        List<UserReservation> userReservations();

    }
}
