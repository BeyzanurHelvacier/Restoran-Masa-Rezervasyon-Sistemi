namespace WinFormsApp1
{
    partial class FormSifre
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
            btnGiris = new Button();
            label1 = new Label();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_04_17_at_17_57_01;
            btnGiris.Font = new Font("Segoe UI Variable Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(179, 173);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(99, 42);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(129, 37);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 1;
            label1.Text = "Yönetici şifresini girin";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(167, 100);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(122, 23);
            txtSifre.TabIndex = 2;
            // 
            // FormSifre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(469, 298);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Name = "FormSifre";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label label1;
        private TextBox txtSifre;
    }
}