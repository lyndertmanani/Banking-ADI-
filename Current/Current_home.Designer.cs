namespace ADIbanking
{
    partial class Current_home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Balancec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Actuserc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.home_current;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Balancec
            // 
            this.Balancec.AutoSize = true;
            this.Balancec.BackColor = System.Drawing.Color.Transparent;
            this.Balancec.Font = new System.Drawing.Font("Arial", 25.25F);
            this.Balancec.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Balancec.Location = new System.Drawing.Point(173, 193);
            this.Balancec.Name = "Balancec";
            this.Balancec.Size = new System.Drawing.Size(168, 39);
            this.Balancec.TabIndex = 5;
            this.Balancec.Text = "00,000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(97, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mwk";
            // 
            // Actuserc
            // 
            this.Actuserc.AutoSize = true;
            this.Actuserc.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.Actuserc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Actuserc.Location = new System.Drawing.Point(82, 123);
            this.Actuserc.Name = "Actuserc";
            this.Actuserc.Size = new System.Drawing.Size(242, 52);
            this.Actuserc.TabIndex = 7;
            this.Actuserc.Text = "ericlyndert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(104, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome to the bank";
            // 
            // Current_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.Balancec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Actuserc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Current_home";
            this.Size = new System.Drawing.Size(783, 473);
            this.Load += new System.EventHandler(this.Current_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Balancec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Actuserc;
        private System.Windows.Forms.Label label3;
    }
}
