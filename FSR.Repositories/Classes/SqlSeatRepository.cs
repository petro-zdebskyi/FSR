using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;
using FSR.Repositories.Interfaces;
using System.Data.SqlClient;

namespace FSR.Repositories.Classes
{
    public class SqlSeatRepository : ISeatRepository
    {
        #region Queries

        private const string spGetSeatsQuery = "spGetSeats";

        #endregion
        
        #region Constructors

        public SqlSeatRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        #endregion

        #region ISeatRepository

        public List<Seat> GetAllSeats()
        {
            List<Seat> seatsList = new List<Seat>();
            _connection.Open();
            using (SqlCommand command = new SqlCommand(spGetSeatsQuery, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var flight = new Flight();
                        flight.DepatureTime = (DateTime)reader[3];
                        flight.ArrivalTime = (DateTime)reader[4];
                        flight.Depature = (string)reader[5];
                        flight.Destination = (string)reader[6];
                        flight.Id = (int)reader[2];

                        var seat = new Seat(flight);
                        seat.Id = (int)reader[0];
                        seat.Number = (int)reader[1];
                        seat.Cost = (decimal)reader[7];

                        seatsList.Add(seat);
                    }
                    _connection.Close();
                    return seatsList;
                }
            }
        }

        #endregion

        #region Private Fields

        // IP: роботу з ініціалізацією ПОВСЮДНОВЖИВАНОГО поля "_connection" можна було б сміливо винести в окремий базовий клас (це стосується усіх репозиторіїв)
        private readonly SqlConnection _connection;

        #endregion
    }
}
