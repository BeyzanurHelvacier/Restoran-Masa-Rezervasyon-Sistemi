using System.Text;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace WinFormsApp1
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        private FormKayitlar _kayitFormu;


        private Dictionary<string, NumericUpDown> adetKontrolleri = new Dictionary<string, NumericUpDown>();
        void KategoriYemekleriEkle(FlowLayoutPanel panel, List<(string ad, decimal fiyat)> yemekler)
        {
            panel.Controls.Clear();

            foreach (var yemek in yemekler)
            {
                CheckBox chk = new CheckBox
                {
                    Text = $"{yemek.ad} - {yemek.fiyat}₺",
                    AutoSize = true
                };

                NumericUpDown nud = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 10,
                    Value = 1,
                    Width = 50,
                    Enabled = false
                };

                chk.CheckedChanged += (s, e) =>
                {
                    nud.Enabled = chk.Checked;
                };

                FlowLayoutPanel satir = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true
                };
                satir.Controls.Add(chk);
                satir.Controls.Add(nud);

                panel.Controls.Add(satir);
            }
        }
        private string secilenMasa;
        public void SetSecilenMasa(string masa)
        {
            secilenMasa = masa;
            lblSecilenMasa.Text = masa;
        }
        private MasaRepository masaRepo;


        private int FiyatBul(string secim)
        {
            if (string.IsNullOrEmpty(secim)) return 0;

            try
            {
                
                var parts = secim.Split('-');
                if (parts.Length >= 2)
                {
                    string fiyatStr = parts[1].Replace("₺", "").Trim();
                    if (int.TryParse(fiyatStr, out int fiyat))
                    {
                        return fiyat;
                    }
                }
            }
            catch
            {
                
            }

            return 0;

        }

        public Form1(FormKayitlar kayitlarFormu)
        {
            InitializeComponent();
            _kayitFormu = kayitlarFormu;  
            _kayitFormu.Hide();  
            masaRepo = new MasaRepository();


            
            clbBaslangicYemegi.ItemCheck += clb_ItemCheck;
            clbMeze.ItemCheck += clb_ItemCheck;
            clbAnaYemek.ItemCheck += clb_ItemCheck;
            clbTatli.ItemCheck += clb_ItemCheck;
            clbIcecek.ItemCheck += clb_ItemCheck;


        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.A | Keys.D | Keys.W))
            {
                using (FormSifre sifreFormu = new FormSifre())
                {
                    sifreFormu.ShowDialog();

                    if (sifreFormu.GirisBasarili)
                    {
                        if (!_kayitFormu.Visible)
                            _kayitFormu.Show();
                        else
                            _kayitFormu.BringToFront();
                    }
                }

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void clb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                CheckedListBox clb = sender as CheckedListBox;
                string yemekAdi = clb.Items[e.Index].ToString();
                string key = clb.Name + "_" + yemekAdi;

                bool seciliyor = (e.NewValue == CheckState.Checked);

                if (seciliyor)
                {
                    if (!adetKontrolleri.ContainsKey(key))
                    {
                        NumericUpDown nud = new NumericUpDown();
                        nud.Minimum = 1;
                        nud.Maximum = 10;
                        nud.Value = 1;
                        nud.Width = 40;

                        
                        int y = clb.Top + clb.GetItemRectangle(e.Index).Top;
                        int x = clb.Right + 10;
                        int baseY = clb.Top + clb.GetItemRectangle(e.Index).Top;
                        int index = adetKontrolleri.Count(kv => kv.Key.StartsWith(clb.Name));
                        int offsetX = (index % 3) * 50; 
                        nud.Location = new Point(clb.Right + 10 + offsetX, baseY);

                        nud.Location = new Point(x, y);
                        this.Controls.Add(nud);
                        adetKontrolleri[key] = nud;
                    }
                }
                else
                {
                    if (adetKontrolleri.TryGetValue(key, out NumericUpDown nud))
                    {
                        this.Controls.Remove(nud);
                        nud.Dispose();
                        adetKontrolleri.Remove(key);
                    }
                }
            });
        }





        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {


            clbBaslangicYemegi.Name = "clbBaslangicYemegi";
            clbMeze.Name = "clbMeze";
            clbAnaYemek.Name = "clbAnaYemek";
            clbTatli.Name = "clbTatli";
            clbIcecek.Name = "clbIcecek";




            clbBaslangicYemegi.Items.AddRange(new string[] {
        "Mercimek Çorbası - 60₺",
        "Domates Çorbası - 60₺",
        "Ezogelin Çorbası - 60₺",
        "Yayla Çorbası - 60₺",
        "Sigara Böreği - 75₺",
        "Mücver - 78₺",
        "Kalamar Tava 150₺ ",
        ""
    });
            clbMeze.Items.AddRange(new string[] {
        "Humus - 70₺",
        "Acılı Ezme - 65₺",
        "Zeytinyağlı Yaprak Sarma - 95₺",
        "Havuç Tarator - 70₺",
        "Közlenmiş Patlıcan Salatası - 80₺",
        "Haydari - 70₺",
        "Zeytinyağlı Enginar - 100₺"

    });
            clbAnaYemek.Items.AddRange(new string[] {
    "Izgara Tavuk - 120₺", "Köfte Tabağı - 175₺", "Adana Kebap - 250₺", "Dana Antrikot - 285₺",
    "Fırında Somon - 300₺", "Mantı - 120₺", "Tavuk Şinitzel - 95₺", "Etli Güveç - 255₺",
    "Patlıcan Musakka - 145₺", "Kaşarlı Köfte - 195₺"
});
            clbTatli.Items.AddRange(new string[] {
    "Baklava - 165₺", "Sütlaç - 80₺", "Kazandibi - 95₺", "Tiramisu - 85₺",
    "Profiterol - 100₺", "Cheesecake (Çilekli) - 125₺", "Künefe - 185₺",
    "Mozaik Pasta - 80₺", "Fırın Sütlaç - 85₺", "Dondurma - 55₺"
});

            clbIcecek.Items.AddRange(new string[] {
    "Çay - 35₺",
    "Türk Kahvesi - 55₺",
    "Su - 10₺",
    "Limonata - 45₺",
    "Ayran - 25₺",
    "Sade Soda- 50₺",
    "Buzlu Limonlu Soda - 55₺"
});






            {

                dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string ad = txtMusteriAdi.Text;


            int toplam = 0;
            StringBuilder siparisDetay = new StringBuilder();

            foreach (var item in clbBaslangicYemegi.CheckedItems)
            {
                string yemek = item.ToString();
                string key = "clbBaslangicYemegi_" + yemek;
                int adet = adetKontrolleri.ContainsKey(key) ? (int)adetKontrolleri[key].Value : 1;
                siparisDetay.AppendLine($" - {yemek} x{adet}");
                toplam += FiyatBul(yemek) * adet;
            }


            foreach (var item in clbMeze.CheckedItems)
            {
                string yemek = item.ToString();
                string key = "clbMeze_" + yemek;
                int adet = adetKontrolleri.ContainsKey(key) ? (int)adetKontrolleri[key].Value : 1;
                siparisDetay.AppendLine($" - {yemek} x{adet}");
                toplam += FiyatBul(yemek) * adet;
            }



            foreach (var item in clbAnaYemek.CheckedItems)
            {
                string yemek = item.ToString();
                string key = "clbAnaYemek_" + yemek;
                int adet = adetKontrolleri.ContainsKey(key) ? (int)adetKontrolleri[key].Value : 1;
                siparisDetay.AppendLine($" - {yemek} x{adet}");
                toplam += FiyatBul(yemek) * adet;
            }


            foreach (var item in clbTatli.CheckedItems)
            {
                string yemek = item.ToString();
                string key = "clbTatli_" + yemek;
                int adet = adetKontrolleri.ContainsKey(key) ? (int)adetKontrolleri[key].Value : 1;
                siparisDetay.AppendLine($" - {yemek} x{adet}");
                toplam += FiyatBul(yemek) * adet;
            }


            foreach (var item in clbIcecek.CheckedItems)
            {
                string yemek = item.ToString();
                string key = "clbIcecek_" + yemek;
                int adet = adetKontrolleri.ContainsKey(key) ? (int)adetKontrolleri[key].Value : 1;
                siparisDetay.AppendLine($" - {yemek} x{adet}");
                toplam += FiyatBul(yemek) * adet;
            }




            
            richTextBox1.Clear();
            richTextBox1.Clear();
            richTextBox1.AppendText("---- REZERVASYON FİŞİ ----\n");
            richTextBox1.AppendText($"Rezervasyon Tarihi: {tarih}\n");
            richTextBox1.AppendText($"Ad Soyad: {ad}\n");
            richTextBox1.AppendText($"Masa: {secilenMasa}\n");
            richTextBox1.AppendText("---------------------------\n");
            richTextBox1.AppendText(siparisDetay.ToString());
            richTextBox1.AppendText("---------------------------\n");
            richTextBox1.AppendText($"Toplam Tutar: {toplam} ₺");

            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Lütfen müşteri adını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Rezervasyon tarihi bugünden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (clbBaslangicYemegi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir başlangıç yemeği seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (clbAnaYemek.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ana yemek seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (clbTatli.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir tatlı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MessageBox.Show("Rezervasyon başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormOdeme odemeForm = new FormOdeme(toplam);
            odemeForm.ShowDialog();
            
            int masaId = masaRepo.MasaIdGetir(secilenMasa); 
            if (masaId == -1)
            {
                MessageBox.Show("Masa bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
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
                        cmd.Parameters.AddWithValue("@AdSoyad", ad);
                        cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Tutar", toplam);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rezervasyon kaydı başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); 

        }
        private void lblSecilenMasa_Click(object sender, EventArgs e)
        {
           
        }
        private void clbBaslangicYemegi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}