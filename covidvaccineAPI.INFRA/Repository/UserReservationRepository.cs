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
    public class UserReservationRepository : IUserReservationRepository
    {
        private readonly IDbContext _dbContext;

        public UserReservationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<UserReservation> userReservations()
        {
            IEnumerable<UserReservation> result = _dbContext.Connection.Query<UserReservation>("User_Package.getAlluserVaccine", commandType: System.Data.CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
