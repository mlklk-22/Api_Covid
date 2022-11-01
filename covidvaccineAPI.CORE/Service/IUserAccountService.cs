using covidvaccineAPI.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace covidvaccineAPI.CORE.Service
{
     public interface IUserAccountService
    {
        List<Useraccount> GetAllUsers();
        Useraccount GetUserById(int id);
        void CreateUser(Useraccount useraccount);
        void UpdateUser(Useraccount useraccount);
        void DeleteUser(int id);
        List<Useraccount> firstvaccine();
        List<Useraccount> Secondvaccine();
        List<Useraccount> NotTokeVaccine();
    }
}
