namespace ADIbanking
{
    partial class Savings_home
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
            this.label1 = new System.Windows.Forms.Label();
            this.Actuser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.label1.Location = new System.Drawing.Point(116, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // Actuser
            // 
            this.Actuser.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.Actuser.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Actuser.Location = new System.Drawing.Point(86, 139);
            this.Actuser.Name = "Actuser";
            this.Actuser.Size = new System.Drawing.Size(301, 52);
            this.Actuser.TabIndex = 3;
            this.Actuser.Text = "ericlyndert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(99, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to the bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(92, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mwk";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.BackColor = System.Drawing.Color.Transparent;
            this.Balance.Font = new System.Drawing.Font("Arial", 25.25F);
            this.Balance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Balance.Location = new System.Drawing.Point(168, 210);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(168, 39);
            this.Balance.TabIndex = 3;
            this.Balance.Text = "00,000.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.home11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Savings_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Actuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Savings_home";
            this.Size = new System.Drawing.Size(783, 473);
            this.Load += new System.EventHandler(this.Savings_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Actuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Balance;
    }
}
