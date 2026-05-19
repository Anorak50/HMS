namespace HMS
{
    partial class Patient_History_Receptionist
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
            this.Top_Search_panel = new System.Windows.Forms.Panel();
            this.Search_Patient_button = new System.Windows.Forms.Button();
            this.Patient_Search_textBox = new System.Windows.Forms.TextBox();
            this.Patient_search_Name_label = new System.Windows.Forms.Label();
            this.To_fill_dgvpanel1 = new System.Windows.Forms.Panel();
            this.Selected_Pat_dataGridView = new System.Windows.Forms.DataGridView();
            this.Selected_Patient_label = new System.Windows.Forms.Label();
            this.Select_Patient_dataGridView = new System.Windows.Forms.DataGridView();
            this.Click_TO_LOAD_HISTORYlabel = new System.Windows.Forms.Label();
            this.Top_Search_panel.SuspendLayout();
            this.To_fill_dgvpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_Pat_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Patient_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Search_panel
            // 
            this.Top_Search_panel.Controls.Add(this.Search_Patient_button);
            this.Top_Search_panel.Controls.Add(this.Patient_Search_textBox);
            this.Top_Search_panel.Controls.Add(this.Patient_search_Name_label);
            this.Top_Search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Search_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Search_panel.Name = "Top_Search_panel";
            this.Top_Search_panel.Size = new System.Drawing.Size(800, 100);
            this.Top_Search_panel.TabIndex = 1;
            // 
            // Search_Patient_button
            // 
            this.Search_Patient_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Search_Patient_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Patient_button.FlatAppearance.BorderSize = 0;
            this.Search_Patient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Patient_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Patient_button.ForeColor = System.Drawing.Color.White;
            this.Search_Patient_button.Location = new System.Drawing.Point(483, 46);
            this.Search_Patient_button.Name = "Search_Patient_button";
            this.Search_Patient_button.Size = new System.Drawing.Size(152, 44);
            this.Search_Patient_button.TabIndex = 15;
            this.Search_Patient_button.Text = "Search";
            this.Search_Patient_button.UseVisualStyleBackColor = false;
            this.Search_Patient_button.Click += new System.EventHandler(this.Search_Patient_button_Click);
            // 
            // Patient_Search_textBox
            // 
            this.Patient_Search_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Search_textBox.Location = new System.Drawing.Point(46, 47);
            this.Patient_Search_textBox.Name = "Patient_Search_textBox";
            this.Patient_Search_textBox.Size = new System.Drawing.Size(401, 35);
            this.Patient_Search_textBox.TabIndex = 8;
            this.Patient_Search_textBox.Tag = "textSEarch";
            this.Patient_Search_textBox.TextChanged += new System.EventHandler(this.Patient_Search_textBox_TextChanged);
            // 
            // Patient_search_Name_label
            // 
            this.Patient_search_Name_label.AutoSize = true;
            this.Patient_search_Name_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Patient_search_Name_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_search_Name_label.ForeColor = System.Drawing.Color.Black;
            this.Patient_search_Name_label.Location = new System.Drawing.Point(0, 0);
            this.Patient_search_Name_label.Name = "Patient_search_Name_label";
            this.Patient_search_Name_label.Size = new System.Drawing.Size(153, 30);
            this.Patient_search_Name_label.TabIndex = 7;
            this.Patient_search_Name_label.Text = "Patient Search";
            // 
            // To_fill_dgvpanel1
            // 
            this.To_fill_dgvpanel1.Controls.Add(this.Selected_Pat_dataGridView);
            this.To_fill_dgvpanel1.Controls.Add(this.Selected_Patient_label);
            this.To_fill_dgvpanel1.Controls.Add(this.Select_Patient_dataGridView);
            this.To_fill_dgvpanel1.Controls.Add(this.Click_TO_LOAD_HISTORYlabel);
            this.To_fill_dgvpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.To_fill_dgvpanel1.Location = new System.Drawing.Point(0, 100);
            this.To_fill_dgvpanel1.Name = "To_fill_dgvpanel1";
            this.To_fill_dgvpanel1.Size = new System.Drawing.Size(800, 350);
            this.To_fill_dgvpanel1.TabIndex = 2;
            // 
            // Selected_Pat_dataGridView
            // 
            this.Selected_Pat_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Selected_Pat_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Selected_Pat_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Selected_Pat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Selected_Pat_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selected_Pat_dataGridView.Location = new System.Drawing.Point(0, 173);
            this.Selected_Pat_dataGridView.Name = "Selected_Pat_dataGridView";
            this.Selected_Pat_dataGridView.Size = new System.Drawing.Size(800, 177);
            this.Selected_Pat_dataGridView.TabIndex = 3;
            // 
            // Selected_Patient_label
            // 
            this.Selected_Patient_label.AutoSize = true;
            this.Selected_Patient_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Selected_Patient_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Patient_label.Location = new System.Drawing.Point(0, 156);
            this.Selected_Patient_label.Name = "Selected_Patient_label";
            this.Selected_Patient_label.Size = new System.Drawing.Size(108, 17);
            this.Selected_Patient_label.TabIndex = 2;
            this.Selected_Patient_label.Text = "Selected Patient:";
            // 
            // Select_Patient_dataGridView
            // 
            this.Select_Patient_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Select_Patient_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Select_Patient_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Select_Patient_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Select_Patient_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Select_Patient_dataGridView.Location = new System.Drawing.Point(0, 17);
            this.Select_Patient_dataGridView.Name = "Select_Patient_dataGridView";
            this.Select_Patient_dataGridView.Size = new System.Drawing.Size(800, 139);
            this.Select_Patient_dataGridView.TabIndex = 1;
            this.Select_Patient_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select_Patient_dataGridView_CellClick);
            // 
            // Click_TO_LOAD_HISTORYlabel
            // 
            this.Click_TO_LOAD_HISTORYlabel.AutoSize = true;
            this.Click_TO_LOAD_HISTORYlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Click_TO_LOAD_HISTORYlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click_TO_LOAD_HISTORYlabel.Location = new System.Drawing.Point(0, 0);
            this.Click_TO_LOAD_HISTORYlabel.Name = "Click_TO_LOAD_HISTORYlabel";
            this.Click_TO_LOAD_HISTORYlabel.Size = new System.Drawing.Size(205, 17);
            this.Click_TO_LOAD_HISTORYlabel.TabIndex = 0;
            this.Click_TO_LOAD_HISTORYlabel.Text = "Click Row To Load History Below";
            // 
            // Patient_History_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.To_fill_dgvpanel1);
            this.Controls.Add(this.Top_Search_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_History_Receptionist";
            this.Text = "Patient_History_Receptionist";
            this.Load += new System.EventHandler(this.Patient_History_Receptionist_Load);
            this.Top_Search_panel.ResumeLayout(false);
            this.Top_Search_panel.PerformLayout();
            this.To_fill_dgvpanel1.ResumeLayout(false);
            this.To_fill_dgvpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Selected_Pat_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Patient_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Search_panel;
        private System.Windows.Forms.Button Search_Patient_button;
        private System.Windows.Forms.TextBox Patient_Search_textBox;
        private System.Windows.Forms.Label Patient_search_Name_label;
        private System.Windows.Forms.Panel To_fill_dgvpanel1;
        private System.Windows.Forms.Label Click_TO_LOAD_HISTORYlabel;
        private System.Windows.Forms.DataGridView Selected_Pat_dataGridView;
        private System.Windows.Forms.Label Selected_Patient_label;
        private System.Windows.Forms.DataGridView Select_Patient_dataGridView;
    }
}