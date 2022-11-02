using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Repository
{
    public interface IReservationRepository
    {
        void CreateReservation(Reservation reservation);
        List<Reservation> GetAllReservation();
        Reservation GetReservationById(int id);
        void UpdateReservation(Reservation reservation);
        void DeleteReservation(int id);

    }
}
