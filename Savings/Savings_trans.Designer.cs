namespace ADIbanking
{
    partial class Savings_trans
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Deposittxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Withdrawtxt = new System.Windows.Forms.TextBox();
            this.Depositbtn = new System.Windows.Forms.Button();
            this.Withdrawbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Arial", 15.25F);
            this.Balance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Balance.Location = new System.Drawing.Point(213, 229);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(106, 24);
            this.Balance.TabIndex = 16;
            this.Balance.Text = "00,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(154, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "MWK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(153, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(455, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter amount";
            // 
            // Deposittxt
            // 
            this.Deposittxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Deposittxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Deposittxt.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Deposittxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Deposittxt.Location = new System.Drawing.Point(458, 253);
            this.Deposittxt.Name = "Deposittxt";
            this.Deposittxt.Size = new System.Drawing.Size(226, 23);
            this.Deposittxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(455, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter amount";
            // 
            // Withdrawtxt
            // 
            this.Withdrawtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Withdrawtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Withdrawtxt.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Withdrawtxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Withdrawtxt.Location = new System.Drawing.Point(458, 185);
            this.Withdrawtxt.Name = "Withdrawtxt";
            this.Withdrawtxt.Size = new System.Drawing.Size(227, 23);
            this.Withdrawtxt.TabIndex = 12;
            // 
            // Depositbtn
            // 
            this.Depositbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Depositbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Depositbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Depositbtn.Location = new System.Drawing.Point(606, 285);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.Size = new System.Drawing.Size(78, 26);
            this.Depositbtn.TabIndex = 10;
            this.Depositbtn.Text = "Deposit";
            this.Depositbtn.UseVisualStyleBackColor = true;
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            this.Depositbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Depositbtn_MouseClick);
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdrawbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Withdrawbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Withdrawbtn.Location = new System.Drawing.Point(607, 214);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.Size = new System.Drawing.Size(78, 26);
            this.Withdrawbtn.TabIndex = 10;
            this.Withdrawbtn.Text = "Withdraw";
            this.Withdrawbtn.UseVisualStyleBackColor = true;
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            this.Withdrawbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Withdrawbtn_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(455, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "The only trusted bank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(453, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Transcation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.retail_logow;
            this.pictureBox1.Location = new System.Drawing.Point(85, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Savings_trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deposittxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Withdrawtxt);
            this.Controls.Add(this.Withdrawbtn);
            this.Controls.Add(this.Depositbtn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Savings_trans";
            this.Size = new System.Drawing.Size(783, 473);
            this.Load += new System.EventHandler(this.Savings_trans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Deposittxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Withdrawtxt;
        private System.Windows.Forms.Button Depositbtn;
        private System.Windows.Forms.Button Withdrawbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
