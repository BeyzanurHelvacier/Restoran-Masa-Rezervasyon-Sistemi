namespace WinFormsApp1
{
    partial class Form2
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(104, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 154);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(121, 95);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 3;
            button4.Text = "Kat 2";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(15, 95);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 2;
            button3.Text = "Kat 1";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(121, 21);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 1;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(15, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 0;
            button1.Text = "Teras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.duvar_resimleri_luks_restoran_desen_arka_plan_jpg;
            ClientSize = new Size(425, 310);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}