using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace covidvaccineAPI.INFRA.Repository
{
    public class UserInfoRepository : IUserInfoRepository
    {


        private readonly IDbContext _dbContext;

        public UserInfoRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserInfo> userInfos()
        {
            IEnumerable<UserInfo> result = _dbContext.Connection.Query<UserInfo>("User_Package.getuserInfo", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
