namespace ADIbanking
{
    partial class Current_view
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
            this.label4 = new System.Windows.Forms.Label();
            this.Idboxhis = new System.Windows.Forms.TextBox();
            this.Deletbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ADIbanking.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(232, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select by ID";
            // 
            // Idboxhis
            // 
            this.Idboxhis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Idboxhis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Idboxhis.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Idboxhis.ForeColor = System.Drawing.SystemColors.Window;
            this.Idboxhis.Location = new System.Drawing.Point(316, 368);
            this.Idboxhis.Name = "Idboxhis";
            this.Idboxhis.Size = new System.Drawing.Size(201, 23);
            this.Idboxhis.TabIndex = 8;
            // 
            // Deletbtn
            // 
            this.Deletbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Deletbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Deletbtn.Location = new System.Drawing.Point(523, 365);
            this.Deletbtn.Name = "Deletbtn";
            this.Deletbtn.Size = new System.Drawing.Size(85, 26);
            this.Deletbtn.TabIndex = 6;
            this.Deletbtn.Text = "Delete";
            this.Deletbtn.UseVisualStyleBackColor = true;
            this.Deletbtn.Click += new System.EventHandler(this.Deletbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Clearbtn.Location = new System.Drawing.Point(614, 365);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(85, 26);
            this.Clearbtn.TabIndex = 7;
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
            this.dataGridView1.Location = new System.Drawing.Point(89, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 315);
            this.dataGridView1.TabIndex = 5;
            // 
            // Current_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Idboxhis);
            this.Controls.Add(this.Deletbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Current_view";
            this.Size = new System.Drawing.Size(783, 473);
            this.Load += new System.EventHandler(this.Current_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Idboxhis;
        private System.Windows.Forms.Button Deletbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
