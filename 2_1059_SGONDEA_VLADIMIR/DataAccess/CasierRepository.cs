using _2_1059_SGONDEA_VLADIMIR.Models;
using _2_1059_SGONDEA_VLADIMIR.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public class CasierRepository
    {
        public List<Casier> GetAll()
        {
            List<Casier> lista = new List<Casier>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Nume, CodAngajat FROM Casieri";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Casier
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nume = reader["Nume"].ToString(),
                            CodAngajat = reader["CodAngajat"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void Add(Casier casier)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Casieri (Nume, CodAngajat) VALUES (@Nume, @Cod)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nume", casier.Nume);
                cmd.Parameters.AddWithValue("@Cod", casier.CodAngajat);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Casier casier)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Casieri SET Nume = @Nume, CodAngajat = @Cod WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nume", casier.Nume);
                cmd.Parameters.AddWithValue("@Cod", casier.CodAngajat);
                cmd.Parameters.AddWithValue("@Id", casier.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Casieri WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}