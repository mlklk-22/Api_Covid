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
   public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext _dbContext;

        public JWTRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Useraccount login(Useraccount useraccount)
        {
            var p = new DynamicParameters();
            p.Add("user_name", useraccount.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", useraccount.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Useraccount>("login_package.User_Login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
