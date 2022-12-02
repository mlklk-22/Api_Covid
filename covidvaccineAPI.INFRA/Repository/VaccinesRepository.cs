using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.Data;
using covidvaccineAPI.CORE.Repository;
using Dapper;

namespace covidvaccineAPI.INFRA.Repository
{
    public class VaccinesRepository : IVaccinesRepository
    {
        private readonly IDbContext _dbContext;

        public VaccinesRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;

        }


        public void CreateVaccines(Vaccines vaccines)
        {
            var p = new DynamicParameters();
            p.Add("vaccines_name", vaccines.Vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("vaccine_doses", vaccines.Vaccinedoses, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("vaccine_sexp", vaccines.Vaccineexp, dbType: DbType.Date, direction: ParameterDirection.Input);

            _dbContext.Connection.Execute("Vaccines_Package.CREATEVaccines", p, commandType: CommandType.StoredProcedure);
        }


        public void DeleteVaccines(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Vaccines_Package.DELETEVaccines", p, commandType: CommandType.StoredProcedure);
        }



        public List<Vaccines> GetAllVaccines()
        {
            IEnumerable<Vaccines> result = _dbContext.Connection.Query<Vaccines>("Vaccines_Package.GetAllVaccines", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }

        public Vaccines GetVaccinesById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Vaccines> result = _dbContext.Connection.Query<Vaccines>("Vaccines_Package.GetVaccinesById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }



        public void UpdateVaccines(Vaccines vaccines)
        {
            var p = new DynamicParameters();
            p.Add("ID", vaccines.Vaccineid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("vaccines_name", vaccines.Vaccinename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("vaccine_doses", vaccines.Vaccinedoses, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("vaccine_sexp", vaccines.Vaccineexp, dbType: DbType.Date, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Vaccines_Package.UPDATEVaccines", p, commandType: CommandType.StoredProcedure);
        }


        public List<Vaccines> SearchVaccine(string name)
        {
            var p = new DynamicParameters();
            p.Add("vName", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Vaccines> result = _dbContext.Connection.Query<Vaccines>("Vaccines_Package.SearchVaccines", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }



    }
}
