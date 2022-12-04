using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace covidvaccine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpPost]
        public void CreateReservation(Reservation reservation)
        {
            _reservationService.CreateReservation(reservation);
        }
        [HttpDelete]
        public void DeleteReservation(int id)
        {
            _reservationService.DeleteReservation(id);
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Reservation> GetAllReservation()
        {
            return _reservationService.GetAllReservation();
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public Reservation GetReservationById(int id)
        {
            return _reservationService.GetReservationById(id);
        }
        [HttpPut]
        public void UpdateReservation(Reservation reservation)
        {
            _reservationService.UpdateReservation(reservation);
        }
        [HttpGet]
        [Route("searchByFirstDose/{DateFrom}/{DateTo}")]
        public List<Reservation> SearchBetweenFirstDose(DateTime? DateFrom, DateTime? DateTo)
        {
            return _reservationService.SearchBetweenFirstDose(DateFrom, DateTo);
        }
        [HttpGet]
        [Route("searchBySecondDose/{DateFrom}/{DateTo}")]
        public List<Reservation> SearchBetweenSecondDose(DateTime? DateFrom, DateTime? DateTo)
        {
            return _reservationService.SearchBetweenSecondDose(DateFrom, DateTo);
        }

    }
}
