namespace RentalCar
{
    partial class Contract
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
            this.components = new System.ComponentModel.Container();
            this.GBcustomer = new System.Windows.Forms.GroupBox();
            this.TBlicenceDate = new System.Windows.Forms.TextBox();
            this.TBmobile = new System.Windows.Forms.TextBox();
            this.TBidSearch = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBcar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalCarDataSet1 = new RentalCar.RentalCarDataSet1();
            this.TBprice = new System.Windows.Forms.TextBox();
            this.TBfuel = new System.Windows.Forms.TextBox();
            this.TBcolor = new System.Windows.Forms.TextBox();
            this.TByear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBspeed = new System.Windows.Forms.TextBox();
            this.TBmodel = new System.Windows.Forms.TextBox();
            this.TBbrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GBcontract = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DTPrentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.DTPdeliveryDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBLcost = new System.Windows.Forms.Label();
            this.BTNcalculate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.BTNrent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carsTableAdapter = new RentalCar.RentalCarDataSet1TableAdapters.CarsTableAdapter();
            this.GBcustomer.SuspendLayout();
            this.GBcar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalCarDataSet1)).BeginInit();
            this.GBcontract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBcustomer
            // 
            this.GBcustomer.Controls.Add(this.TBlicenceDate);
            this.GBcustomer.Controls.Add(this.TBmobile);
            this.GBcustomer.Controls.Add(this.TBidSearch);
            this.GBcustomer.Controls.Add(this.TBname);
            this.GBcustomer.Controls.Add(this.label1);
            this.GBcustomer.Controls.Add(this.label4);
            this.GBcustomer.Controls.Add(this.label2);
            this.GBcustomer.Controls.Add(this.label3);
            this.GBcustomer.Location = new System.Drawing.Point(12, 12);
            this.GBcustomer.Name = "GBcustomer";
            this.GBcustomer.Size = new System.Drawing.Size(276, 138);
            this.GBcustomer.TabIndex = 0;
            this.GBcustomer.TabStop = false;
            this.GBcustomer.Text = "Customer";
            // 
            // TBlicenceDate
            // 
            this.TBlicenceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBlicenceDate.Location = new System.Drawing.Point(102, 106);
            this.TBlicenceDate.Name = "TBlicenceDate";
            this.TBlicenceDate.Size = new System.Drawing.Size(168, 22);
            this.TBlicenceDate.TabIndex = 15;
            // 
            // TBmobile
            // 
            this.TBmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmobile.Location = new System.Drawing.Point(102, 78);
            this.TBmobile.Name = "TBmobile";
            this.TBmobile.Size = new System.Drawing.Size(168, 22);
            this.TBmobile.TabIndex = 14;
            // 
            // TBidSearch
            // 
            this.TBidSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBidSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBidSearch.Location = new System.Drawing.Point(102, 20);
            this.TBidSearch.Name = "TBidSearch";
            this.TBidSearch.Size = new System.Drawing.Size(168, 22);
            this.TBidSearch.TabIndex = 7;
            this.TBidSearch.TextChanged += new System.EventHandler(this.TBidSearch_TextChanged);
            // 
            // TBname
            // 
            this.TBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBname.Location = new System.Drawing.Point(102, 50);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(168, 22);
            this.TBname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Licence Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mobile";
            // 
            // GBcar
            // 
            this.GBcar.Controls.Add(this.comboBox1);
            this.GBcar.Controls.Add(this.TBprice);
            this.GBcar.Controls.Add(this.TBfuel);
            this.GBcar.Controls.Add(this.TBcolor);
            this.GBcar.Controls.Add(this.TByear);
            this.GBcar.Controls.Add(this.label9);
            this.GBcar.Controls.Add(this.label10);
            this.GBcar.Controls.Add(this.label11);
            this.GBcar.Controls.Add(this.label12);
            this.GBcar.Controls.Add(this.TBspeed);
            this.GBcar.Controls.Add(this.TBmodel);
            this.GBcar.Controls.Add(this.TBbrand);
            this.GBcar.Controls.Add(this.label5);
            this.GBcar.Controls.Add(this.label6);
            this.GBcar.Controls.Add(this.label7);
            this.GBcar.Controls.Add(this.label8);
            this.GBcar.Location = new System.Drawing.Point(303, 12);
            this.GBcar.Name = "GBcar";
            this.GBcar.Size = new System.Drawing.Size(581, 138);
            this.GBcar.TabIndex = 16;
            this.GBcar.TabStop = false;
            this.GBcar.Text = "Car";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.rentalCarDataSet1;
            // 
            // rentalCarDataSet1
            // 
            this.rentalCarDataSet1.DataSetName = "RentalCarDataSet1";
            this.rentalCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBprice
            // 
            this.TBprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBprice.Location = new System.Drawing.Point(383, 106);
            this.TBprice.Name = "TBprice";
            this.TBprice.Size = new System.Drawing.Size(168, 22);
            this.TBprice.TabIndex = 23;
            // 
            // TBfuel
            // 
            this.TBfuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBfuel.Location = new System.Drawing.Point(383, 78);
            this.TBfuel.Name = "TBfuel";
            this.TBfuel.Size = new System.Drawing.Size(168, 22);
            this.TBfuel.TabIndex = 22;
            // 
            // TBcolor
            // 
            this.TBcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBcolor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TBcolor.Location = new System.Drawing.Point(383, 20);
            this.TBcolor.Name = "TBcolor";
            this.TBcolor.Size = new System.Drawing.Size(168, 22);
            this.TBcolor.TabIndex = 17;
            // 
            // TByear
            // 
            this.TByear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TByear.Location = new System.Drawing.Point(383, 50);
            this.TByear.Name = "TByear";
            this.TByear.Size = new System.Drawing.Size(168, 22);
            this.TByear.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(291, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(291, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(291, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(291, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fuel";
            // 
            // TBspeed
            // 
            this.TBspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBspeed.Location = new System.Drawing.Point(102, 106);
            this.TBspeed.Name = "TBspeed";
            this.TBspeed.Size = new System.Drawing.Size(168, 22);
            this.TBspeed.TabIndex = 15;
            // 
            // TBmodel
            // 
            this.TBmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBmodel.Location = new System.Drawing.Point(102, 78);
            this.TBmodel.Name = "TBmodel";
            this.TBmodel.Size = new System.Drawing.Size(168, 22);
            this.TBmodel.TabIndex = 14;
            // 
            // TBbrand
            // 
            this.TBbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBbrand.Location = new System.Drawing.Point(102, 50);
            this.TBbrand.Name = "TBbrand";
            this.TBbrand.Size = new System.Drawing.Size(168, 22);
            this.TBbrand.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Model";
            // 
            // GBcontract
            // 
            this.GBcontract.Controls.Add(this.dateTimePicker2);
            this.GBcontract.Controls.Add(this.DTPrentDate);
            this.GBcontract.Controls.Add(this.comboBox2);
            this.GBcontract.Controls.Add(this.label16);
            this.GBcontract.Controls.Add(this.label15);
            this.GBcontract.Controls.Add(this.textBox10);
            this.GBcontract.Controls.Add(this.DTPdeliveryDate);
            this.GBcontract.Controls.Add(this.label13);
            this.GBcontract.Location = new System.Drawing.Point(904, 12);
            this.GBcontract.Name = "GBcontract";
            this.GBcontract.Size = new System.Drawing.Size(275, 138);
            this.GBcontract.TabIndex = 17;
            this.GBcontract.TabStop = false;
            this.GBcontract.Text = "Contract";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(98, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // DTPrentDate
            // 
            this.DTPrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPrentDate.Location = new System.Drawing.Point(98, 79);
            this.DTPrentDate.Name = "DTPrentDate";
            this.DTPrentDate.Size = new System.Drawing.Size(168, 22);
            this.DTPrentDate.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBox2.Location = new System.Drawing.Point(98, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Rent Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Price";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox10.Location = new System.Drawing.Point(98, 50);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(168, 22);
            this.textBox10.TabIndex = 28;
            // 
            // DTPdeliveryDate
            // 
            this.DTPdeliveryDate.AutoSize = true;
            this.DTPdeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPdeliveryDate.Location = new System.Drawing.Point(6, 112);
            this.DTPdeliveryDate.Name = "DTPdeliveryDate";
            this.DTPdeliveryDate.Size = new System.Drawing.Size(60, 16);
            this.DTPdeliveryDate.TabIndex = 27;
            this.DTPdeliveryDate.Text = "Delivery ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Period";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1326, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 38);
            this.label14.TabIndex = 19;
            this.label14.Text = "0000";
            // 
            // LBLcost
            // 
            this.LBLcost.AutoSize = true;
            this.LBLcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLcost.Location = new System.Drawing.Point(1269, 24);
            this.LBLcost.Name = "LBLcost";
            this.LBLcost.Size = new System.Drawing.Size(0, 38);
            this.LBLcost.TabIndex = 19;
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(1185, 32);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(84, 52);
            this.BTNcalculate.TabIndex = 20;
            this.BTNcalculate.Text = "Calculate";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1286, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Cost";
            // 
            // BTNrent
            // 
            this.BTNrent.Location = new System.Drawing.Point(1185, 91);
            this.BTNrent.Name = "BTNrent";
            this.BTNrent.Size = new System.Drawing.Size(225, 53);
            this.BTNrent.TabIndex = 34;
            this.BTNrent.Text = "Rent";
            this.BTNrent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1398, 430);
            this.dataGridView1.TabIndex = 35;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNrent);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BTNcalculate);
            this.Controls.Add(this.LBLcost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GBcontract);
            this.Controls.Add(this.GBcar);
            this.Controls.Add(this.GBcustomer);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.GBcustomer.ResumeLayout(false);
            this.GBcustomer.PerformLayout();
            this.GBcar.ResumeLayout(false);
            this.GBcar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalCarDataSet1)).EndInit();
            this.GBcontract.ResumeLayout(false);
            this.GBcontract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBcustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBidSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBlicenceDate;
        private System.Windows.Forms.TextBox TBmobile;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.GroupBox GBcar;
        private System.Windows.Forms.TextBox TBprice;
        private System.Windows.Forms.TextBox TBfuel;
        private System.Windows.Forms.TextBox TBcolor;
        private System.Windows.Forms.TextBox TByear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBspeed;
        private System.Windows.Forms.TextBox TBmodel;
        private System.Windows.Forms.TextBox TBbrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GBcontract;
        private System.Windows.Forms.DateTimePicker DTPrentDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label DTPdeliveryDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBLcost;
        private System.Windows.Forms.Button BTNcalculate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BTNrent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentalCarDataSet1 rentalCarDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private RentalCarDataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
    }
}