using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSR.Entities;
using System.Data.SqlClient;
using System.Data;
using FSR.Repositories.Interfaces;

namespace FSR.Repositories.Classes
{
    public class SqlUserRepository : IUserRepository
    {
        #region Queries

        private const string spGetUserByLoginQuery = "spGetUserByLogin";

        #endregion
        
        #region Constructors

        public SqlUserRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        #endregion

        #region IUserRepository

        public User GetUserByLogin(string login, string password)
        {
            _connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = _connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spGetUserByLoginQuery;
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    User user = null;
                    if (reader.Read())
                    {
                        user = new User();
                        user.Id = (int)reader["Id"];
                        user.Name = (string)reader["Name"];
                        user.Surname = (string)reader["Surname"];
                        user.Login = (string)reader["Login"];
                        user.Disabled = (bool)reader["Disabled"];
                    }
                    _connection.Close();
                    return user;
                }
            }
        }

        #endregion

        #region Private Fields

        private readonly SqlConnection _connection;

        #endregion
    }
}
