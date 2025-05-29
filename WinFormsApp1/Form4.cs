using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormOdeme : Form
    {
        private int toplamTutar;

        public FormOdeme(int toplam)
        {
            InitializeComponent();
            toplamTutar = toplam;
        }
        public FormOdeme()
        {
            InitializeComponent();
        }

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            {
                cmbOdemeYontemi.Items.AddRange(new string[] { "Kredi Kartı", "Nakit", "Online" });
                lblTutar.Text = $"Toplam Tutar: {toplamTutar} ₺";

                
                grpKrediKarti.Visible = false;
            }

        }

        private void cmbOdemeYontemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpKrediKarti.Visible = cmbOdemeYontemi.SelectedItem.ToString() == "Kredi Kartı";
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (cmbOdemeYontemi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
                return;
            }

            if (cmbOdemeYontemi.SelectedItem.ToString() == "Kredi Kartı")
            {
                
                if (string.IsNullOrWhiteSpace(txtKartNo.Text) || string.IsNullOrWhiteSpace(txtSonKullanma.Text) || string.IsNullOrWhiteSpace(txtCVV.Text))
                {
                    MessageBox.Show("Lütfen tüm kart bilgilerini doldurun.");
                    return;
                }
            }

            MessageBox.Show("Ödeme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
    }

