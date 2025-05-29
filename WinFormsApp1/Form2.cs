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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormMasaSecim frm = new FormMasaSecim("Teras", 10);
            if (frm.ShowDialog() == DialogResult.OK)
            {
               
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.SetSecilenMasa(frm.SecilenMasa);
                }
                this.Close(); 
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            FormMasaSecim form = new FormMasaSecim("Kat1", 8);
            if (form.ShowDialog() == DialogResult.OK)
            {
               
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.SetSecilenMasa(form.SecilenMasa);
                }
                this.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FormMasaSecim form = new FormMasaSecim("Giriş", 10);
            if (form.ShowDialog() == DialogResult.OK)
            {
               
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.SetSecilenMasa(form.SecilenMasa);
                }
                this.Close(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FormMasaSecim form = new FormMasaSecim("Kat2", 8);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.SetSecilenMasa(form.SecilenMasa);
                }
                this.Close(); 
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        { }
            public string SecilenMasaNo { get; set; }

    }
}
