namespace WinFormsApp1
{
    partial class FormMasaSecim
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
            flowLayoutPanelMasalar = new FlowLayoutPanel();
            btnTamam = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelMasalar
            // 
            flowLayoutPanelMasalar.BackColor = Color.Transparent;
            flowLayoutPanelMasalar.Location = new Point(77, 54);
            flowLayoutPanelMasalar.Name = "flowLayoutPanelMasalar";
            flowLayoutPanelMasalar.Size = new Size(200, 100);
            flowLayoutPanelMasalar.TabIndex = 0;
            // 
            // btnTamam
            // 
            btnTamam.BackColor = Color.DarkGray;
            btnTamam.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTamam.Location = new Point(127, 189);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(75, 28);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "Tamamla";
            btnTamam.UseVisualStyleBackColor = false;
            btnTamam.Click += btnTamam_Click;
            // 
            // FormMasaSecim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources.duvar_resimleri_luks_restoran_desen_arka_plan_jpg;
            ClientSize = new Size(555, 286);
            Controls.Add(btnTamam);
            Controls.Add(flowLayoutPanelMasalar);
            Name = "FormMasaSecim";
            Text = "Masa Seçimi";
            Load += FormMasaSecim_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMasalar;
        private Button btnTamam;
    }
}