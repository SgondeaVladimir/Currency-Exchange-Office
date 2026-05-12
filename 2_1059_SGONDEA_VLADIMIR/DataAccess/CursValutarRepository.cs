using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using _2_1059_SGONDEA_VLADIMIR.Models;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public class CursValutarRepository
    {
        public List<CursValutar> GetAll()
        {
            List<CursValutar> lista = new List<CursValutar>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, ValutaId, DataCotatiei, CursCumparare, CursVanzare FROM CursuriValutare";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new CursValutar
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ValutaId = Convert.ToInt32(reader["ValutaId"]),
                            DataCotatiei = Convert.ToDateTime(reader["DataCotatiei"]),
                            CursCumparare = Convert.ToDecimal(reader["CursCumparare"]),
                            CursVanzare = Convert.ToDecimal(reader["CursVanzare"])
                        });
                    }
                }
            }
            return lista;
        }

        public void Add(CursValutar curs)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO CursuriValutare (ValutaId, DataCotatiei, CursCumparare, CursVanzare) VALUES (@ValutaId, @DataCotatiei, @CursCumparare, @CursVanzare)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ValutaId", curs.ValutaId);
                cmd.Parameters.AddWithValue("@DataCotatiei", curs.DataCotatiei);
                cmd.Parameters.AddWithValue("@CursCumparare", curs.CursCumparare);
                cmd.Parameters.AddWithValue("@CursVanzare", curs.CursVanzare);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(CursValutar curs)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE CursuriValutare SET ValutaId = @ValutaId, DataCotatiei = @DataCotatiei, CursCumparare = @CursCumparare, CursVanzare = @CursVanzare WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ValutaId", curs.ValutaId);
                cmd.Parameters.AddWithValue("@DataCotatiei", curs.DataCotatiei);
                cmd.Parameters.AddWithValue("@CursCumparare", curs.CursCumparare);
                cmd.Parameters.AddWithValue("@CursVanzare", curs.CursVanzare);
                cmd.Parameters.AddWithValue("@Id", curs.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM CursuriValutare WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}