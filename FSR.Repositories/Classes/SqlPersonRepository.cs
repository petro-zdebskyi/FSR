using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;
using FSR.Repositories.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace FSR.Repositories.Classes
{
    public class SqlPersonRepository : IPersonRepository
    {

        #region Queries

        private const string spReserveSeatQuery = "spReserveSeat";
        private const string spCancelReservingQuery = "spCancelReserving";
         
        #endregion
        
        #region Constructors

        public SqlPersonRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
        
        #endregion

        #region IPersonRepository
        public void MakeReserveation(int userId, string personName, string personSurname, int flightId, int seat)
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spReserveSeatQuery;
                command.Parameters.AddWithValue("@userid", userId);
                command.Parameters.AddWithValue("@name", personName);
                command.Parameters.AddWithValue("@surname", personSurname);
                command.Parameters.AddWithValue("@flight", flightId);
                command.Parameters.AddWithValue("@seat", seat);
                command.ExecuteNonQuery();
            }
            _connection.Close();
        }

        public void CancelReservation(int userId, int seatStatusId)
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spCancelReservingQuery;
                command.Parameters.AddWithValue("@userid", userId);
                command.Parameters.AddWithValue("@seatStatusId", seatStatusId);
                command.ExecuteNonQuery();
            }
            _connection.Close();
        }

        #endregion

        #region Private Fields

        private readonly SqlConnection _connection;

        #endregion
    }
}
