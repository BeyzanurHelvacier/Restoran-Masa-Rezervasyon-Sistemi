namespace WinFormsApp1
{
    partial class FormGiris
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
            btnRezervasyon = new Button();
            SuspendLayout();
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackColor = Color.WhiteSmoke;
            btnRezervasyon.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_04_17_at_17_57_01;
            btnRezervasyon.Font = new Font("Ink Free", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnRezervasyon.Location = new Point(121, 15);
            btnRezervasyon.Margin = new Padding(3, 6, 3, 6);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(230, 69);
            btnRezervasyon.TabIndex = 0;
            btnRezervasyon.Text = "Rezervasyon Oluşturun";
            btnRezervasyon.UseVisualStyleBackColor = false;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_04_17_at_17_571;
            ClientSize = new Size(466, 448);
            Controls.Add(btnRezervasyon);
            Font = new Font("Gabriola", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(64, 0, 0);
            Margin = new Padding(3, 6, 3, 6);
            Name = "FormGiris";
            Text = "FormGiriş";
            Load += FormGiris_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRezervasyon;
    }
}