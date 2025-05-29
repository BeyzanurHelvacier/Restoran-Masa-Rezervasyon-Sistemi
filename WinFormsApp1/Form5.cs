using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{

    public partial class FormKayitlar : Form
    {
        public FormKayitlar()
        {
            InitializeComponent();

            dgvKayitlar.Columns.Add("ID", "Rezervasyon ID");
            dgvKayitlar.Columns.Add("AdSoyad", "Ad Soyad");
            dgvKayitlar.Columns.Add("Tarih", "Tarih");
            dgvKayitlar.Columns.Add("Tutar", "Tutar");
            dgvKayitlar.Columns.Add("Masa", "Masa");

            this.Load += FormKayitlar_Load;

            

        }

        private void FormKayitlar_Load(object sender, EventArgs e)
        {
            KayitlariYenile();
        }

        
        public void KayitlariYenile()
        {
            dgvKayitlar.Rows.Clear();

            string connectionString = "server=localhost;port=3306;database=RestoranDB;user=root;password=Busragyz61;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT r.id, r.AdSoyad, r.Tarih, r.Tutar, CONCAT(m.Bolge, '-', m.MasaNo) AS Masa " +
                                   "FROM Rezervasyonlar r JOIN Masalar m ON r.MasaId = m.id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvKayitlar.Rows.Add(
                                reader["id"],
                                reader["AdSoyad"],
                                Convert.ToDateTime(reader["Tarih"]).ToString("yyyy-MM-dd HH:mm"),
                                reader["Tutar"],
                                reader["Masa"]
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        
        private void btnEkleRezervasyon_Click(object sender, EventArgs e)
        {
            int masaId = 2;
            string adSoyad = "Ahmet Yılmaz";
            DateTime tarih = DateTime.Now;
            decimal tutar = 150.00m;

            EkleRezervasyon(masaId, adSoyad, tarih, tutar);
        }

        private void EkleRezervasyon(int masaId, string adSoyad, DateTime tarih, decimal tutar)
        {
            string connectionString = "server=localhost;port=3306;database=RestoranDB;user=root;password=Busragyz61;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Rezervasyonlar (MasaId, AdSoyad, Tarih, Tutar) VALUES (@MasaId, @AdSoyad, @Tarih, @Tutar)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MasaId", masaId);
                        cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@Tutar", tutar);
                        cmd.ExecuteNonQuery();
                    }

                    
                    KayitlariYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rezervasyon eklenemedi: " + ex.Message);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (dgvKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kaydı seçin.");
                return;
            }

            DataGridViewRow selectedRow = dgvKayitlar.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value); 

            DialogResult result = MessageBox.Show("Seçilen kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            string connectionString = "server=localhost;port=3306;database=RestoranDB;user=root;password=Busragyz61;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Rezervasyonlar WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int affected = cmd.ExecuteNonQuery();

                        if (affected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.");
                            KayitlariYenile();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt silinemedi (veritabanında bulunamadı).");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}