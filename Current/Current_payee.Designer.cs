namespace ADIbanking
{
    partial class Current_payee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Idbox = new System.Windows.Forms.TextBox();
            this.Addpayee = new System.Windows.Forms.Button();
            this.paypayee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Refresher = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Arial", 15.25F);
            this.Balance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Balance.Location = new System.Drawing.Point(83, 416);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(106, 24);
            this.Balance.TabIndex = 19;
            this.Balance.Text = "00,000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "MWK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(26, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 304);
            this.dataGridView1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(23, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(192, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter amount";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Amount.ForeColor = System.Drawing.SystemColors.Window;
            this.Amount.Location = new System.Drawing.Point(195, 359);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(148, 23);
            this.Amount.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(25, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select by ID";
            // 
            // Idbox
            // 
            this.Idbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Idbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Idbox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Idbox.ForeColor = System.Drawing.SystemColors.Window;
            this.Idbox.Location = new System.Drawing.Point(28, 358);
            this.Idbox.Name = "Idbox";
            this.Idbox.Size = new System.Drawing.Size(149, 23);
            this.Idbox.TabIndex = 14;
            // 
            // Addpayee
            // 
            this.Addpayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addpayee.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Addpayee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Addpayee.Location = new System.Drawing.Point(446, 356);
            this.Addpayee.Name = "Addpayee";
            this.Addpayee.Size = new System.Drawing.Size(78, 26);
            this.Addpayee.TabIndex = 11;
            this.Addpayee.Text = "Add";
            this.Addpayee.UseVisualStyleBackColor = true;
            this.Addpayee.Click += new System.EventHandler(this.Addpayee_Click);
            // 
            // paypayee
            // 
            this.paypayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paypayee.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.paypayee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.paypayee.Location = new System.Drawing.Point(357, 356);
            this.paypayee.Name = "paypayee";
            this.paypayee.Size = new System.Drawing.Size(78, 26);
            this.paypayee.TabIndex = 12;
            this.paypayee.Text = "pay";
            this.paypayee.UseVisualStyleBackColor = true;
            this.paypayee.Click += new System.EventHandler(this.paypayee_Click);
            this.paypayee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paypayee_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.payee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 473);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Refresher
            // 
            this.Refresher.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Refresher.AutoSize = true;
            this.Refresher.Font = new System.Drawing.Font("Arial", 9.25F);
            this.Refresher.ForeColor = System.Drawing.SystemColors.Window;
            this.Refresher.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Refresher.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Refresher.Location = new System.Drawing.Point(461, 385);
            this.Refresher.Name = "Refresher";
            this.Refresher.Size = new System.Drawing.Size(51, 16);
            this.Refresher.TabIndex = 21;
            this.Refresher.TabStop = true;
            this.Refresher.Text = "Refresh";
            this.Refresher.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.Refresher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Refresher_LinkClicked);
            // 
            // Current_payee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.Refresher);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Idbox);
            this.Controls.Add(this.Addpayee);
            this.Controls.Add(this.paypayee);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Current_payee";
            this.Size = new System.Drawing.Size(783, 473);
            this.Load += new System.EventHandler(this.Current_payee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Idbox;
        private System.Windows.Forms.Button Addpayee;
        private System.Windows.Forms.Button paypayee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Refresher;
    }
}
