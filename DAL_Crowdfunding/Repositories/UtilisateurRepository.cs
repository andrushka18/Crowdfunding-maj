using DAL_Crowdfunding.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Crowdfunding.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository<int, Utilisateur>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["DB_Crowdfunding"].ConnectionString;

        public void Add(Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Add";
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@prenom", entity.Prenom);
                    command.Parameters.AddWithValue("@nomUtilisateur", entity.NomUtilisateur);
                    command.Parameters.AddWithValue("@password", entity.Password);
                    command.Parameters.AddWithValue("@role", entity.Role);

                    connection.Open();
                    entity.UtilisateurId = (int)command.ExecuteScalar();
                    
                }
            }
            

        }

        public void ChangePassword(int id, string Password)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_ChangePassword";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@password", Password);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SetAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_SetAdmin";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UnsetAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_UnsetAdmin";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public int Check(string NomUtilisateur, string Password)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SP_Login";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomUtilisateur", NomUtilisateur);
                cmd.Parameters.AddWithValue("@password", Password);
               
                cmd.Parameters.AddWithValue("@utilisateurId", DbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["UtilisateurId"].Value;
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Delete";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Utilisateur> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Utilisateur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Nom = (string)reader["Nom"],
                                Prenom = (string)reader["Prenom"],
                                NomUtilisateur = (string)reader["NomUtilisateur"],
                                Password = "********",
                                Role = (string)reader["Role"] 
                              

                            };
                        }
                    }
                }
            }
        }

        public Utilisateur Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_GetById";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Utilisateur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Nom = (string)reader["Nom"],
                                Prenom = (string)reader["Prenom"],
                                NomUtilisateur = (string)reader["NomUtilisateur"],
                                Password = "********",
                                Role = (string)reader["Role"]
                               
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

        public void Update(int id, Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Update";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@prenom", entity.Prenom);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Registration(Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Add";
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@prenom", entity.Prenom);
                    command.Parameters.AddWithValue("@nomUtilisateur", entity.NomUtilisateur);
                    command.Parameters.AddWithValue("@password", entity.Password);
                    


                    connection.Open();
                    entity.UtilisateurId = (int)command.ExecuteScalar();

                }
            }
        }
    }
}
