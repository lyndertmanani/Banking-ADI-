namespace ADIbanking
{
    partial class Current
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
            this.Username = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Log_out = new System.Windows.Forms.Button();
            this.Trans = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Payee = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Controlpanel = new System.Windows.Forms.Panel();
            this.current_payee1 = new ADIbanking.Current_payee();
            this.current_Trans1 = new ADIbanking.Current_Trans();
            this.current_view1 = new ADIbanking.Current_view();
            this.current_home1 = new ADIbanking.Current_home();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Controlpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.Log_out);
            this.panel1.Controls.Add(this.Trans);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Payee);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.View);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 28);
            this.panel1.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(512, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(129, 23);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Closebtn
            // 
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("ETH Large", 15F, System.Drawing.FontStyle.Bold);
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Closebtn.Location = new System.Drawing.Point(729, 1);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(54, 27);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // Log_out
            // 
            this.Log_out.FlatAppearance.BorderSize = 0;
            this.Log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_out.Font = new System.Drawing.Font("Arial", 10F);
            this.Log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Log_out.Location = new System.Drawing.Point(634, 1);
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(97, 28);
            this.Log_out.TabIndex = 1;
            this.Log_out.Text = "Log out";
            this.Log_out.UseVisualStyleBackColor = false;
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // Trans
            // 
            this.Trans.FlatAppearance.BorderSize = 0;
            this.Trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trans.Font = new System.Drawing.Font("Arial", 10F);
            this.Trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Trans.Location = new System.Drawing.Point(409, -1);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(97, 30);
            this.Trans.TabIndex = 1;
            this.Trans.Text = "Transcations";
            this.Trans.UseVisualStyleBackColor = false;
            this.Trans.Click += new System.EventHandler(this.Trans_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.retail_logow;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Payee
            // 
            this.Payee.FlatAppearance.BorderSize = 0;
            this.Payee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payee.Font = new System.Drawing.Font("Arial", 10F);
            this.Payee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Payee.Location = new System.Drawing.Point(318, -1);
            this.Payee.Name = "Payee";
            this.Payee.Size = new System.Drawing.Size(89, 30);
            this.Payee.TabIndex = 1;
            this.Payee.Text = "Payee";
            this.Payee.UseVisualStyleBackColor = false;
            this.Payee.Click += new System.EventHandler(this.Payee_Click);
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Arial", 10F);
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Home.Location = new System.Drawing.Point(138, -1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(89, 30);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // View
            // 
            this.View.FlatAppearance.BorderSize = 0;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View.Font = new System.Drawing.Font("Arial", 10F);
            this.View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.View.Location = new System.Drawing.Point(229, -1);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(89, 30);
            this.View.TabIndex = 1;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Controlpanel
            // 
            this.Controlpanel.Controls.Add(this.current_payee1);
            this.Controlpanel.Controls.Add(this.current_Trans1);
            this.Controlpanel.Controls.Add(this.current_view1);
            this.Controlpanel.Controls.Add(this.current_home1);
            this.Controlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controlpanel.Location = new System.Drawing.Point(0, 28);
            this.Controlpanel.Name = "Controlpanel";
            this.Controlpanel.Size = new System.Drawing.Size(783, 473);
            this.Controlpanel.TabIndex = 2;
            // 
            // current_payee1
            // 
            this.current_payee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.current_payee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current_payee1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_payee1.ForeColor = System.Drawing.Color.Snow;
            this.current_payee1.Location = new System.Drawing.Point(0, 0);
            this.current_payee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.current_payee1.Name = "current_payee1";
            this.current_payee1.Size = new System.Drawing.Size(783, 473);
            this.current_payee1.TabIndex = 3;
            // 
            // current_Trans1
            // 
            this.current_Trans1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.current_Trans1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current_Trans1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Trans1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_Trans1.Location = new System.Drawing.Point(0, 0);
            this.current_Trans1.Margin = new System.Windows.Forms.Padding(4);
            this.current_Trans1.Name = "current_Trans1";
            this.current_Trans1.Size = new System.Drawing.Size(783, 473);
            this.current_Trans1.TabIndex = 2;
            // 
            // current_view1
            // 
            this.current_view1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.current_view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current_view1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_view1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_view1.Location = new System.Drawing.Point(0, 0);
            this.current_view1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.current_view1.Name = "current_view1";
            this.current_view1.Size = new System.Drawing.Size(783, 473);
            this.current_view1.TabIndex = 1;
            // 
            // current_home1
            // 
            this.current_home1.BackColor = System.Drawing.SystemColors.Window;
            this.current_home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current_home1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_home1.Location = new System.Drawing.Point(0, 0);
            this.current_home1.Margin = new System.Windows.Forms.Padding(4);
            this.current_home1.Name = "current_home1";
            this.current_home1.Size = new System.Drawing.Size(783, 473);
            this.current_home1.TabIndex = 0;
            // 
            // Current
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(783, 501);
            this.Controls.Add(this.Controlpanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Current";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current";
            this.Load += new System.EventHandler(this.Current_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Controlpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Log_out;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Payee;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Panel Controlpanel;
        private Current_home current_home1;
        private Current_view current_view1;
        private Current_payee current_payee1;
        private Current_Trans current_Trans1;
    }
}