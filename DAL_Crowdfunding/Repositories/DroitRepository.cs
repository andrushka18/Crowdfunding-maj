using DAL_Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Crowdfunding.Repositories
{
    public class DroitRepository : IDroitRepository<int, Droit>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["DB_Crowdfunding"].ConnectionString;
        public void Add(Droit entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_Add";
                    command.Parameters.AddWithValue("@role", entity.Role);
                    //command.Parameters.AddWithValue("@idDroit", entity.IdDroit);
                    connection.Open();
                    entity.IdDroit = (int)command.ExecuteScalar();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_Delete";
                    command.Parameters.AddWithValue("@idDroit", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Droit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Droit()
                            {
                                IdDroit = (int)reader["IdDroit"],
                                Role = (string)reader["Role"],


                            };
                        }
                    }
                }
            }
        }

        public Droit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_GetById";
                    command.Parameters.AddWithValue("@idDroit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Droit()
                            {
                                IdDroit = (int)reader["IdDroit"],
                                Role = (string)reader["Role"],

                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

       
        public void Update(int id, Droit entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_Update";
                    command.Parameters.AddWithValue("@idDroit", id);
                    command.Parameters.AddWithValue("@role", entity.Role);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
