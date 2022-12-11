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
    public class VaccinationCenterRepository : IVaccinationCenterRepository
    {
        private readonly IDbContext _dbContext;

        public VaccinationCenterRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            var p = new DynamicParameters();
            p.Add("CENTERNAME" , vaccinationcenter.Centername , dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UserCapacity" , vaccinationcenter.Centerusercapacity , dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("VaccinationCapacity" ,vaccinationcenter.Centervaccinecapacity , dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CenterAddress", vaccinationcenter.Centeraddres, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("VACCINATIONCENTER_Package.CreateVaccinationCenter", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteVaccinationCenter(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("VACCINATIONCENTER_Package.DeleteVaccinationCenter", p, commandType: CommandType.StoredProcedure);
        }

        public List<Vaccinationcenter> GetAllVaccinationCenter()
        {
            IEnumerable<Vaccinationcenter> result = _dbContext.Connection.Query<Vaccinationcenter>("VACCINATIONCENTER_Package.GetAllVaccinationCenter", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Vaccinationcenter GetVaccinationCenterById(int id)
        {
            var p = new DynamicParameters();
            p.Add("ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Vaccinationcenter> result = _dbContext.Connection.Query<Vaccinationcenter>("VACCINATIONCENTER_Package.GetVaccinationCenterById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateVaccinationCenter(Vaccinationcenter vaccinationcenter)
        {
            var p = new DynamicParameters();
            p.Add("ID", vaccinationcenter.Centerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CENTERNAME", vaccinationcenter.Centername, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("UserCapacity", vaccinationcenter.Centerusercapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("VaccinationCapacity", vaccinationcenter.Centervaccinecapacity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CenterAddress", vaccinationcenter.Centeraddres, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("VACCINATIONCENTER_Package.UpdateVaccinationCenter", p, commandType: CommandType.StoredProcedure);
        }

        public int TotalCenter()
        {
            IEnumerable<Useraccount> result = _dbContext.Connection.Query<Useraccount>("VACCINATIONCENTER_Package.GetAllVaccinationCenter", commandType: System.Data.CommandType.StoredProcedure);
            return result.Count();
        }

        public List<Vaccinationcenter> SearchVaccinationCenter(string name)
        {
            var p = new DynamicParameters();
            p.Add("vName", name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Vaccinationcenter> result = _dbContext.Connection.Query<Vaccinationcenter>("VACCINATIONCENTER_Package.SearchVaccinationCenter", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
