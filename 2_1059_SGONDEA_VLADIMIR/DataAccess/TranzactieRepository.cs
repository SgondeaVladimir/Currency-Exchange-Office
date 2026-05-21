using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using _2_1059_SGONDEA_VLADIMIR.Models;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public class TranzactieRepository
    {
        public List<Tranzactie> GetAll()
        {
            List<Tranzactie> lista = new List<Tranzactie>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT Id, ClientId, ValutaId, CasierId, DataTranzactie, SumaValuta, Tip, SumaTotalaLei FROM Tranzactii";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Convertim textul din baza de date inapoi in enum
                        TipTranzactie tipEnum = (TipTranzactie)Convert.ToInt32(reader["Tip"]);

                        lista.Add(new Tranzactie
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ClientId = Convert.ToInt32(reader["ClientId"]),
                            ValutaId = Convert.ToInt32(reader["ValutaId"]),
                            CasierId = Convert.ToInt32(reader["CasierId"]),
                            DataTranzactie = Convert.ToDateTime(reader["DataTranzactie"]),
                            SumaValuta = Convert.ToDecimal(reader["SumaValuta"]),
                            Tip = tipEnum,
                            SumaTotalaLei = Convert.ToDecimal(reader["SumaTotalaLei"])
                        });
                    }
                }
            }
            return lista;
        }

        public void Add(Tranzactie tranzactie)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO Tranzactii (ClientId, ValutaId, CasierId, DataTranzactie, SumaValuta, Tip, SumaTotalaLei) " +
                               "VALUES (@ClientId, @ValutaId, @CasierId, @DataTranzactie, @SumaValuta, @Tip, @SumaTotalaLei)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ClientId", tranzactie.ClientId);
                cmd.Parameters.AddWithValue("@ValutaId", tranzactie.ValutaId);
                cmd.Parameters.AddWithValue("@CasierId", tranzactie.CasierId);
                cmd.Parameters.AddWithValue("@DataTranzactie", tranzactie.DataTranzactie);
                cmd.Parameters.AddWithValue("@SumaValuta", tranzactie.SumaValuta);
                cmd.Parameters.AddWithValue("@Tip", (int)tranzactie.Tip);
                cmd.Parameters.AddWithValue("@SumaTotalaLei", tranzactie.SumaTotalaLei);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Tranzactie tranzactie)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE Tranzactii SET ClientId = @ClientId, ValutaId = @ValutaId, CasierId = @CasierId, " +
                               "DataTranzactie = @DataTranzactie, SumaValuta = @SumaValuta, Tip = @Tip, SumaTotalaLei = @SumaTotalaLei WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ClientId", tranzactie.ClientId);
                cmd.Parameters.AddWithValue("@ValutaId", tranzactie.ValutaId);
                cmd.Parameters.AddWithValue("@CasierId", tranzactie.CasierId);
                cmd.Parameters.AddWithValue("@DataTranzactie", tranzactie.DataTranzactie);
                cmd.Parameters.AddWithValue("@SumaValuta", tranzactie.SumaValuta);
                cmd.Parameters.AddWithValue("@Tip", (int)tranzactie.Tip);
                cmd.Parameters.AddWithValue("@SumaTotalaLei", tranzactie.SumaTotalaLei);
                cmd.Parameters.AddWithValue("@Id", tranzactie.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Tranzactii WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Dictionary<string, int> GetStatisticiValute()
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT v.Cod, COUNT(t.Id) as NrTranzactii 
                        FROM Tranzactii t 
                        JOIN Valute v ON t.ValutaId = v.Id 
                        GROUP BY v.Cod";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read()) stats.Add(r["Cod"].ToString(), Convert.ToInt32(r["NrTranzactii"]));
                }
            }
            return stats;
        }

        public Dictionary<DateTime, decimal> GetEvolutieSaptamanala()
        {
            Dictionary<DateTime, decimal> evolutie = new Dictionary<DateTime, decimal>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT CAST(DataTranzactie AS DATE) as Data, SUM(SumaTotalaLei) as Total 
                        FROM Tranzactii 
                        WHERE DataTranzactie >= DATEADD(day, -7, GETDATE())
                        GROUP BY CAST(DataTranzactie AS DATE)
                        ORDER BY Data";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read()) evolutie.Add(Convert.ToDateTime(r["Data"]), Convert.ToDecimal(r["Total"]));
                }
            }
            return evolutie;
        }
    }
}