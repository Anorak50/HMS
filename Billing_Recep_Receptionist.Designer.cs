namespace HMS
{
    partial class Billing_Recep_Receptionist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Group_Patient_Info = new System.Windows.Forms.GroupBox();
            this.Pay_method_val = new System.Windows.Forms.ComboBox();
            this.Pay_Method_label = new System.Windows.Forms.Label();
            this.App_Id_button = new System.Windows.Forms.Button();
            this.Billing_total_value = new System.Windows.Forms.Label();
            this.Billing_Total_label = new System.Windows.Forms.Label();
            this.Pay_stat_val = new System.Windows.Forms.ComboBox();
            this.Billing_Discount_label = new System.Windows.Forms.Label();
            this.Billing_Discount_value = new System.Windows.Forms.MaskedTextBox();
            this.Billing_Patient_Name_label = new System.Windows.Forms.Label();
            this.Billing_Patient_Name_value = new System.Windows.Forms.MaskedTextBox();
            this.Clear_Patient_button = new System.Windows.Forms.Button();
            this.Save_Patient_button = new System.Windows.Forms.Button();
            this.Billing_Payment_Stat_label = new System.Windows.Forms.Label();
            this.Billing_Appointment_ID_label = new System.Windows.Forms.Label();
            this.Billing_Appointment_ID_value = new System.Windows.Forms.MaskedTextBox();
            this.Invoice_Info_label = new System.Windows.Forms.Label();
            this.Invoice_Info_dgv = new System.Windows.Forms.DataGridView();
            this.Group_Patient_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Info_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_Patient_Info
            // 
            this.Group_Patient_Info.BackColor = System.Drawing.Color.White;
            this.Group_Patient_Info.Controls.Add(this.Pay_method_val);
            this.Group_Patient_Info.Controls.Add(this.Pay_Method_label);
            this.Group_Patient_Info.Controls.Add(this.App_Id_button);
            this.Group_Patient_Info.Controls.Add(this.Billing_total_value);
            this.Group_Patient_Info.Controls.Add(this.Billing_Total_label);
            this.Group_Patient_Info.Controls.Add(this.Pay_stat_val);
            this.Group_Patient_Info.Controls.Add(this.Billing_Discount_label);
            this.Group_Patient_Info.Controls.Add(this.Billing_Discount_value);
            this.Group_Patient_Info.Controls.Add(this.Billing_Patient_Name_label);
            this.Group_Patient_Info.Controls.Add(this.Billing_Patient_Name_value);
            this.Group_Patient_Info.Controls.Add(this.Clear_Patient_button);
            this.Group_Patient_Info.Controls.Add(this.Save_Patient_button);
            this.Group_Patient_Info.Controls.Add(this.Billing_Payment_Stat_label);
            this.Group_Patient_Info.Controls.Add(this.Billing_Appointment_ID_label);
            this.Group_Patient_Info.Controls.Add(this.Billing_Appointment_ID_value);
            this.Group_Patient_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.Group_Patient_Info.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Patient_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.Group_Patient_Info.Location = new System.Drawing.Point(0, 0);
            this.Group_Patient_Info.Name = "Group_Patient_Info";
            this.Group_Patient_Info.Padding = new System.Windows.Forms.Padding(10);
            this.Group_Patient_Info.Size = new System.Drawing.Size(387, 450);
            this.Group_Patient_Info.TabIndex = 1;
            this.Group_Patient_Info.TabStop = false;
            this.Group_Patient_Info.Text = "Patient Information";
            // 
            // Pay_method_val
            // 
            this.Pay_method_val.FormattingEnabled = true;
            this.Pay_method_val.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "EMI"});
            this.Pay_method_val.Location = new System.Drawing.Point(191, 326);
            this.Pay_method_val.Name = "Pay_method_val";
            this.Pay_method_val.Size = new System.Drawing.Size(121, 38);
            this.Pay_method_val.TabIndex = 26;
            // 
            // Pay_Method_label
            // 
            this.Pay_Method_label.AutoSize = true;
            this.Pay_Method_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_Method_label.ForeColor = System.Drawing.Color.Black;
            this.Pay_Method_label.Location = new System.Drawing.Point(184, 293);
            this.Pay_Method_label.Name = "Pay_Method_label";
            this.Pay_Method_label.Size = new System.Drawing.Size(182, 30);
            this.Pay_Method_label.TabIndex = 25;
            this.Pay_Method_label.Text = "Payment Method";
            // 
            // App_Id_button
            // 
            this.App_Id_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.App_Id_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.App_Id_button.FlatAppearance.BorderSize = 0;
            this.App_Id_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App_Id_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Id_button.ForeColor = System.Drawing.Color.White;
            this.App_Id_button.Location = new System.Drawing.Point(331, 73);
            this.App_Id_button.Name = "App_Id_button";
            this.App_Id_button.Size = new System.Drawing.Size(32, 27);
            this.App_Id_button.TabIndex = 24;
            this.App_Id_button.Text = "✅";
            this.App_Id_button.UseVisualStyleBackColor = false;
            this.App_Id_button.Click += new System.EventHandler(this.App_Id_button_Click);
            // 
            // Billing_total_value
            // 
            this.Billing_total_value.AutoSize = true;
            this.Billing_total_value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_total_value.ForeColor = System.Drawing.Color.Black;
            this.Billing_total_value.Location = new System.Drawing.Point(88, 253);
            this.Billing_total_value.Name = "Billing_total_value";
            this.Billing_total_value.Size = new System.Drawing.Size(67, 30);
            this.Billing_total_value.TabIndex = 23;
            this.Billing_total_value.Text = "0.00$";
            // 
            // Billing_Total_label
            // 
            this.Billing_Total_label.AutoSize = true;
            this.Billing_Total_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Total_label.ForeColor = System.Drawing.Color.Black;
            this.Billing_Total_label.Location = new System.Drawing.Point(15, 253);
            this.Billing_Total_label.Name = "Billing_Total_label";
            this.Billing_Total_label.Size = new System.Drawing.Size(67, 30);
            this.Billing_Total_label.TabIndex = 22;
            this.Billing_Total_label.Text = "Total:";
            // 
            // Pay_stat_val
            // 
            this.Pay_stat_val.FormattingEnabled = true;
            this.Pay_stat_val.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.Pay_stat_val.Location = new System.Drawing.Point(20, 326);
            this.Pay_stat_val.Name = "Pay_stat_val";
            this.Pay_stat_val.Size = new System.Drawing.Size(121, 38);
            this.Pay_stat_val.TabIndex = 21;
            // 
            // Billing_Discount_label
            // 
            this.Billing_Discount_label.AutoSize = true;
            this.Billing_Discount_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Discount_label.ForeColor = System.Drawing.Color.Black;
            this.Billing_Discount_label.Location = new System.Drawing.Point(14, 176);
            this.Billing_Discount_label.Name = "Billing_Discount_label";
            this.Billing_Discount_label.Size = new System.Drawing.Size(106, 30);
            this.Billing_Discount_label.TabIndex = 19;
            this.Billing_Discount_label.Text = "Discount:";
            // 
            // Billing_Discount_value
            // 
            this.Billing_Discount_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Billing_Discount_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Billing_Discount_value.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Discount_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Billing_Discount_value.Location = new System.Drawing.Point(12, 213);
            this.Billing_Discount_value.Name = "Billing_Discount_value";
            this.Billing_Discount_value.Size = new System.Drawing.Size(312, 27);
            this.Billing_Discount_value.TabIndex = 18;
            this.Billing_Discount_value.TextChanged += new System.EventHandler(this.Billing_Discount_value_TextChanged);
            // 
            // Billing_Patient_Name_label
            // 
            this.Billing_Patient_Name_label.AutoSize = true;
            this.Billing_Patient_Name_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Patient_Name_label.ForeColor = System.Drawing.Color.Black;
            this.Billing_Patient_Name_label.Location = new System.Drawing.Point(15, 109);
            this.Billing_Patient_Name_label.Name = "Billing_Patient_Name_label";
            this.Billing_Patient_Name_label.Size = new System.Drawing.Size(152, 30);
            this.Billing_Patient_Name_label.TabIndex = 17;
            this.Billing_Patient_Name_label.Text = "Patient Name:";
            // 
            // Billing_Patient_Name_value
            // 
            this.Billing_Patient_Name_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Billing_Patient_Name_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Billing_Patient_Name_value.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Patient_Name_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Billing_Patient_Name_value.Location = new System.Drawing.Point(13, 142);
            this.Billing_Patient_Name_value.Name = "Billing_Patient_Name_value";
            this.Billing_Patient_Name_value.Size = new System.Drawing.Size(312, 27);
            this.Billing_Patient_Name_value.TabIndex = 16;
            // 
            // Clear_Patient_button
            // 
            this.Clear_Patient_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.Clear_Patient_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Patient_button.FlatAppearance.BorderSize = 0;
            this.Clear_Patient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Patient_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Patient_button.ForeColor = System.Drawing.Color.White;
            this.Clear_Patient_button.Location = new System.Drawing.Point(196, 375);
            this.Clear_Patient_button.Name = "Clear_Patient_button";
            this.Clear_Patient_button.Size = new System.Drawing.Size(152, 44);
            this.Clear_Patient_button.TabIndex = 15;
            this.Clear_Patient_button.Text = "Clear";
            this.Clear_Patient_button.UseVisualStyleBackColor = false;
            this.Clear_Patient_button.Click += new System.EventHandler(this.Clear_Patient_button_Click);
            // 
            // Save_Patient_button
            // 
            this.Save_Patient_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.Save_Patient_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Patient_button.FlatAppearance.BorderSize = 0;
            this.Save_Patient_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Patient_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Patient_button.ForeColor = System.Drawing.Color.White;
            this.Save_Patient_button.Location = new System.Drawing.Point(20, 375);
            this.Save_Patient_button.Name = "Save_Patient_button";
            this.Save_Patient_button.Size = new System.Drawing.Size(152, 44);
            this.Save_Patient_button.TabIndex = 14;
            this.Save_Patient_button.Text = "Save Patient";
            this.Save_Patient_button.UseVisualStyleBackColor = false;
            this.Save_Patient_button.Click += new System.EventHandler(this.Save_Patient_button_Click);
            // 
            // Billing_Payment_Stat_label
            // 
            this.Billing_Payment_Stat_label.AutoSize = true;
            this.Billing_Payment_Stat_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Payment_Stat_label.ForeColor = System.Drawing.Color.Black;
            this.Billing_Payment_Stat_label.Location = new System.Drawing.Point(13, 293);
            this.Billing_Payment_Stat_label.Name = "Billing_Payment_Stat_label";
            this.Billing_Payment_Stat_label.Size = new System.Drawing.Size(164, 30);
            this.Billing_Payment_Stat_label.TabIndex = 13;
            this.Billing_Payment_Stat_label.Text = "Payment Status";
            // 
            // Billing_Appointment_ID_label
            // 
            this.Billing_Appointment_ID_label.AutoSize = true;
            this.Billing_Appointment_ID_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Appointment_ID_label.ForeColor = System.Drawing.Color.Black;
            this.Billing_Appointment_ID_label.Location = new System.Drawing.Point(15, 40);
            this.Billing_Appointment_ID_label.Name = "Billing_Appointment_ID_label";
            this.Billing_Appointment_ID_label.Size = new System.Drawing.Size(179, 30);
            this.Billing_Appointment_ID_label.TabIndex = 5;
            this.Billing_Appointment_ID_label.Text = "Appointment ID:";
            // 
            // Billing_Appointment_ID_value
            // 
            this.Billing_Appointment_ID_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Billing_Appointment_ID_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Billing_Appointment_ID_value.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billing_Appointment_ID_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Billing_Appointment_ID_value.Location = new System.Drawing.Point(13, 73);
            this.Billing_Appointment_ID_value.Name = "Billing_Appointment_ID_value";
            this.Billing_Appointment_ID_value.Size = new System.Drawing.Size(312, 27);
            this.Billing_Appointment_ID_value.TabIndex = 0;
            // 
            // Invoice_Info_label
            // 
            this.Invoice_Info_label.AutoSize = true;
            this.Invoice_Info_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Invoice_Info_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_Info_label.ForeColor = System.Drawing.Color.Black;
            this.Invoice_Info_label.Location = new System.Drawing.Point(387, 0);
            this.Invoice_Info_label.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.Invoice_Info_label.Name = "Invoice_Info_label";
            this.Invoice_Info_label.Size = new System.Drawing.Size(209, 30);
            this.Invoice_Info_label.TabIndex = 7;
            this.Invoice_Info_label.Text = "Invoice Information";
            // 
            // Invoice_Info_dgv
            // 
            this.Invoice_Info_dgv.AllowUserToAddRows = false;
            this.Invoice_Info_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Invoice_Info_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Invoice_Info_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoice_Info_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Invoice_Info_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_Info_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoice_Info_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Invoice_Info_dgv.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Invoice_Info_dgv.Location = new System.Drawing.Point(387, 30);
            this.Invoice_Info_dgv.Name = "Invoice_Info_dgv";
            this.Invoice_Info_dgv.ReadOnly = true;
            this.Invoice_Info_dgv.RowHeadersVisible = false;
            this.Invoice_Info_dgv.RowTemplate.Height = 40;
            this.Invoice_Info_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoice_Info_dgv.Size = new System.Drawing.Size(413, 420);
            this.Invoice_Info_dgv.TabIndex = 8;
            // 
            // Billing_Recep_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Invoice_Info_dgv);
            this.Controls.Add(this.Invoice_Info_label);
            this.Controls.Add(this.Group_Patient_Info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing_Recep_Receptionist";
            this.Text = "BillingRecep";
            this.Load += new System.EventHandler(this.Billing_Recep_Receptionist_Load);
            this.Group_Patient_Info.ResumeLayout(false);
            this.Group_Patient_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Info_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_Patient_Info;
        private System.Windows.Forms.Button Clear_Patient_button;
        private System.Windows.Forms.Button Save_Patient_button;
        private System.Windows.Forms.Label Billing_Payment_Stat_label;
        private System.Windows.Forms.Label Billing_Appointment_ID_label;
        private System.Windows.Forms.MaskedTextBox Billing_Appointment_ID_value;
        private System.Windows.Forms.Label Billing_Patient_Name_label;
        private System.Windows.Forms.MaskedTextBox Billing_Patient_Name_value;
        private System.Windows.Forms.Label Billing_Discount_label;
        private System.Windows.Forms.MaskedTextBox Billing_Discount_value;
        private System.Windows.Forms.ComboBox Pay_stat_val;
        private System.Windows.Forms.Label Billing_total_value;
        private System.Windows.Forms.Label Billing_Total_label;
        private System.Windows.Forms.Label Invoice_Info_label;
        private System.Windows.Forms.Button App_Id_button;
        private System.Windows.Forms.DataGridView Invoice_Info_dgv;
        private System.Windows.Forms.ComboBox Pay_method_val;
        private System.Windows.Forms.Label Pay_Method_label;
    }
}