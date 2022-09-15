namespace ADIbanking.Savings
{
    partial class Savings_Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Log_out = new System.Windows.Forms.Button();
            this.Trans = new System.Windows.Forms.Button();
            this.Payee = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.ControlsSpanel = new System.Windows.Forms.Panel();
            this.savings_home1 = new ADIbanking.Savings_home();
            this.savings_payee1 = new ADIbanking.Savings_payee();
            this.savings_trans1 = new ADIbanking.Savings_trans();
            this.savings_view1 = new ADIbanking.Savings_view();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ControlsSpanel.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.Log_out);
            this.panel1.Controls.Add(this.Trans);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Payee);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Controls.Add(this.Viewbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 28);
            this.panel1.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
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
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
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
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Font = new System.Drawing.Font("Arial", 10F);
            this.Homebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Homebtn.Location = new System.Drawing.Point(138, -1);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(89, 30);
            this.Homebtn.TabIndex = 1;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Viewbtn
            // 
            this.Viewbtn.FlatAppearance.BorderSize = 0;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Font = new System.Drawing.Font("Arial", 10F);
            this.Viewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Viewbtn.Location = new System.Drawing.Point(229, -1);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(89, 30);
            this.Viewbtn.TabIndex = 1;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // ControlsSpanel
            // 
            this.ControlsSpanel.Controls.Add(this.savings_view1);
            this.ControlsSpanel.Controls.Add(this.savings_trans1);
            this.ControlsSpanel.Controls.Add(this.savings_payee1);
            this.ControlsSpanel.Controls.Add(this.savings_home1);
            this.ControlsSpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsSpanel.Location = new System.Drawing.Point(0, 28);
            this.ControlsSpanel.Name = "ControlsSpanel";
            this.ControlsSpanel.Size = new System.Drawing.Size(783, 473);
            this.ControlsSpanel.TabIndex = 3;
            // 
            // savings_home1
            // 
            this.savings_home1.BackColor = System.Drawing.Color.White;
            this.savings_home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savings_home1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings_home1.ForeColor = System.Drawing.SystemColors.Window;
            this.savings_home1.Location = new System.Drawing.Point(0, 0);
            this.savings_home1.Margin = new System.Windows.Forms.Padding(5);
            this.savings_home1.Name = "savings_home1";
            this.savings_home1.Size = new System.Drawing.Size(783, 473);
            this.savings_home1.TabIndex = 0;
            // 
            // savings_payee1
            // 
            this.savings_payee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.savings_payee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savings_payee1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings_payee1.Location = new System.Drawing.Point(0, 0);
            this.savings_payee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savings_payee1.Name = "savings_payee1";
            this.savings_payee1.Size = new System.Drawing.Size(783, 473);
            this.savings_payee1.TabIndex = 1;
            // 
            // savings_trans1
            // 
            this.savings_trans1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.savings_trans1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savings_trans1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings_trans1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savings_trans1.Location = new System.Drawing.Point(0, 0);
            this.savings_trans1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savings_trans1.Name = "savings_trans1";
            this.savings_trans1.Size = new System.Drawing.Size(783, 473);
            this.savings_trans1.TabIndex = 2;
            // 
            // savings_view1
            // 
            this.savings_view1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.savings_view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savings_view1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savings_view1.Location = new System.Drawing.Point(0, 0);
            this.savings_view1.Margin = new System.Windows.Forms.Padding(5);
            this.savings_view1.Name = "savings_view1";
            this.savings_view1.Size = new System.Drawing.Size(783, 473);
            this.savings_view1.TabIndex = 3;
            // 
            // SavingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(783, 501);
            this.Controls.Add(this.ControlsSpanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SavingsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavingsMain";
            this.Load += new System.EventHandler(this.SavingsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ControlsSpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Log_out;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.Button Payee;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Panel ControlsSpanel;
        private Savings_view savings_view1;
        private Savings_trans savings_trans1;
        private Savings_payee savings_payee1;
        private Savings_home savings_home1;
    }
}