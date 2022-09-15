namespace ADIbanking
{
    partial class Admin_main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Log_out = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trans = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.Customerbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Actuserad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Control_panel = new System.Windows.Forms.Panel();
            this.admin_trans1 = new ADIbanking.Admin_trans();
            this.admin_register1 = new ADIbanking.Admin_register();
            this.admin_customer1 = new ADIbanking.Admin_customer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Control_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Log_out);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Trans);
            this.panel1.Controls.Add(this.Registerbtn);
            this.panel1.Controls.Add(this.Customerbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 501);
            this.panel1.TabIndex = 2;
            // 
            // Log_out
            // 
            this.Log_out.FlatAppearance.BorderSize = 0;
            this.Log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_out.Font = new System.Drawing.Font("Arial", 10F);
            this.Log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Log_out.Location = new System.Drawing.Point(0, 255);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(147, 30);
            this.Log_out.TabIndex = 3;
            this.Log_out.Text = "Log out";
            this.Log_out.UseVisualStyleBackColor = false;
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.retail_logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Trans
            // 
            this.Trans.FlatAppearance.BorderSize = 0;
            this.Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trans.Font = new System.Drawing.Font("Arial", 10F);
            this.Trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Trans.Location = new System.Drawing.Point(0, 225);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(147, 30);
            this.Trans.TabIndex = 4;
            this.Trans.Text = "Transcations";
            this.Trans.UseVisualStyleBackColor = false;
            this.Trans.Click += new System.EventHandler(this.Trans_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.FlatAppearance.BorderSize = 0;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbtn.Font = new System.Drawing.Font("Arial", 10F);
            this.Registerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Registerbtn.Location = new System.Drawing.Point(0, 165);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(147, 30);
            this.Registerbtn.TabIndex = 5;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Customerbtn
            // 
            this.Customerbtn.FlatAppearance.BorderSize = 0;
            this.Customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customerbtn.Font = new System.Drawing.Font("Arial", 10F);
            this.Customerbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Customerbtn.Location = new System.Drawing.Point(0, 195);
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.Size = new System.Drawing.Size(147, 30);
            this.Customerbtn.TabIndex = 6;
            this.Customerbtn.Text = "Customer";
            this.Customerbtn.UseVisualStyleBackColor = false;
            this.Customerbtn.Click += new System.EventHandler(this.Customerbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Actuserad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(147, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 28);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(384, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin :";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("ETH Large", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.button3.Location = new System.Drawing.Point(582, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Actuserad
            // 
            this.Actuserad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actuserad.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.Actuserad.ForeColor = System.Drawing.Color.DarkGray;
            this.Actuserad.Location = new System.Drawing.Point(447, 4);
            this.Actuserad.Name = "Actuserad";
            this.Actuserad.Size = new System.Drawing.Size(129, 23);
            this.Actuserad.TabIndex = 1;
            this.Actuserad.Text = "Username";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("ETH Large", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.button1.Location = new System.Drawing.Point(729, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.button2.Location = new System.Drawing.Point(634, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Control_panel
            // 
            this.Control_panel.Controls.Add(this.admin_trans1);
            this.Control_panel.Controls.Add(this.admin_register1);
            this.Control_panel.Controls.Add(this.admin_customer1);
            this.Control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control_panel.Location = new System.Drawing.Point(147, 28);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(636, 473);
            this.Control_panel.TabIndex = 4;
            // 
            // admin_trans1
            // 
            this.admin_trans1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.admin_trans1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_trans1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.admin_trans1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_trans1.Location = new System.Drawing.Point(0, 0);
            this.admin_trans1.Margin = new System.Windows.Forms.Padding(4);
            this.admin_trans1.Name = "admin_trans1";
            this.admin_trans1.Size = new System.Drawing.Size(636, 473);
            this.admin_trans1.TabIndex = 2;
            // 
            // admin_register1
            // 
            this.admin_register1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.admin_register1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_register1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.admin_register1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_register1.Location = new System.Drawing.Point(0, 0);
            this.admin_register1.Margin = new System.Windows.Forms.Padding(5);
            this.admin_register1.Name = "admin_register1";
            this.admin_register1.Size = new System.Drawing.Size(636, 473);
            this.admin_register1.TabIndex = 1;
            // 
            // admin_customer1
            // 
            this.admin_customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.admin_customer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_customer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_customer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_customer1.Location = new System.Drawing.Point(0, 0);
            this.admin_customer1.Margin = new System.Windows.Forms.Padding(4);
            this.admin_customer1.Name = "admin_customer1";
            this.admin_customer1.Size = new System.Drawing.Size(636, 473);
            this.admin_customer1.TabIndex = 0;
            // 
            // Admin_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(783, 501);
            this.Controls.Add(this.Control_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_main";
            this.Load += new System.EventHandler(this.Admin_main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Control_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Log_out;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Actuserad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Control_panel;
        private Admin_customer admin_customer1;
        private Admin_register admin_register1;
        private Admin_trans admin_trans1;
    }
}