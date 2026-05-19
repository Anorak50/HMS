namespace HMS
{
    partial class Search_Records_Receptionist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Record_search_Name_label = new System.Windows.Forms.Label();
            this.Search_Patient_button = new System.Windows.Forms.Button();
            this.Patient_Search_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Record_search_Name_label);
            this.panel1.Controls.Add(this.Search_Patient_button);
            this.panel1.Controls.Add(this.Patient_Search_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // Record_search_Name_label
            // 
            this.Record_search_Name_label.AutoSize = true;
            this.Record_search_Name_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Record_search_Name_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record_search_Name_label.ForeColor = System.Drawing.Color.Black;
            this.Record_search_Name_label.Location = new System.Drawing.Point(0, 0);
            this.Record_search_Name_label.Name = "Record_search_Name_label";
            this.Record_search_Name_label.Size = new System.Drawing.Size(227, 30);
            this.Record_search_Name_label.TabIndex = 18;
            this.Record_search_Name_label.Text = "Search Patient Record";
            // 
            // Search_Patient_button
            // 
            this.Search_Patient_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Search_Patient_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Patient_button.FlatAppearance.BorderSize = 0;
            this.Search_Patient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Patient_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Patient_button.ForeColor = System.Drawing.Color.White;
            this.Search_Patient_button.Location = new System.Drawing.Point(580, 50);
            this.Search_Patient_button.Name = "Search_Patient_button";
            this.Search_Patient_button.Size = new System.Drawing.Size(152, 44);
            this.Search_Patient_button.TabIndex = 17;
            this.Search_Patient_button.Text = "Search";
            this.Search_Patient_button.UseVisualStyleBackColor = false;
            this.Search_Patient_button.Click += new System.EventHandler(this.Search_Patient_button_Click);
            // 
            // Patient_Search_textBox
            // 
            this.Patient_Search_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Search_textBox.Location = new System.Drawing.Point(149, 51);
            this.Patient_Search_textBox.Name = "Patient_Search_textBox";
            this.Patient_Search_textBox.Size = new System.Drawing.Size(401, 35);
            this.Patient_Search_textBox.TabIndex = 16;
            this.Patient_Search_textBox.Tag = "textSEarch";
            this.Patient_Search_textBox.TextChanged += new System.EventHandler(this.Patient_Search_textBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Search_Records_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Records_Receptionist";
            this.Text = "Search_Records_Receptionist";
            this.Load += new System.EventHandler(this.Search_Records_Receptionist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search_Patient_button;
        private System.Windows.Forms.TextBox Patient_Search_textBox;
        private System.Windows.Forms.Label Record_search_Name_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}