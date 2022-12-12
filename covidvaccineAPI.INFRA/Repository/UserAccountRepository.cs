using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace covidvaccineAPI.INFRA.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        static string CreatePasswordHash(string pass)

        {
            var algo = SHA256.Create();
            var asByte = Encoding.Default.GetBytes(pass);
            var hashedPass = algo.ComputeHash(asByte);
            return Convert.ToBase64String(hashedPass);

        }


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
            p.Add("Password_User", CreatePasswordHash(useraccount.Password), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Age_User", useraccount.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Role_id", useraccount.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("namevaccine", useraccount.vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("User_Package.CreateUser", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("User_Package.DeleteUser", p, commandType: CommandType.StoredProcedure);
        }

        public List<Useraccount> firstvaccine()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.firstvaccine", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Useraccount> getALLDOCTOR()
        {

            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.getALLDOCTOR", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Useraccount> GetAllUsers()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.GetAllUsers", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

      

        public Useraccount GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.GetUserById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();

        }

        public List<Useraccount> NotTokeVaccine()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.NotTokeVaccine", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Useraccount> Secondvaccine()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.Secondvaccine", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateUser(Useraccount useraccount)
        {
            var p = new DynamicParameters();
            p.Add("ID", useraccount.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Full_Name", useraccount.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("User_Name", useraccount.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phone", useraccount.Phonenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Number_of_Vaccines", useraccount.Numberofvaccines, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ImagePath", useraccount.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_User", useraccount.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Password_User", CreatePasswordHash(useraccount.Password), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Age_User", useraccount.Age, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Role_id", useraccount.Roleid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("namevaccine", useraccount.vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.Execute("User_Package.UpdateUser", p, commandType: CommandType.StoredProcedure);

        }


        public async Task<List<Useraccount>> getAlluserVaccine()
        {


            var result = await _dbContext.Connection.QueryAsync<Useraccount, Reservation, Useraccount>("User_Package.getAlluserVaccine()",

                (Useraccount, Reservation) =>
                {
                    Useraccount.Reservations.Add(Reservation);
                    return Useraccount;
                },
                splitOn: "Reserveid",
                param: null,
                commandType: CommandType.StoredProcedure);
                return result.ToList();

        }








        public int TotalUsers()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.Totalusers", commandType: System.Data.CommandType.StoredProcedure);
            return result.Count();
        }
        public int totalDoctors()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("User_Package.totalDoctors", commandType: System.Data.CommandType.StoredProcedure);
            return result.Count();
        }


    }
}
