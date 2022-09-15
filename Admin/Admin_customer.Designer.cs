namespace ADIbanking
{
    partial class Admin_customer
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
            this.Currentbtn = new System.Windows.Forms.Button();
            this.Savingsbtn = new System.Windows.Forms.Button();
            this.AdCus = new System.Windows.Forms.Panel();
            this.ad_Customer_current1 = new ADIbanking.Ad_Customer_current();
            this.ad_Customer_Savings1 = new ADIbanking.Ad_Customer_Savings();
            this.AdCus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currentbtn
            // 
            this.Currentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Currentbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Currentbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Currentbtn.Location = new System.Drawing.Point(502, 421);
            this.Currentbtn.Name = "Currentbtn";
            this.Currentbtn.Size = new System.Drawing.Size(77, 28);
            this.Currentbtn.TabIndex = 13;
            this.Currentbtn.Text = "Current";
            this.Currentbtn.UseVisualStyleBackColor = true;
            this.Currentbtn.Click += new System.EventHandler(this.Currentbtn_Click);
            // 
            // Savingsbtn
            // 
            this.Savingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savingsbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Savingsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Savingsbtn.Location = new System.Drawing.Point(419, 421);
            this.Savingsbtn.Name = "Savingsbtn";
            this.Savingsbtn.Size = new System.Drawing.Size(77, 28);
            this.Savingsbtn.TabIndex = 14;
            this.Savingsbtn.Text = "Savings";
            this.Savingsbtn.UseVisualStyleBackColor = true;
            this.Savingsbtn.Click += new System.EventHandler(this.Savingsbtn_Click);
            // 
            // AdCus
            // 
            this.AdCus.Controls.Add(this.ad_Customer_current1);
            this.AdCus.Controls.Add(this.ad_Customer_Savings1);
            this.AdCus.Location = new System.Drawing.Point(17, 15);
            this.AdCus.Name = "AdCus";
            this.AdCus.Size = new System.Drawing.Size(603, 396);
            this.AdCus.TabIndex = 15;
            // 
            // ad_Customer_current1
            // 
            this.ad_Customer_current1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ad_Customer_current1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ad_Customer_current1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ad_Customer_current1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ad_Customer_current1.Location = new System.Drawing.Point(0, 0);
            this.ad_Customer_current1.Margin = new System.Windows.Forms.Padding(5);
            this.ad_Customer_current1.Name = "ad_Customer_current1";
            this.ad_Customer_current1.Size = new System.Drawing.Size(603, 396);
            this.ad_Customer_current1.TabIndex = 1;
            // 
            // ad_Customer_Savings1
            // 
            this.ad_Customer_Savings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.ad_Customer_Savings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ad_Customer_Savings1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_Customer_Savings1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ad_Customer_Savings1.Location = new System.Drawing.Point(0, 0);
            this.ad_Customer_Savings1.Margin = new System.Windows.Forms.Padding(4);
            this.ad_Customer_Savings1.Name = "ad_Customer_Savings1";
            this.ad_Customer_Savings1.Size = new System.Drawing.Size(603, 396);
            this.ad_Customer_Savings1.TabIndex = 0;
            // 
            // Admin_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.AdCus);
            this.Controls.Add(this.Currentbtn);
            this.Controls.Add(this.Savingsbtn);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_customer";
            this.Size = new System.Drawing.Size(636, 473);
            this.Load += new System.EventHandler(this.Admin_customer_Load);
            this.AdCus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Currentbtn;
        private System.Windows.Forms.Button Savingsbtn;
        private System.Windows.Forms.Panel AdCus;
        private Ad_Customer_Savings ad_Customer_Savings1;
        private Ad_Customer_current ad_Customer_current1;
    }
}
