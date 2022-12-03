using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using covidvaccineAPI.CORE.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public void UpdateUser(Useraccount useraccount)
        {
            _userAccountRepository.UpdateUser(useraccount);
        }
    }
}
