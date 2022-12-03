using covidvaccineAPI.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
  public  interface IUserReservationRepository
    {
        List<UserReservation> userReservations();
    }
}
