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
    public class HomeRepository : IHomeRepository
    {
        private readonly IDbContext _dbContext;
        public HomeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public void CreateHome(Home home)
        {
            var p = new DynamicParameters();
            p.Add("logo", home.Imagelogo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lTitle1", home.Littletitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("mainTitle", home.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desTitle1", home.Descriptiontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imTitle1", home.Imagetitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("txtButton", home.Textbutton, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("statTitle", home.Statisticstitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desStatistics", home.Descriptionstatistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des1Statistics", home.Desc1statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des2Statistics", home.Desc2statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des3Statistics", home.Desc3statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newwTitle", home.Newstitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm1", home.Newsimage1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm2", home.Newsimage2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm3", home.Newsimage3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes1", home.Newsdesc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes2", home.Newsdesc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes3", home.Newsdesc3, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("HOME_PACKAGE.CreateHome", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteHome(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("HOME_PACKAGE.DeleteHome", p, commandType: CommandType.StoredProcedure);
        }

        public List<Home> GetAllHome()
        {
            var result = _dbContext.Connection.Query<Home>("HOME_PACKAGE.GetAllHome", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateHome(Home home)
        {
            var p = new DynamicParameters();
            p.Add("Id", home.Homeid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("logo", home.Imagelogo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lTitle1", home.Littletitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("mainTitle", home.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desTitle1", home.Descriptiontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imTitle1", home.Imagetitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("txtButton", home.Textbutton, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("statTitle", home.Statisticstitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desStatistics", home.Descriptionstatistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des1Statistics", home.Desc1statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des2Statistics", home.Desc2statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("des3Statistics", home.Desc3statistics, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newwTitle", home.Newstitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm1", home.Newsimage1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm2", home.Newsimage2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsIm3", home.Newsimage3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes1", home.Newsdesc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes2", home.Newsdesc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("newsdes3", home.Newsdesc3, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("HOME_PACKAGE.UpdateHome", p, commandType: CommandType.StoredProcedure);
        }
    }
}
