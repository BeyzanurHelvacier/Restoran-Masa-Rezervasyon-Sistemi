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
    public partial class FormSifre : Form
    {
        private const string DogruSifre = "admin123"; 
        public bool GirisBasarili { get; private set; } = false;
        public FormSifre()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == DogruSifre)
            {
                GirisBasarili = true;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Hatalı şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                txtSifre.Focus();
            }
        }
    }
    }

