namespace RentalCar
{
    partial class Customer
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
            this.label12 = new System.Windows.Forms.Label();
            this.BTNdeleteCustomer = new System.Windows.Forms.Button();
            this.BTNupdateCustomer = new System.Windows.Forms.Button();
            this.BTNaddCustomer = new System.Windows.Forms.Button();
            this.TBsearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVcustomers = new System.Windows.Forms.DataGridView();
            this.BTNaddpicture = new System.Windows.Forms.Button();
            this.PBcustomerPicture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBbrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBaddress = new System.Windows.Forms.RichTextBox();
            this.DTPlicence = new System.Windows.Forms.DateTimePicker();
            this.DTPbirth = new System.Windows.Forms.DateTimePicker();
            this.TBid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBmobile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcustomerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(254, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Date of birth";
            // 
            // BTNdeleteCustomer
            // 
            this.BTNdeleteCustomer.Location = new System.Drawing.Point(344, 208);
            this.BTNdeleteCustomer.Name = "BTNdeleteCustomer";
            this.BTNdeleteCustomer.Size = new System.Drawing.Size(157, 32);
            this.BTNdeleteCustomer.TabIndex = 59;
            this.BTNdeleteCustomer.Text = "Delete Customer";
            this.BTNdeleteCustomer.UseVisualStyleBackColor = true;
            this.BTNdeleteCustomer.Click += new System.EventHandler(this.BTNdeleteCustomer_Click);
            // 
            // BTNupdateCustomer
            // 
            this.BTNupdateCustomer.Location = new System.Drawing.Point(181, 209);
            this.BTNupdateCustomer.Name = "BTNupdateCustomer";
            this.BTNupdateCustomer.Size = new System.Drawing.Size(157, 32);
            this.BTNupdateCustomer.TabIndex = 58;
            this.BTNupdateCustomer.Text = "Update Customer";
            this.BTNupdateCustomer.UseVisualStyleBackColor = true;
            this.BTNupdateCustomer.Click += new System.EventHandler(this.BTNupdateCustomer_Click);
            // 
            // BTNaddCustomer
            // 
            this.BTNaddCustomer.Location = new System.Drawing.Point(18, 209);
            this.BTNaddCustomer.Name = "BTNaddCustomer";
            this.BTNaddCustomer.Size = new System.Drawing.Size(157, 32);
            this.BTNaddCustomer.TabIndex = 57;
            this.BTNaddCustomer.Text = "Add Customer";
            this.BTNaddCustomer.UseVisualStyleBackColor = true;
            this.BTNaddCustomer.Click += new System.EventHandler(this.BTNaddCustomer_Click);
            // 
            // TBsearch
            // 
            this.TBsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBsearch.Location = new System.Drawing.Point(94, 271);
            this.TBsearch.Name = "TBsearch";
            this.TBsearch.Size = new System.Drawing.Size(137, 28);
            this.TBsearch.TabIndex = 56;
            this.TBsearch.TextChanged += new System.EventHandler(this.TBsearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Search";
            // 
            // DGVcustomers
            // 
            this.DGVcustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcustomers.Location = new System.Drawing.Point(18, 305);
            this.DGVcustomers.Name = "DGVcustomers";
            this.DGVcustomers.ReadOnly = true;
            this.DGVcustomers.RowHeadersWidth = 51;
            this.DGVcustomers.RowTemplate.Height = 24;
            this.DGVcustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcustomers.Size = new System.Drawing.Size(889, 315);
            this.DGVcustomers.TabIndex = 54;
            this.DGVcustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcustomers_CellClick);
            // 
            // BTNaddpicture
            // 
            this.BTNaddpicture.Location = new System.Drawing.Point(507, 208);
            this.BTNaddpicture.Name = "BTNaddpicture";
            this.BTNaddpicture.Size = new System.Drawing.Size(162, 33);
            this.BTNaddpicture.TabIndex = 53;
            this.BTNaddpicture.Text = "Add Picture";
            this.BTNaddpicture.UseVisualStyleBackColor = true;
            this.BTNaddpicture.Click += new System.EventHandler(this.BTNaddpicture_Click);
            // 
            // PBcustomerPicture
            // 
            this.PBcustomerPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBcustomerPicture.Location = new System.Drawing.Point(675, 12);
            this.PBcustomerPicture.Name = "PBcustomerPicture";
            this.PBcustomerPicture.Size = new System.Drawing.Size(232, 226);
            this.PBcustomerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBcustomerPicture.TabIndex = 50;
            this.PBcustomerPicture.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(254, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Date of licence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(254, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Address";
            // 
            // TBmail
            // 
            this.TBmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmail.Location = new System.Drawing.Point(94, 142);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(137, 28);
            this.TBmail.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mail";
            // 
            // TBbrand
            // 
            this.TBbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBbrand.Location = new System.Drawing.Point(94, 95);
            this.TBbrand.Name = "TBbrand";
            this.TBbrand.Size = new System.Drawing.Size(137, 28);
            this.TBbrand.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mobile";
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBname.Location = new System.Drawing.Point(94, 12);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(137, 28);
            this.TBname.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // RTBaddress
            // 
            this.RTBaddress.Location = new System.Drawing.Point(393, 12);
            this.RTBaddress.Name = "RTBaddress";
            this.RTBaddress.Size = new System.Drawing.Size(262, 59);
            this.RTBaddress.TabIndex = 63;
            this.RTBaddress.Text = "";
            // 
            // DTPlicence
            // 
            this.DTPlicence.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTPlicence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPlicence.Location = new System.Drawing.Point(393, 95);
            this.DTPlicence.Name = "DTPlicence";
            this.DTPlicence.Size = new System.Drawing.Size(182, 22);
            this.DTPlicence.TabIndex = 64;
            // 
            // DTPbirth
            // 
            this.DTPbirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTPbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPbirth.Location = new System.Drawing.Point(393, 148);
            this.DTPbirth.Name = "DTPbirth";
            this.DTPbirth.Size = new System.Drawing.Size(182, 22);
            this.DTPbirth.TabIndex = 65;
            // 
            // TBid
            // 
            this.TBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBid.Location = new System.Drawing.Point(94, 56);
            this.TBid.Name = "TBid";
            this.TBid.Size = new System.Drawing.Size(137, 28);
            this.TBid.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mobile";
            // 
            // TBmobile
            // 
            this.TBmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmobile.Location = new System.Drawing.Point(94, 100);
            this.TBmobile.Name = "TBmobile";
            this.TBmobile.Size = new System.Drawing.Size(137, 28);
            this.TBmobile.TabIndex = 37;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 640);
            this.Controls.Add(this.TBid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPbirth);
            this.Controls.Add(this.DTPlicence);
            this.Controls.Add(this.RTBaddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BTNdeleteCustomer);
            this.Controls.Add(this.BTNupdateCustomer);
            this.Controls.Add(this.BTNaddCustomer);
            this.Controls.Add(this.TBsearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGVcustomers);
            this.Controls.Add(this.BTNaddpicture);
            this.Controls.Add(this.PBcustomerPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBmobile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBbrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcustomerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BTNdeleteCustomer;
        private System.Windows.Forms.Button BTNupdateCustomer;
        private System.Windows.Forms.Button BTNaddCustomer;
        private System.Windows.Forms.TextBox TBsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGVcustomers;
        private System.Windows.Forms.Button BTNaddpicture;
        private System.Windows.Forms.PictureBox PBcustomerPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBbrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBaddress;
        private System.Windows.Forms.DateTimePicker DTPlicence;
        private System.Windows.Forms.DateTimePicker DTPbirth;
        private System.Windows.Forms.TextBox TBid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBmobile;
    }
}