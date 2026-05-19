namespace HMS
{
    partial class Book_Appointment_Receptionist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TOFILL_panel = new System.Windows.Forms.Panel();
            this.dataGridView_Left = new System.Windows.Forms.DataGridView();
            this.Search_Doc_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Doctor_search_Name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Selected_Doc_label = new System.Windows.Forms.Label();
            this.Selected_Doc_val = new System.Windows.Forms.MaskedTextBox();
            this.Select_Patient_label = new System.Windows.Forms.Label();
            this.Selected_Patient_val = new System.Windows.Forms.MaskedTextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.Date_val = new System.Windows.Forms.MaskedTextBox();
            this.Time_label = new System.Windows.Forms.Label();
            this.Time_val = new System.Windows.Forms.MaskedTextBox();
            this.Chk_avail_button = new System.Windows.Forms.Button();
            this.Book_Appointment_button = new System.Windows.Forms.Button();
            this.Booking_From_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Del_App_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Update_button = new System.Windows.Forms.Button();
            this.TOFILL_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Left)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // TOFILL_panel
            // 
            this.TOFILL_panel.Controls.Add(this.panel5);
            this.TOFILL_panel.Controls.Add(this.dataGridView_Left);
            this.TOFILL_panel.Controls.Add(this.panel4);
            this.TOFILL_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TOFILL_panel.Location = new System.Drawing.Point(0, 0);
            this.TOFILL_panel.Name = "TOFILL_panel";
            this.TOFILL_panel.Size = new System.Drawing.Size(354, 450);
            this.TOFILL_panel.TabIndex = 18;
            // 
            // dataGridView_Left
            // 
            this.dataGridView_Left.AllowUserToAddRows = false;
            this.dataGridView_Left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Left.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Left.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Left.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Left.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Left.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView_Left.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView_Left.Location = new System.Drawing.Point(0, 74);
            this.dataGridView_Left.Name = "dataGridView_Left";
            this.dataGridView_Left.ReadOnly = true;
            this.dataGridView_Left.RowHeadersVisible = false;
            this.dataGridView_Left.RowTemplate.Height = 38;
            this.dataGridView_Left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Left.Size = new System.Drawing.Size(354, 263);
            this.dataGridView_Left.TabIndex = 8;
            this.dataGridView_Left.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Left_CellClick);
            // 
            // Search_Doc_maskedTextBox
            // 
            this.Search_Doc_maskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Search_Doc_maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Doc_maskedTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Doc_maskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Search_Doc_maskedTextBox.Location = new System.Drawing.Point(8, 33);
            this.Search_Doc_maskedTextBox.Name = "Search_Doc_maskedTextBox";
            this.Search_Doc_maskedTextBox.Size = new System.Drawing.Size(243, 27);
            this.Search_Doc_maskedTextBox.TabIndex = 10;
            this.Search_Doc_maskedTextBox.TextChanged += new System.EventHandler(this.Search_Doc_maskedTextBox_TextChanged);
            // 
            // Doctor_search_Name_label
            // 
            this.Doctor_search_Name_label.AutoSize = true;
            this.Doctor_search_Name_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_search_Name_label.ForeColor = System.Drawing.Color.Black;
            this.Doctor_search_Name_label.Location = new System.Drawing.Point(3, 0);
            this.Doctor_search_Name_label.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.Doctor_search_Name_label.Name = "Doctor_search_Name_label";
            this.Doctor_search_Name_label.Size = new System.Drawing.Size(151, 30);
            this.Doctor_search_Name_label.TabIndex = 6;
            this.Doctor_search_Name_label.Text = "Doctor Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TOFILL_panel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Update_button);
            this.panel3.Controls.Add(this.Del_App_button);
            this.panel3.Controls.Add(this.Book_Appointment_button);
            this.panel3.Controls.Add(this.Chk_avail_button);
            this.panel3.Controls.Add(this.Selected_Doc_label);
            this.panel3.Controls.Add(this.Booking_From_label);
            this.panel3.Controls.Add(this.Selected_Doc_val);
            this.panel3.Controls.Add(this.Select_Patient_label);
            this.panel3.Controls.Add(this.Selected_Patient_val);
            this.panel3.Controls.Add(this.Date_label);
            this.panel3.Controls.Add(this.Date_val);
            this.panel3.Controls.Add(this.Time_label);
            this.panel3.Controls.Add(this.Time_val);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(354, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 450);
            this.panel3.TabIndex = 17;
            // 
            // Selected_Doc_label
            // 
            this.Selected_Doc_label.AutoSize = true;
            this.Selected_Doc_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Doc_label.ForeColor = System.Drawing.Color.Black;
            this.Selected_Doc_label.Location = new System.Drawing.Point(16, 44);
            this.Selected_Doc_label.Margin = new System.Windows.Forms.Padding(5);
            this.Selected_Doc_label.Name = "Selected_Doc_label";
            this.Selected_Doc_label.Size = new System.Drawing.Size(168, 30);
            this.Selected_Doc_label.TabIndex = 27;
            this.Selected_Doc_label.Text = "Selected Doctor";
            // 
            // Selected_Doc_val
            // 
            this.Selected_Doc_val.AccessibleName = "";
            this.Selected_Doc_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Selected_Doc_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Doc_val.ForeColor = System.Drawing.Color.Black;
            this.Selected_Doc_val.Location = new System.Drawing.Point(21, 82);
            this.Selected_Doc_val.Name = "Selected_Doc_val";
            this.Selected_Doc_val.Size = new System.Drawing.Size(303, 29);
            this.Selected_Doc_val.TabIndex = 26;
            // 
            // Select_Patient_label
            // 
            this.Select_Patient_label.AutoSize = true;
            this.Select_Patient_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Patient_label.ForeColor = System.Drawing.Color.Black;
            this.Select_Patient_label.Location = new System.Drawing.Point(19, 113);
            this.Select_Patient_label.Margin = new System.Windows.Forms.Padding(5);
            this.Select_Patient_label.Name = "Select_Patient_label";
            this.Select_Patient_label.Size = new System.Drawing.Size(196, 30);
            this.Select_Patient_label.TabIndex = 29;
            this.Select_Patient_label.Text = "Selected Patient Id";
            // 
            // Selected_Patient_val
            // 
            this.Selected_Patient_val.AccessibleName = "";
            this.Selected_Patient_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Selected_Patient_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected_Patient_val.ForeColor = System.Drawing.Color.Black;
            this.Selected_Patient_val.Location = new System.Drawing.Point(21, 151);
            this.Selected_Patient_val.Mask = "000";
            this.Selected_Patient_val.Name = "Selected_Patient_val";
            this.Selected_Patient_val.Size = new System.Drawing.Size(303, 29);
            this.Selected_Patient_val.TabIndex = 28;
            this.Selected_Patient_val.ValidatingType = typeof(int);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.Color.Black;
            this.Date_label.Location = new System.Drawing.Point(19, 177);
            this.Date_label.Margin = new System.Windows.Forms.Padding(5);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(58, 30);
            this.Date_label.TabIndex = 30;
            this.Date_label.Text = "Date";
            // 
            // Date_val
            // 
            this.Date_val.AccessibleName = "No doctor selected";
            this.Date_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Date_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_val.ForeColor = System.Drawing.Color.Black;
            this.Date_val.Location = new System.Drawing.Point(21, 206);
            this.Date_val.Mask = "00/00/0000";
            this.Date_val.Name = "Date_val";
            this.Date_val.Size = new System.Drawing.Size(303, 29);
            this.Date_val.TabIndex = 31;
            this.Date_val.ValidatingType = typeof(System.DateTime);
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.ForeColor = System.Drawing.Color.Black;
            this.Time_label.Location = new System.Drawing.Point(16, 233);
            this.Time_label.Margin = new System.Windows.Forms.Padding(5);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(61, 30);
            this.Time_label.TabIndex = 32;
            this.Time_label.Text = "Time";
            // 
            // Time_val
            // 
            this.Time_val.AccessibleName = "No doctor selected";
            this.Time_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Time_val.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_val.ForeColor = System.Drawing.Color.Black;
            this.Time_val.Location = new System.Drawing.Point(21, 271);
            this.Time_val.Mask = "90:00";
            this.Time_val.Name = "Time_val";
            this.Time_val.Size = new System.Drawing.Size(303, 29);
            this.Time_val.TabIndex = 33;
            this.Time_val.ValidatingType = typeof(System.DateTime);
            // 
            // Chk_avail_button
            // 
            this.Chk_avail_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.Chk_avail_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chk_avail_button.FlatAppearance.BorderSize = 0;
            this.Chk_avail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chk_avail_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_avail_button.ForeColor = System.Drawing.Color.White;
            this.Chk_avail_button.Location = new System.Drawing.Point(21, 316);
            this.Chk_avail_button.Name = "Chk_avail_button";
            this.Chk_avail_button.Size = new System.Drawing.Size(152, 44);
            this.Chk_avail_button.TabIndex = 16;
            this.Chk_avail_button.Text = "Check Availability";
            this.Chk_avail_button.UseVisualStyleBackColor = false;
            this.Chk_avail_button.Click += new System.EventHandler(this.Chk_avail_button_Click);
            // 
            // Book_Appointment_button
            // 
            this.Book_Appointment_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Book_Appointment_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book_Appointment_button.FlatAppearance.BorderSize = 0;
            this.Book_Appointment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book_Appointment_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Appointment_button.ForeColor = System.Drawing.Color.White;
            this.Book_Appointment_button.Location = new System.Drawing.Point(203, 316);
            this.Book_Appointment_button.Name = "Book_Appointment_button";
            this.Book_Appointment_button.Size = new System.Drawing.Size(152, 44);
            this.Book_Appointment_button.TabIndex = 15;
            this.Book_Appointment_button.Text = "Book Appointment";
            this.Book_Appointment_button.UseVisualStyleBackColor = false;
            this.Book_Appointment_button.Click += new System.EventHandler(this.Book_Appointment_button_Click);
            // 
            // Booking_From_label
            // 
            this.Booking_From_label.AutoSize = true;
            this.Booking_From_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking_From_label.ForeColor = System.Drawing.Color.Black;
            this.Booking_From_label.Location = new System.Drawing.Point(2, 3);
            this.Booking_From_label.Margin = new System.Windows.Forms.Padding(5);
            this.Booking_From_label.Name = "Booking_From_label";
            this.Booking_From_label.Size = new System.Drawing.Size(153, 30);
            this.Booking_From_label.TabIndex = 9;
            this.Booking_From_label.Text = "Booking Form";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.Doctor_search_Name_label);
            this.panel4.Controls.Add(this.Search_Doc_maskedTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 74);
            this.panel4.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(24, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(312, 314);
            this.dataGridView1.TabIndex = 8;
            // 
            // Del_App_button
            // 
            this.Del_App_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Del_App_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Del_App_button.FlatAppearance.BorderSize = 0;
            this.Del_App_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_App_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_App_button.ForeColor = System.Drawing.Color.White;
            this.Del_App_button.Location = new System.Drawing.Point(320, 383);
            this.Del_App_button.Name = "Del_App_button";
            this.Del_App_button.Size = new System.Drawing.Size(99, 24);
            this.Del_App_button.TabIndex = 41;
            this.Del_App_button.Text = "Delete Appointment";
            this.Del_App_button.UseVisualStyleBackColor = false;
            this.Del_App_button.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 337);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 113);
            this.panel5.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 38;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(354, 113);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellBorderStyleChanged += new System.EventHandler(this.dataGridView2_CellBorderStyleChanged);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_button.FlatAppearance.BorderSize = 0;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.ForeColor = System.Drawing.Color.White;
            this.Update_button.Location = new System.Drawing.Point(106, 373);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(194, 44);
            this.Update_button.TabIndex = 42;
            this.Update_button.Text = "Update Appointment";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Visible = false;
            // 
            // Book_Appointment_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Appointment_Receptionist";
            this.Text = "Book_Appointment_Receptionist";
            this.Load += new System.EventHandler(this.Book_Appointment_Receptionist_Load);
            this.TOFILL_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Left)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Doctor_search_Name_label;
        private System.Windows.Forms.Label Booking_From_label;
        private System.Windows.Forms.DataGridView dataGridView_Left;
        private System.Windows.Forms.Button Book_Appointment_button;
        private System.Windows.Forms.Button Chk_avail_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox Search_Doc_maskedTextBox;
        private System.Windows.Forms.Panel TOFILL_panel;
        private System.Windows.Forms.Label Selected_Doc_label;
        private System.Windows.Forms.MaskedTextBox Selected_Doc_val;
        private System.Windows.Forms.Label Select_Patient_label;
        private System.Windows.Forms.MaskedTextBox Selected_Patient_val;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.MaskedTextBox Date_val;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.MaskedTextBox Time_val;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Del_App_button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Update_button;
    }
}