using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class MasaRepository
    {
        public List<Masa> GetMasalar()
        {
            List<Masa> masalar = new List<Masa>();

            using (MySqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Masalar";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    masalar.Add(new Masa
                    {
                        Id = reader.GetInt32("Id"),
                        Bolge = reader.GetString("Bolge"),
                        MasaNo = reader.GetInt32("MasaNo"),
                        Durum = reader.GetString("Durum")
                    });
                }
            }

            return masalar;
        }
        public int MasaIdGetir(string masaAdi)
        {
            string connectionString = "server=localhost;port=3306;database=RestoranDB;user=root;password=Busragyz61;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string[] parcalar = masaAdi.Split('-');
                    string bolge = parcalar[0];
                    string masaNo = parcalar[1];

                    string query = "SELECT id FROM Masalar WHERE Bolge = @Bolge AND MasaNo = @MasaNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Bolge", bolge);
                        cmd.Parameters.AddWithValue("@MasaNo", masaNo);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
                catch
                {
                    return -1;
                }
            }
        }

    }
}

