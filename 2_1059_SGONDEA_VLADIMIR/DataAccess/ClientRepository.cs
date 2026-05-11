using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using _2_1059_SGONDEA_VLADIMIR.Models;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public class ClientRepository
    {
        // READ
        public List<Client> GetAll()
        {
            List<Client> clientiList = new List<Client>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, NumeComplet, CNP, Telefon FROM Clienti";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Client c = new Client
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            NumeComplet = reader["NumeComplet"].ToString(),
                            CNP = reader["CNP"].ToString(),
                            Telefon = reader["Telefon"] != DBNull.Value ? reader["Telefon"].ToString() : ""
                        };
                        clientiList.Add(c);
                    }
                }
            }
            return clientiList;
        }

        // CREATE
        public void Add(Client client)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Clienti (NumeComplet, CNP, Telefon) VALUES (@Nume, @CNP, @Tel)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nume", client.NumeComplet);
                cmd.Parameters.AddWithValue("@CNP", client.CNP);
                cmd.Parameters.AddWithValue("@Tel", string.IsNullOrEmpty(client.Telefon) ? (object)DBNull.Value : client.Telefon);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public void Update(Client client)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Clienti SET NumeComplet = @Nume, CNP = @CNP, Telefon = @Tel WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nume", client.NumeComplet);
                cmd.Parameters.AddWithValue("@CNP", client.CNP);
                cmd.Parameters.AddWithValue("@Tel", string.IsNullOrEmpty(client.Telefon) ? (object)DBNull.Value : client.Telefon);
                cmd.Parameters.AddWithValue("@Id", client.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Clienti WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}