using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace covidvaccineAPI.INFRA.Service
{
    public class UserAccountService : IUserAccountService
    {

        private readonly IUserAccountRepository _userAccountRepository;
        private readonly IConfiguration _config;
        public UserAccountService (IUserAccountRepository userAccountRepository, IConfiguration config)
        {
            _userAccountRepository = userAccountRepository;
            _config = config;
        }
        public void CreateUser(Useraccount useraccount)
        {
             _userAccountRepository.CreateUser(useraccount);
        }

        public void DeleteUser(int id)
        {
            _userAccountRepository.DeleteUser(id);
        }

        public List<Useraccount> firstvaccine()
        {
            return _userAccountRepository.firstvaccine();
        }

        public List<Useraccount> getALLDOCTOR()
        {
            return _userAccountRepository.getALLDOCTOR();
        }

        public List<Useraccount> GetAllUsers()
        {
            return _userAccountRepository.GetAllUsers();
        }

        public Task<List<Useraccount>> getAlluserVaccine()
        {
            return _userAccountRepository.getAlluserVaccine();
        }

        public Useraccount GetUserById(int id)
        {
            return _userAccountRepository.GetUserById(id);
        }

        public List<Useraccount> NotTokeVaccine()
        {
            return _userAccountRepository.NotTokeVaccine();
        }

        public List<Useraccount> Secondvaccine()
        {
            return _userAccountRepository.Secondvaccine();
        }


        
        public int TotalUsers()
        {
            return _userAccountRepository.TotalUsers();
        }
        public int totalDoctors()
        {
            return _userAccountRepository.totalDoctors();
        }

        public void UpdateUser(Useraccount useraccount)
        {
            if (useraccount.Numberofvaccines == 1 || useraccount.Numberofvaccines == 2)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("Ahmadyaseen20@outlook.com"));
                email.To.Add(MailboxAddress.Parse(useraccount.Email));
                if (useraccount.Numberofvaccines == 1)
                {
                    email.Subject = "  Ahmad bani yaseen";
                    email.Body = new TextPart(TextFormat.Html) { Text = "Ms / Mrs" + " " + useraccount.Fullname + " " + "your have received the first dose " + " " + useraccount.vaccinename +" " + "COVID 19" +" "+ "Ministry Of Health ." };
                }
                else if (useraccount.Numberofvaccines == 2)
                {
                    email.Subject = "  Ahmad bani yaseen";
                    email.Body = new TextPart(TextFormat.Html) { Text = "Ms / Mrs" + " " + useraccount.Fullname + " " + "your have received the Second dose" + " " + useraccount.vaccinename + " " + "COVID 19" + " " + "Ministry Of Health ." };
                }

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.outlook.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("Ahmadyaseen20@outlook.com", "@Ahmad12345");
                smtp.Send(email);
                smtp.Disconnect(true);

            }



            _userAccountRepository.UpdateUser(useraccount);
        }
    }
}
