namespace ADIbanking
{
    partial class Admin_trans
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
            this.payeetab = new System.Windows.Forms.Button();
            this.Savingsbtab = new System.Windows.Forms.Button();
            this.Currenttab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransPanel = new System.Windows.Forms.Panel();
            this.adpayee_trans_view1 = new ADIbanking.Adpayee_trans_view();
            this.adCurrent_trans_view1 = new ADIbanking.AdCurrent_trans_view();
            this.adSaving_trans_view1 = new ADIbanking.AdSaving_trans_view();
            this.panel1.SuspendLayout();
            this.TransPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // payeetab
            // 
            this.payeetab.FlatAppearance.BorderSize = 0;
            this.payeetab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payeetab.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.payeetab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.payeetab.Location = new System.Drawing.Point(158, 0);
            this.payeetab.Name = "payeetab";
            this.payeetab.Size = new System.Drawing.Size(76, 28);
            this.payeetab.TabIndex = 15;
            this.payeetab.Text = "payee";
            this.payeetab.UseVisualStyleBackColor = true;
            this.payeetab.Click += new System.EventHandler(this.payeetab_Click);
            // 
            // Savingsbtab
            // 
            this.Savingsbtab.FlatAppearance.BorderSize = 0;
            this.Savingsbtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savingsbtab.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Savingsbtab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Savingsbtab.Location = new System.Drawing.Point(81, 0);
            this.Savingsbtab.Name = "Savingsbtab";
            this.Savingsbtab.Size = new System.Drawing.Size(76, 28);
            this.Savingsbtab.TabIndex = 16;
            this.Savingsbtab.Text = "Savings";
            this.Savingsbtab.UseVisualStyleBackColor = true;
            this.Savingsbtab.Click += new System.EventHandler(this.Savingsbtab_Click);
            // 
            // Currenttab
            // 
            this.Currenttab.FlatAppearance.BorderSize = 0;
            this.Currenttab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Currenttab.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Currenttab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Currenttab.Location = new System.Drawing.Point(4, 0);
            this.Currenttab.Name = "Currenttab";
            this.Currenttab.Size = new System.Drawing.Size(76, 28);
            this.Currenttab.TabIndex = 16;
            this.Currenttab.Text = "Current";
            this.Currenttab.UseVisualStyleBackColor = true;
            this.Currenttab.Click += new System.EventHandler(this.Currenttab_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Currenttab);
            this.panel1.Controls.Add(this.payeetab);
            this.panel1.Controls.Add(this.Savingsbtab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 31);
            this.panel1.TabIndex = 17;
            // 
            // TransPanel
            // 
            this.TransPanel.Controls.Add(this.adpayee_trans_view1);
            this.TransPanel.Controls.Add(this.adCurrent_trans_view1);
            this.TransPanel.Controls.Add(this.adSaving_trans_view1);
            this.TransPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.TransPanel.Location = new System.Drawing.Point(0, 31);
            this.TransPanel.Name = "TransPanel";
            this.TransPanel.Size = new System.Drawing.Size(636, 442);
            this.TransPanel.TabIndex = 18;
            // 
            // adpayee_trans_view1
            // 
            this.adpayee_trans_view1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adpayee_trans_view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adpayee_trans_view1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.adpayee_trans_view1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adpayee_trans_view1.Location = new System.Drawing.Point(0, 0);
            this.adpayee_trans_view1.Margin = new System.Windows.Forms.Padding(4);
            this.adpayee_trans_view1.Name = "adpayee_trans_view1";
            this.adpayee_trans_view1.Size = new System.Drawing.Size(636, 442);
            this.adpayee_trans_view1.TabIndex = 2;
            // 
            // adCurrent_trans_view1
            // 
            this.adCurrent_trans_view1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adCurrent_trans_view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adCurrent_trans_view1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.adCurrent_trans_view1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adCurrent_trans_view1.Location = new System.Drawing.Point(0, 0);
            this.adCurrent_trans_view1.Margin = new System.Windows.Forms.Padding(5);
            this.adCurrent_trans_view1.Name = "adCurrent_trans_view1";
            this.adCurrent_trans_view1.Size = new System.Drawing.Size(636, 442);
            this.adCurrent_trans_view1.TabIndex = 1;
            // 
            // adSaving_trans_view1
            // 
            this.adSaving_trans_view1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adSaving_trans_view1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adSaving_trans_view1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.adSaving_trans_view1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.adSaving_trans_view1.Location = new System.Drawing.Point(0, 0);
            this.adSaving_trans_view1.Margin = new System.Windows.Forms.Padding(4);
            this.adSaving_trans_view1.Name = "adSaving_trans_view1";
            this.adSaving_trans_view1.Size = new System.Drawing.Size(636, 442);
            this.adSaving_trans_view1.TabIndex = 0;
            // 
            // Admin_trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.TransPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_trans";
            this.Size = new System.Drawing.Size(636, 473);
            this.Load += new System.EventHandler(this.Admin_trans_Load);
            this.panel1.ResumeLayout(false);
            this.TransPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payeetab;
        private System.Windows.Forms.Button Savingsbtab;
        private System.Windows.Forms.Button Currenttab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TransPanel;
        private AdSaving_trans_view adSaving_trans_view1;
        private AdCurrent_trans_view adCurrent_trans_view1;
        private Adpayee_trans_view adpayee_trans_view1;
    }
}
