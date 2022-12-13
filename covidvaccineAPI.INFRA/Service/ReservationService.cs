using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserAccountRepository _userAccountRepository;

        public ReservationService(IReservationRepository reservationRepository, IUserAccountRepository userAccountRepository)
        {
            _reservationRepository = reservationRepository;
            _userAccountRepository = userAccountRepository;
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

        public List<Reservation> SearchBetweenFirstDose(DateTime? DateFrom, DateTime? DateTo)
        {
            return _reservationRepository.SearchBetweenFirstDose(DateFrom, DateTo);
        }

        public List<Reservation> SearchBetweenSecondDose(DateTime? DateFrom, DateTime? DateTo)
        {
          return _reservationRepository.SearchBetweenSecondDose(DateFrom, DateTo);    
        }

        public void UpdateReservation(Reservation reservation)
        {

            List<Useraccount> useraccounts = _userAccountRepository.GetAllUsers();
            string emaill = "";
            foreach (var item in useraccounts)
            {
                if (item.Userid == reservation.Userid)
                {
                    emaill = item.Email;
                    break;
                }

            }
           
           
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("Ahmadyaseen20@outlook.com"));
                email.To.Add(MailboxAddress.Parse(emaill));
                if (reservation.Status.Equals( "accept"))
                {

                    email.Subject = "  Ahmad bani yaseen";
                    email.Body = new TextPart(TextFormat.Html) { Text = "Your Reservation as Accept" };
                }
                else if (reservation.Status.Equals("reject"))
                {

                    email.Subject = "  Ahmad bani yaseen";
                    email.Body = new TextPart(TextFormat.Html) { Text = "Your Reservation as Reject" };
                }


                using var smtp = new SmtpClient();
                smtp.Connect("smtp.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("Ahmadyaseen20@outlook.com", "@Ahmad12345");
                smtp.Send(email);
                smtp.Disconnect(true);
            
            _reservationRepository.UpdateReservation(reservation);
        }
    }
}
