using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class UserReservationService : IUserReservationService
    {


        private readonly IUserReservationRepository _userReservationRepository;

        public UserReservationService(IUserReservationRepository userReservationRepository)
        {
            _userReservationRepository = userReservationRepository;
        }

        public List<UserReservation> userReservations()
        {
          return  _userReservationRepository.userReservations();
        }
    }
}
