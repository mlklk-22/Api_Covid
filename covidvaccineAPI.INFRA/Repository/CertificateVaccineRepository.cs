using covidvaccineAPI.CORE.Common;
using covidvaccineAPI.CORE.DTO;
using covidvaccineAPI.CORE.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace covidvaccineAPI.INFRA.Repository
{
    public class CertificateVaccineRepository : ICertificateVaccineRepository
    {
        private readonly IDbContext _dbContext;
        public CertificateVaccineRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CertificateVaccine> GetCertificateVaccine()
        {   
           return _dbContext.Connection.Query<CertificateVaccine>("Vaccines_Package.GetGenralInformation", commandType: CommandType.StoredProcedure).ToList();

        }
    }
}
