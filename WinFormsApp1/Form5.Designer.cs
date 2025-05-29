namespace WinFormsApp1
{
    partial class FormKayitlar
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
            dgvKayitlar = new DataGridView();
            btnSil = new Button();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).BeginInit();
            SuspendLayout();
            // 
            // dgvKayitlar
            // 
            dgvKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKayitlar.Location = new Point(64, 33);
            dgvKayitlar.Name = "dgvKayitlar";
            dgvKayitlar.Size = new Size(714, 306);
            dgvKayitlar.TabIndex = 0;
            dgvKayitlar.CellContentClick += dgvKayitlar_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(282, 345);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 35);
            btnSil.TabIndex = 1;
            btnSil.Text = "Veri Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnYenile_Click;
            // 
            // btnKapat
            // 
            btnKapat.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(432, 345);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(104, 35);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // FormKayitlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.duvar_resimleri_luks_restoran_desen_arka_plan_jpg;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKapat);
            Controls.Add(btnSil);
            Controls.Add(dgvKayitlar);
            Name = "FormKayitlar";
            Text = "FormKayitlar";
            Load += FormKayitlar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKayitlar;
        private Button btnSil;
        private Button btnKapat;
    }
}