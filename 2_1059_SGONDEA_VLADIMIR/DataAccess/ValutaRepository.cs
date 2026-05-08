using _2_1059_SGONDEA_VLADIMIR.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public class ValutaRepository
    {
        // Functia care citeste toate valutele din baza de date
        public List<Valuta> GetAll()
        {
            List<Valuta> valuteList = new List<Valuta>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, Cod, Denumire FROM Valute";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Valuta v = new Valuta
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Cod = reader["Cod"].ToString(),
                            Denumire = reader["Denumire"].ToString()
                        };
                        valuteList.Add(v);
                    }
                }
            }
            return valuteList;
        }

        // CREATE: Functia care adauga o valuta noua
        public void Add(Valuta valuta)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                // Folosim parametri (@Cod, @Denumire) pentru a preveni SQL Injection
                string query = "INSERT INTO Valute (Cod, Denumire) VALUES (@Cod, @Denumire)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Cod", valuta.Cod);
                cmd.Parameters.AddWithValue("@Denumire", valuta.Denumire);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE: Functia care modifica o valuta existenta
        public void Update(Valuta valuta)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Valute SET Cod = @Cod, Denumire = @Denumire WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Cod", valuta.Cod);
                cmd.Parameters.AddWithValue("@Denumire", valuta.Denumire);
                cmd.Parameters.AddWithValue("@Id", valuta.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // DELETE: Functia care sterge o valuta pe baza ID-ului
        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Valute WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
