using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.INFRA.Service
{
    public class UserAccountService : IUserAccountService
    {

        private readonly IUserAccountRepository _userAccountRepository;
        public UserAccountService (IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
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

        public List<Useraccount> GetAllUsers()
        {
            return _userAccountRepository.GetAllUsers();
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

        public void UpdateUser(Useraccount useraccount)
        {
            _userAccountRepository.UpdateUser(useraccount);
        }
    }
}
