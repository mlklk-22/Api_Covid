using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void CreateReservation(Reservation reservation)
        {
            _reservationRepository.CreateReservation(reservation);
        }

        public void DeleteReservation(int id)
        {
           _reservationRepository.DeleteReservation(id);
        }

        public List<Reservation> GetAllReservation()
        {
            return _reservationRepository.GetAllReservation();
        }

        public Reservation GetReservationById(int id)
        {
            return _reservationRepository.GetReservationById(id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationRepository.UpdateReservation(reservation);
        }
    }
}
