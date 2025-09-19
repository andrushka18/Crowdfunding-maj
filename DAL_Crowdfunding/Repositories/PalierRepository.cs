using DAL_Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Crowdfunding.Repositories
{
    public class PalierRepository : IPalierRepository<int, Palier>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["DB_Crowdfunding"].ConnectionString;
        public void Add(Palier entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Palier_Add";
                    command.Parameters.AddWithValue("@montant", entity.Montant);
                    command.Parameters.AddWithValue("@prime", entity.Prime);
                    connection.Open();
                    entity.IdPalier = (int)command.ExecuteScalar();
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
                    command.CommandText = "SP_Palier_Delete";
                    command.Parameters.AddWithValue("@idPalier", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Palier> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Palier_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Palier()
                            {
                                IdPalier = (int)reader["IdPalier"],
                                Montant = (decimal)reader["Montant"],
                                Prime = (string)reader["Prime"],

                            };
                        }
                    }
                }
            }
        }

        public Palier Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_GetById";
                    command.Parameters.AddWithValue("@idPalier", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Palier()
                            {
                                IdPalier = (int)reader["IdPalier"],
                                Montant = (decimal)reader["Montant"],
                                Prime = (string)reader["Prime"],

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

        public void Update(int id, Palier entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Palier_Update";
                    command.Parameters.AddWithValue("@idPalier", id);
                    command.Parameters.AddWithValue("@montant", entity.Montant);
                    command.Parameters.AddWithValue("@prime", entity.Prime);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Link(int id, Palier entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Palier_Link";
                    command.Parameters.AddWithValue("@idPalier", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
        }
        public void Unlink(int id, Palier entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Palier_Unlink";
                    command.Parameters.AddWithValue("@idPalier", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
