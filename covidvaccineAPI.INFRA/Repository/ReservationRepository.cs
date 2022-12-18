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
    public class ReservationRepository : IReservationRepository
    {
        private readonly IDbContext _dbContext;

        public ReservationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateReservation(Reservation reservation)
        {
            var p = new DynamicParameters();
            p.Add("ActualDateDose1", reservation.Actualdatedose1, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("ActualDateDose2", reservation.Actualdatedose2, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("massageUser", reservation.Massage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StatusUser", reservation.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("useridd", reservation.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("RESERVATION_PACKAGE.CreateReservation", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteReservation(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("RESERVATION_PACKAGE.DeleteReservation", p, commandType: CommandType.StoredProcedure);

        }

        public List<Reservation> GetAllReservation()
        {
            IEnumerable<Reservation> result = _dbContext.Connection.Query<Reservation>("RESERVATION_PACKAGE.GetAllReservation", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Reservation GetReservationById(int id)
        {
            var p = new DynamicParameters();
            p.Add("Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Reservation> result = _dbContext.Connection.Query<Reservation>("RESERVATION_PACKAGE.GetReservationById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public void UpdateReservation(Reservation reservation)
        {
            var p = new DynamicParameters();
            p.Add("Id", reservation.Reserveid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Actualdatedose1", reservation.Actualdatedose1, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("Actualdatedose2", reservation.Actualdatedose2, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("massageUser", reservation.Massage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StatusUser", reservation.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("RESERVATION_PACKAGE.UpdateReservation", p, commandType: CommandType.StoredProcedure);
        }

       public List<Reservation> SearchBetweenFirstDose(DateTime? DateFrom, DateTime? DateTo)
        {
            var p = new DynamicParameters();
            p.Add("DateFrom", DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("DateTo", DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<Reservation> result = _dbContext.Connection.Query<Reservation>("RESERVATION_PACKAGE.SearchBetweenFirstDose", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Reservation> SearchBetweenSecondDose(DateTime? DateFrom, DateTime? DateTo)
        {
            var p = new DynamicParameters();
            p.Add("DateFrom", DateFrom, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("DateTo", DateTo, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<Reservation> result = _dbContext.Connection.Query<Reservation>("RESERVATION_PACKAGE.SearchBetweenSecondDose", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


    }
}