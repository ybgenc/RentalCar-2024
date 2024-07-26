namespace RentalCar
{
    partial class Employee
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
            this.TBid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNdeleteEmployee = new System.Windows.Forms.Button();
            this.BTNupdateEmployee = new System.Windows.Forms.Button();
            this.BTNaddEmployee = new System.Windows.Forms.Button();
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVemployee = new System.Windows.Forms.DataGridView();
            this.BTNaddEmployeepicture = new System.Windows.Forms.Button();
            this.PBemployeePicture = new System.Windows.Forms.PictureBox();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBmobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBuserId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DTPdateOfStart = new System.Windows.Forms.DateTimePicker();
            this.DTPdateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBemployeePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TBid
            // 
            this.TBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBid.Location = new System.Drawing.Point(88, 59);
            this.TBid.Name = "TBid";
            this.TBid.Size = new System.Drawing.Size(137, 28);
            this.TBid.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTNdeleteEmployee
            // 
            this.BTNdeleteEmployee.Location = new System.Drawing.Point(338, 211);
            this.BTNdeleteEmployee.Name = "BTNdeleteEmployee";
            this.BTNdeleteEmployee.Size = new System.Drawing.Size(157, 32);
            this.BTNdeleteEmployee.TabIndex = 85;
            this.BTNdeleteEmployee.Text = "Delete Employee";
            this.BTNdeleteEmployee.UseVisualStyleBackColor = true;
            this.BTNdeleteEmployee.Click += new System.EventHandler(this.BTNdeleteEmployee_Click);
            // 
            // BTNupdateEmployee
            // 
            this.BTNupdateEmployee.Location = new System.Drawing.Point(175, 212);
            this.BTNupdateEmployee.Name = "BTNupdateEmployee";
            this.BTNupdateEmployee.Size = new System.Drawing.Size(157, 32);
            this.BTNupdateEmployee.TabIndex = 84;
            this.BTNupdateEmployee.Text = "Update Employee";
            this.BTNupdateEmployee.UseVisualStyleBackColor = true;
            this.BTNupdateEmployee.Click += new System.EventHandler(this.BTNupdateEmployee_Click);
            // 
            // BTNaddEmployee
            // 
            this.BTNaddEmployee.Location = new System.Drawing.Point(12, 212);
            this.BTNaddEmployee.Name = "BTNaddEmployee";
            this.BTNaddEmployee.Size = new System.Drawing.Size(157, 32);
            this.BTNaddEmployee.TabIndex = 83;
            this.BTNaddEmployee.Text = "Add Employee";
            this.BTNaddEmployee.UseVisualStyleBackColor = true;
            this.BTNaddEmployee.Click += new System.EventHandler(this.BTNaddEmployee_Click);
            // 
            // TBsearch
            // 
            this.TBsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBsearch.Location = new System.Drawing.Point(88, 274);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(137, 28);
            this.TBsearch.TabIndex = 82;
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Search";
            // 
            // DGVemployee
            // 
            this.DGVemployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVemployee.Location = new System.Drawing.Point(12, 308);
            this.DGVemployee.Name = "DGVemployee";
            this.DGVemployee.ReadOnly = true;
            this.DGVemployee.RowHeadersWidth = 51;
            this.DGVemployee.RowTemplate.Height = 24;
            this.DGVemployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVemployee.Size = new System.Drawing.Size(889, 315);
            this.DGVemployee.TabIndex = 80;
            this.DGVemployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVemployee_CellClick);
            // 
            // BTNaddEmployeepicture
            // 
            this.BTNaddEmployeepicture.Location = new System.Drawing.Point(501, 211);
            this.BTNaddEmployeepicture.Name = "BTNaddEmployeepicture";
            this.BTNaddEmployeepicture.Size = new System.Drawing.Size(162, 33);
            this.BTNaddEmployeepicture.TabIndex = 79;
            this.BTNaddEmployeepicture.Text = "Add Picture";
            this.BTNaddEmployeepicture.UseVisualStyleBackColor = true;
            this.BTNaddEmployeepicture.Click += new System.EventHandler(this.BTNaddEmployeepicture_Click);
            // 
            // PBemployeePicture
            // 
            this.PBemployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBemployeePicture.Location = new System.Drawing.Point(669, 15);
            this.PBemployeePicture.Name = "PBemployeePicture";
            this.PBemployeePicture.Size = new System.Drawing.Size(232, 226);
            this.PBemployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBemployeePicture.TabIndex = 78;
            this.PBemployeePicture.TabStop = false;
            // 
            // TBmail
            // 
            this.TBmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmail.Location = new System.Drawing.Point(88, 150);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(137, 28);
            this.TBmail.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mail";
            // 
            // TBmobile
            // 
            this.TBmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmobile.Location = new System.Drawing.Point(88, 105);
            this.TBmobile.Name = "TBmobile";
            this.TBmobile.Size = new System.Drawing.Size(137, 28);
            this.TBmobile.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "Mobile";
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBname.Location = new System.Drawing.Point(88, 15);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(137, 28);
            this.TBname.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Name";
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBpassword.Location = new System.Drawing.Point(392, 59);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(137, 28);
            this.TBpassword.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(278, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(278, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(278, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "Date of start";
            // 
            // TBuserId
            // 
            this.TBuserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBuserId.Location = new System.Drawing.Point(392, 15);
            this.TBuserId.Name = "TBuserId";
            this.TBuserId.Size = new System.Drawing.Size(137, 28);
            this.TBuserId.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(278, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 92;
            this.label8.Text = "User ID";
            // 
            // DTPdateOfStart
            // 
            this.DTPdateOfStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdateOfStart.Location = new System.Drawing.Point(392, 111);
            this.DTPdateOfStart.Name = "DTPdateOfStart";
            this.DTPdateOfStart.Size = new System.Drawing.Size(137, 22);
            this.DTPdateOfStart.TabIndex = 100;
            // 
            // DTPdateOfBirth
            // 
            this.DTPdateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPdateOfBirth.Location = new System.Drawing.Point(392, 150);
            this.DTPdateOfBirth.Name = "DTPdateOfBirth";
            this.DTPdateOfBirth.Size = new System.Drawing.Size(137, 22);
            this.DTPdateOfBirth.TabIndex = 101;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 632);
            this.Controls.Add(this.DTPdateOfBirth);
            this.Controls.Add(this.DTPdateOfStart);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBuserId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNdeleteEmployee);
            this.Controls.Add(this.BTNupdateEmployee);
            this.Controls.Add(this.BTNaddEmployee);
            this.Controls.Add(this.TBsearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGVemployee);
            this.Controls.Add(this.BTNaddEmployeepicture);
            this.Controls.Add(this.PBemployeePicture);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBmobile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBemployeePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNdeleteEmployee;
        private System.Windows.Forms.Button BTNupdateEmployee;
        private System.Windows.Forms.Button BTNaddEmployee;
        private System.Windows.Forms.TextBox TBsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVemployee;
        private System.Windows.Forms.Button BTNaddEmployeepicture;
        private System.Windows.Forms.PictureBox PBemployeePicture;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBmobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBuserId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTPdateOfStart;
        private System.Windows.Forms.DateTimePicker DTPdateOfBirth;
    }
}