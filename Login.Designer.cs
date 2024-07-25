namespace RentalCar
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBuserId = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // TBuserId
            // 
            this.TBuserId.BackColor = System.Drawing.Color.White;
            this.TBuserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBuserId.Location = new System.Drawing.Point(110, 99);
            this.TBuserId.Name = "TBuserId";
            this.TBuserId.Size = new System.Drawing.Size(256, 34);
            this.TBuserId.TabIndex = 1;
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBpassword.Location = new System.Drawing.Point(110, 153);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(256, 34);
            this.TBpassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(91, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rental Car Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNlogin
            // 
            this.BTNlogin.BackColor = System.Drawing.Color.Transparent;
            this.BTNlogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNlogin.ForeColor = System.Drawing.Color.Coral;
            this.BTNlogin.Location = new System.Drawing.Point(110, 221);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(256, 39);
            this.BTNlogin.TabIndex = 5;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = false;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 318);
            this.ControlBox = false;
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBuserId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENT A CAR";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBuserId;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNlogin;
    }
}

