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

    public partial class FormMasaSecim : System.Windows.Forms.Form
    {
        public string SecilenMasaNo { get; set; }
        public FormMasaSecim()
        {
            InitializeComponent();
        }


        private void FormMasaSecim_Load(object sender, EventArgs e)
        { }

        public string SecilenMasa { get; private set; }

        public FormMasaSecim(string bolge, int masaSayisi)
        {
            InitializeComponent();
            List<int> doluMasalar = GetDoluMasalar(bolge);

            for (int i = 1; i <= masaSayisi; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Text = $"{bolge} Masa {i}";
                rb.Tag = $"{bolge}-{i}";
                rb.AutoSize = true;
                if (doluMasalar.Contains(i))
                {
                    rb.Enabled = false;
                }
                flowLayoutPanelMasalar.Controls.Add(rb);
            }
           

        }
        private List<int> GetDoluMasalar(string bolge)
        {
            List<int> doluMasalar = new List<int>();

            string connectionString = "server=localhost;port=3306;database=RestoranDB;user=root;password=Busragyz61;"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MasaNo FROM Masalar WHERE Bolge = @bolge AND Durum != 'Boş'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bolge", bolge);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doluMasalar.Add(reader.GetInt32("MasaNo"));
                    }
                }
            }

            return doluMasalar;
        }


        private void btnTamam_Click(object sender, EventArgs e)
        {



            foreach (RadioButton rb in flowLayoutPanelMasalar.Controls)
            {
                if (rb.Checked)
                {
                    SecilenMasa = rb.Tag.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Lütfen bir masa seçin.");
        }

       
    }
}


