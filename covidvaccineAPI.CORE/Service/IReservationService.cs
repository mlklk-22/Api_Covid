using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
    public interface IReservationService
    {
        void CreateReservation(Reservation reservation);
        List<Reservation> GetAllReservation();
        Reservation GetReservationById(int id);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);
    }
}
