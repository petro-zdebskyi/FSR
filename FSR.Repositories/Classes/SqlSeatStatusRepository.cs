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
    public class SqlSeatStatusRepository : ISeatStatusRepository
    {
        #region Queries

        private const string spGetSeatStatusesQuery = "spGetSeatStatuses";
        private const string spGetSeatStatusByIdQuery = "spGetSeatStatusByPersonId";

        #endregion

        #region Private Fields
        
        private readonly SqlConnection _connection;

        #endregion

        #region Constructors

        public SqlSeatStatusRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        #endregion

        #region ISeatStatusRepository

        public List<SeatStatus> GetAllSeatStatuses()
        {
            List<SeatStatus> seatStatusesList = new List<SeatStatus>();
            _connection.Open();
            using (SqlCommand command = new SqlCommand(spGetSeatStatusesQuery, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User();
                        var person = new Person();
                        var flight = new Flight();
                        user.Id = (int)reader[0];
                        user.Name = (string)reader[1];
                        user.Surname = (string)reader[2];
                        user.Login = (string)reader[3];
                        user.Password = (string)reader[4];
                        user.Disabled = (bool)reader[5];
                        person.Id = (int)reader[11];
                        person.Name = (string)reader[12];
                        person.Surname = (string)reader[13];
                        flight.DepatureTime = (DateTime)reader[7];
                        flight.ArrivalTime = (DateTime)reader[8];
                        flight.Depature = (string)reader[9];
                        flight.Destination = (string)reader[10];
                        flight.Id = (int)reader[6];

                        var seat = new Seat(flight);
                        seat.Id = (int)reader[14];
                        seat.Number = (int)reader[15];
                        seat.Cost = (decimal)reader[17];

                        var seatStatus = new SeatStatus(user, person, seat);
                        seatStatus.Id = (int)reader[18];
                        seatStatus.Status = (int)reader[19];
                        seatStatusesList.Add(seatStatus);
                    }
                }
            }
            _connection.Close();
            return seatStatusesList;
        }

        public SeatStatus GetSeatStatusByPersonId(int personId)
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spGetSeatStatusByIdQuery;
                command.Parameters.AddWithValue("@personId", personId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var user = new User();
                        var person = new Person();
                        var flight = new Flight();
                        user.Id = (int)reader[0];
                        user.Name = (string)reader[1];
                        user.Surname = (string)reader[2];
                        user.Login = (string)reader[3];
                        user.Password = (string)reader[4];
                        user.Disabled = (bool)reader[5];
                        person.Id = (int)reader[11];
                        person.Name = (string)reader[12];
                        person.Surname = (string)reader[13];
                        flight.DepatureTime = (DateTime)reader[7];
                        flight.ArrivalTime = (DateTime)reader[8];
                        flight.Depature = (string)reader[9];
                        flight.Destination = (string)reader[10];
                        flight.Id = (int)reader[6];

                        var seat = new Seat(flight);
                        seat.Id = (int)reader[14];
                        seat.Number = (int)reader[15];
                        seat.Cost = (decimal)reader[17];

                        var seatStatus = new SeatStatus(user, person, seat);
                        seatStatus.Id = (int)reader[18];
                        seatStatus.Status = (int)reader[19];

                        _connection.Close();
                        return seatStatus;
                    }
                    _connection.Close();
                    return null;
                }
            }
        }

        #endregion
    }
}
