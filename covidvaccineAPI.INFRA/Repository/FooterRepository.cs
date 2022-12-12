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
    public class FooterRepository : IFooterRepository
    {
        private readonly IDbContext _dbContext;
        public FooterRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateFooter(Footer footer)
        {
            var p = new DynamicParameters();
            p.Add("title1", footer.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link1title1", footer.Link1title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link2title1", footer.Link2title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link3title1", footer.Link3title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link4title1", footer.Link4title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("title2", footer.Title2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("desctitle2", footer.Desctitle2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("title3", footer.Title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link1title3", footer.Link1title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link2title3", footer.Link2title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link3title3", footer.Link3title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link4title3", footer.Link4title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("title4", footer.Title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link1title4", footer.Link1title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link2title4", footer.Link2title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link3title4", footer.Link3title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("link4title4", footer.Link4title4, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_PACKAGE.CreateFooter", p, commandType: CommandType.StoredProcedure);

        }

        public void DeleteFooter(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_PACKAGE.DeleteFooter", p, commandType: CommandType.StoredProcedure);
        }

        public List<Footer> GetAllFooter()
        {
            var result = _dbContext.Connection.Query<Footer>("Footer_PACKAGE.GetAllFooter", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public void UpdateFooter(Footer footer)
        {
            var p = new DynamicParameters();
            p.Add("Id", footer.Footerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ftitle1", footer.Title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink1title1", footer.Link1title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink2title1", footer.Link2title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink3title1", footer.Link3title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink4title1", footer.Link4title1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ftitle2", footer.Title2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("fdesctitle2", footer.Desctitle2, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ftitle3", footer.Title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink1title3", footer.Link1title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink2title3", footer.Link2title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink3title3", footer.Link3title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink4title3", footer.Link4title3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("ftitle4", footer.Title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink1title4", footer.Link1title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink2title4", footer.Link2title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink3title4", footer.Link3title4, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flink4title4", footer.Link4title4, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Footer_PACKAGE.UpdateFooter", p, commandType: CommandType.StoredProcedure);
        }
    }
}
