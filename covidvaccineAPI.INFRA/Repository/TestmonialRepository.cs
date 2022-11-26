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
    public class TestmonialRepository : ITestmonialRepository
    {
        private readonly IDbContext _dbContext;

        public TestmonialRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

           public void CreateTestmonial(Testmonial testmonial)
        {
            var p = new DynamicParameters();
            p.Add("Message", testmonial.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("TESTMONIAL_PACKAGE.CreateTestmonial", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTestmonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("TESTMONIAL_PACKAGE.DeleteTestmonial", p, commandType: CommandType.StoredProcedure);
        }

        public List<Testmonial> GetAllTestmonial()
        {
            IEnumerable<Testmonial> result = _dbContext.Connection.Query<Testmonial>("TESTMONIAL_PACKAGE.GetAllTestmonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testmonial GetTestmonialById(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Testmonial> result = _dbContext.Connection.Query<Testmonial>("TESTMONIAL_PACKAGE.GetTestmonialById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateTestmonial(Testmonial testmonial)
        {
            var p = new DynamicParameters();
            p.Add("Id", testmonial.Idtest, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("feed", testmonial.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("TESTMONIAL_PACKAGE.UpdateTestmonial", p, commandType: CommandType.StoredProcedure);
        }
    }
}
