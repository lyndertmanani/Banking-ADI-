namespace ADIbanking
{
    partial class Ad_Customer_Savings
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
            this.SavingsGridad = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.TextBox();
            this.Removebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsGridad)).BeginInit();
            this.SuspendLayout();
            // 
            // SavingsGridad
            // 
            this.SavingsGridad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.SavingsGridad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavingsGridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavingsGridad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.SavingsGridad.Location = new System.Drawing.Point(39, 26);
            this.SavingsGridad.Name = "SavingsGridad";
            this.SavingsGridad.Size = new System.Drawing.Size(519, 296);
            this.SavingsGridad.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(39, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select by ID";
            // 
            // Sid
            // 
            this.Sid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Sid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sid.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Sid.ForeColor = System.Drawing.SystemColors.Window;
            this.Sid.Location = new System.Drawing.Point(41, 340);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(149, 23);
            this.Sid.TabIndex = 19;
            // 
            // Removebtn
            // 
            this.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Removebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Removebtn.Location = new System.Drawing.Point(206, 337);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(78, 26);
            this.Removebtn.TabIndex = 18;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(381, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Retail bank savings members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(440, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Saving Account";
            // 
            // Ad_Customer_Savings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.SavingsGridad);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ad_Customer_Savings";
            this.Size = new System.Drawing.Size(603, 396);
            this.Load += new System.EventHandler(this.Ad_Customer_Savings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SavingsGridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SavingsGridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
