using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace covidvaccineAPI.INFRA.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {


        private readonly IDbContext _dbContext;

        public UserAccountRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateUser(Useraccount useraccount)
        {
            var p = new DynamicParameters();
            p.Add("Full_Name", useraccount.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("User_Name", useraccount.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phone", useraccount.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Number_of_Vaccines", useraccount.Numberofvaccines, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ImagePath", useraccount.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_User", useraccount.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password_User", useraccount.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Age_User", useraccount.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Role_id", useraccount.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result= _dbContext.Connection.Execute("User_Package.CreateUser", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result= _dbContext.Connection.Execute("User_Package.DeleteUser", p, commandType: CommandType.StoredProcedure);
        }

        public List<Useraccount> firstvaccine()
        {
            throw new NotImplementedException();
        }

        public List<Useraccount> GetAllUsers()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.GetAllUsers", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public Useraccount GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Useraccount> NotTokeVaccine()
        {
            throw new NotImplementedException();
        }

        public List<Useraccount> Secondvaccine()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Useraccount useraccount)
        {
            throw new NotImplementedException();
        }
    }
}
