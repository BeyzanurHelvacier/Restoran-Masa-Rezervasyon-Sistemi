namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            rezervasyonTarihi = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMusteriAdi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnRezervasyonuTamamla = new Button();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            button2 = new Button();
            label2 = new Label();
            lblSecilenMasa = new Label();
            clbBaslangicYemegi = new CheckedListBox();
            clbAnaYemek = new CheckedListBox();
            clbTatli = new CheckedListBox();
            clbIcecek = new CheckedListBox();
            label8 = new Label();
            clbMeze = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 4;
            label1.Text = "Müşteri Ad Soyad:";
            // 
            // rezervasyonTarihi
            // 
            rezervasyonTarihi.AutoSize = true;
            rezervasyonTarihi.BackColor = Color.Transparent;
            rezervasyonTarihi.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rezervasyonTarihi.ForeColor = SystemColors.ControlLightLight;
            rezervasyonTarihi.Location = new Point(26, 83);
            rezervasyonTarihi.Name = "rezervasyonTarihi";
            rezervasyonTarihi.Size = new Size(124, 17);
            rezervasyonTarihi.TabIndex = 5;
            rezervasyonTarihi.Text = "Rezervasyon Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(26, 126);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 6;
            label3.Text = "Başlangıç Yemeği:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(26, 225);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 7;
            label4.Text = "Ana Yemek:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(26, 268);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 8;
            label5.Text = "Tatlı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(272, 9);
            label6.Name = "label6";
            label6.Size = new Size(178, 17);
            label6.TabIndex = 9;
            label6.Text = "REZERVASYON OLUŞTURUN";
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(155, 42);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(167, 23);
            txtMusteriAdi.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(156, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // btnRezervasyonuTamamla
            // 
            btnRezervasyonuTamamla.BackColor = Color.Transparent;
            btnRezervasyonuTamamla.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRezervasyonuTamamla.Location = new Point(87, 438);
            btnRezervasyonuTamamla.Name = "btnRezervasyonuTamamla";
            btnRezervasyonuTamamla.Size = new Size(218, 31);
            btnRezervasyonuTamamla.TabIndex = 17;
            btnRezervasyonuTamamla.Text = "Rezervasyonu Tamamla";
            btnRezervasyonuTamamla.UseVisualStyleBackColor = false;
            btnRezervasyonuTamamla.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(525, 356);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(260, 153);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(525, 337);
            label7.Name = "label7";
            label7.Size = new Size(73, 16);
            label7.TabIndex = 19;
            label7.Text = "Bilgi Mesajı:";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(155, 366);
            button2.Name = "button2";
            button2.Size = new Size(135, 38);
            button2.TabIndex = 20;
            button2.Text = "Masa No Seçiniz";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(26, 308);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 21;
            label2.Text = "İçecekler:";
            // 
            // lblSecilenMasa
            // 
            lblSecilenMasa.AutoSize = true;
            lblSecilenMasa.BackColor = Color.Transparent;
            lblSecilenMasa.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecilenMasa.ForeColor = SystemColors.ControlLight;
            lblSecilenMasa.Location = new Point(26, 377);
            lblSecilenMasa.Name = "lblSecilenMasa";
            lblSecilenMasa.Size = new Size(91, 17);
            lblSecilenMasa.TabIndex = 23;
            lblSecilenMasa.Text = "Seçilen Masa:";
            lblSecilenMasa.Click += lblSecilenMasa_Click;
            // 
            // clbBaslangicYemegi
            // 
            clbBaslangicYemegi.FormattingEnabled = true;
            clbBaslangicYemegi.Location = new Point(170, 126);
            clbBaslangicYemegi.Name = "clbBaslangicYemegi";
            clbBaslangicYemegi.Size = new Size(135, 22);
            clbBaslangicYemegi.TabIndex = 24;
            clbBaslangicYemegi.SelectedIndexChanged += clbBaslangicYemegi_SelectedIndexChanged;
            // 
            // clbAnaYemek
            // 
            clbAnaYemek.FormattingEnabled = true;
            clbAnaYemek.Location = new Point(170, 225);
            clbAnaYemek.Name = "clbAnaYemek";
            clbAnaYemek.Size = new Size(120, 22);
            clbAnaYemek.TabIndex = 25;
            // 
            // clbTatli
            // 
            clbTatli.FormattingEnabled = true;
            clbTatli.Location = new Point(170, 268);
            clbTatli.Name = "clbTatli";
            clbTatli.Size = new Size(120, 22);
            clbTatli.TabIndex = 26;
            // 
            // clbIcecek
            // 
            clbIcecek.FormattingEnabled = true;
            clbIcecek.Location = new Point(170, 308);
            clbIcecek.Name = "clbIcecek";
            clbIcecek.Size = new Size(120, 22);
            clbIcecek.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(26, 173);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 28;
            label8.Text = "Mezeler:";
            // 
            // clbMeze
            // 
            clbMeze.FormattingEnabled = true;
            clbMeze.Location = new Point(170, 173);
            clbMeze.Name = "clbMeze";
            clbMeze.Size = new Size(120, 22);
            clbMeze.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 506);
            Controls.Add(clbMeze);
            Controls.Add(label8);
            Controls.Add(clbIcecek);
            Controls.Add(clbTatli);
            Controls.Add(clbAnaYemek);
            Controls.Add(clbBaslangicYemegi);
            Controls.Add(lblSecilenMasa);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(btnRezervasyonuTamamla);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtMusteriAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rezervasyonTarihi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label rezervasyonTarihi;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMusteriAdi;
        private DateTimePicker dateTimePicker1;
        private Button btnRezervasyonuTamamla;
        private RichTextBox richTextBox1;
        private Label label7;
        private Button button2;
        private Label label2;
        private Label lblSecilenMasa;
        private CheckedListBox clbBaslangicYemegi;
        private CheckedListBox clbAnaYemek;
        private CheckedListBox clbTatli;
        private CheckedListBox clbIcecek;
        private Label label8;
        private CheckedListBox clbMeze;
    }
}
