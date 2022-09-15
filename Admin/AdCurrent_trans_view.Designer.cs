namespace ADIbanking
{
    partial class AdCurrent_trans_view
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
            this.label4 = new System.Windows.Forms.Label();
            this.Hid = new System.Windows.Forms.TextBox();
            this.Deletbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(11, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Current Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(158, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Select by ID";
            // 
            // Hid
            // 
            this.Hid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Hid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hid.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Hid.ForeColor = System.Drawing.SystemColors.Window;
            this.Hid.Location = new System.Drawing.Point(242, 392);
            this.Hid.Name = "Hid";
            this.Hid.Size = new System.Drawing.Size(201, 23);
            this.Hid.TabIndex = 27;
            // 
            // Deletbtn
            // 
            this.Deletbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Deletbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Deletbtn.Location = new System.Drawing.Point(449, 389);
            this.Deletbtn.Name = "Deletbtn";
            this.Deletbtn.Size = new System.Drawing.Size(85, 26);
            this.Deletbtn.TabIndex = 25;
            this.Deletbtn.Text = "Delete";
            this.Deletbtn.UseVisualStyleBackColor = true;
            this.Deletbtn.Click += new System.EventHandler(this.Deletbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Clearbtn.Location = new System.Drawing.Point(540, 389);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(85, 26);
            this.Clearbtn.TabIndex = 26;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(15, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 343);
            this.dataGridView1.TabIndex = 24;
            // 
            // AdCurrent_trans_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hid);
            this.Controls.Add(this.Deletbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdCurrent_trans_view";
            this.Size = new System.Drawing.Size(636, 442);
            this.Load += new System.EventHandler(this.AdCurrent_trans_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Hid;
        private System.Windows.Forms.Button Deletbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
