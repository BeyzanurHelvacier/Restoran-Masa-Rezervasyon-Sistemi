namespace WinFormsApp1
{
    partial class FormOdeme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbOdemeYontemi = new ComboBox();
            btnOdemeYap = new Button();
            lblTutar = new Label();
            txtKartNo = new TextBox();
            txtSonKullanma = new TextBox();
            txtCVV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpKrediKarti = new GroupBox();
            grpKrediKarti.SuspendLayout();
            SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(186, 15);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(125, 29);
            cmbOdemeYontemi.TabIndex = 17;
            cmbOdemeYontemi.SelectedIndexChanged += cmbOdemeYontemi_SelectedIndexChanged;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = Color.Transparent;
            btnOdemeYap.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdemeYap.Location = new Point(138, 229);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(144, 34);
            btnOdemeYap.TabIndex = 18;
            btnOdemeYap.Text = "ÖDEMEYİ TAMAMLA";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.BackColor = Color.Transparent;
            lblTutar.Font = new Font("Segoe UI Variable Small Semibol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTutar.ForeColor = Color.Black;
            lblTutar.Location = new Point(158, 47);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(50, 20);
            lblTutar.TabIndex = 19;
            lblTutar.Text = "Tutar:";
            // 
            // txtKartNo
            // 
            txtKartNo.Location = new Point(228, 29);
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(100, 33);
            txtKartNo.TabIndex = 20;
            // 
            // txtSonKullanma
            // 
            txtSonKullanma.Location = new Point(228, 68);
            txtSonKullanma.Name = "txtSonKullanma";
            txtSonKullanma.Size = new Size(100, 33);
            txtSonKullanma.TabIndex = 21;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(228, 113);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(100, 33);
            txtCVV.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 23;
            label1.Text = "Ödeme Yöntemi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 36);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 24;
            label2.Text = "Kart Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Small Semibol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 68);
            label3.Name = "label3";
            label3.Size = new Size(215, 20);
            label3.TabIndex = 25;
            label3.Text = "Son Kullanma Tarihi (MM/YY):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Small Semibol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(7, 113);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 26;
            label4.Text = "CVV:";
            // 
            // grpKrediKarti
            // 
            grpKrediKarti.BackColor = Color.LightGray;
            grpKrediKarti.Controls.Add(label2);
            grpKrediKarti.Controls.Add(label3);
            grpKrediKarti.Controls.Add(label4);
            grpKrediKarti.Controls.Add(txtKartNo);
            grpKrediKarti.Controls.Add(txtSonKullanma);
            grpKrediKarti.Controls.Add(txtCVV);
            grpKrediKarti.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpKrediKarti.ForeColor = Color.Black;
            grpKrediKarti.Location = new Point(36, 70);
            grpKrediKarti.Name = "grpKrediKarti";
            grpKrediKarti.Size = new Size(330, 153);
            grpKrediKarti.TabIndex = 27;
            grpKrediKarti.TabStop = false;
            grpKrediKarti.Text = "Online Ödeme";
            // 
            // FormOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.duvar_resimleri_luks_restoran_desen_arka_plan_jpg;
            ClientSize = new Size(444, 284);
            Controls.Add(label1);
            Controls.Add(grpKrediKarti);
            Controls.Add(lblTutar);
            Controls.Add(cmbOdemeYontemi);
            Controls.Add(btnOdemeYap);
            Name = "FormOdeme";
            Text = "FormOdeme";
            Load += FormOdeme_Load;
            grpKrediKarti.ResumeLayout(false);
            grpKrediKarti.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbOdemeYontemi;
        private Button btnOdemeYap;
        private Label lblTutar;
        private TextBox txtKartNo;
        private TextBox txtSonKullanma;
        private TextBox txtCVV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox grpKrediKarti;
    }
}