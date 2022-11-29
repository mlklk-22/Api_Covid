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
    public class AboutRepository : IAboutRepository
    {
        private readonly IDbContext _dbContext;
        public AboutRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateAbout(About about)
        {
            var p = new DynamicParameters();
            p.Add("lTitle1", about.Littletitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("mainTitle", about.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desTitle1", about.Descriptiontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imTitle1", about.Imagetitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("txtButton", about.Textbuttontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wTitle", about.Whattitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wDescription", about.Whatdescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc1", about.Whatdesc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc2", about.Whatdesc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc3", about.Whatdesc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wTextButton", about.Whattextbutton, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wImage", about.Whatimage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("littleProTitle", about.Littleprotecttitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProTitle", about.Protecttitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("descPro", about.Descprotect, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("propoint1", about.Protectpoint1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("propoint2", about.Protectpoint2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc1", about.Point1desc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc2", about.Point1desc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc3", about.Point1desc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc1", about.Point2desc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc2", about.Point2desc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc3", about.Point2desc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("proImage", about.Protectimage, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ABOUT_PACKAGE.CreateAbout", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteAbout(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ABOUT_PACKAGE.DeleteAbout", p, commandType: CommandType.StoredProcedure);
        }

        public List<About> GetAllAbout()
        {
            var result = _dbContext.Connection.Query<About>("ABOUT_PACKAGE.GetAllAbout", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateAbout(About about)
        {
            var p = new DynamicParameters();
            p.Add("Id", about.Aboutid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("lTitle1", about.Littletitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("mainTitle", about.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desTitle1", about.Descriptiontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imTitle1", about.Imagetitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("txtButton", about.Textbuttontitle1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wTitle", about.Whattitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wDescription", about.Whatdescription, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc1", about.Whatdesc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc2", about.Whatdesc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wdesc3", about.Whatdesc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wTextButton", about.Whattextbutton, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("wImage", about.Whatimage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("littleProTitle", about.Littleprotecttitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ProTitle", about.Protecttitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("descPro", about.Descprotect, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("propoint1", about.Protectpoint1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("propoint2", about.Protectpoint2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc1", about.Point1desc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc2", about.Point1desc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin1desc3", about.Point1desc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc1", about.Point2desc1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc2", about.Point2desc2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("poin2desc3", about.Point2desc3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("proImage", about.Protectimage, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("ABOUT_PACKAGE.UpdateAbout", p, commandType: CommandType.StoredProcedure);

        }
    }
}
