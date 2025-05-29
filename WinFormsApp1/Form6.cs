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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            
            FormKayitlar kayitFormu = new FormKayitlar();
            
            Form1 form1 = new Form1(kayitFormu);

            this.Hide();           
            form1.ShowDialog();    
            this.Close();          
        }
    }
    }

