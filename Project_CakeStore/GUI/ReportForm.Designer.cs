namespace Project_CakeStore.GUI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.total = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTotalManufactor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtTotalOrder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtTotalCustomer = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtTotalCake = new System.Windows.Forms.Label();
            this.cake = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalEmployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.import = new System.Windows.Forms.TabPage();
            this.tableImportReport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImportDateFormat = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.exportExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.sell = new System.Windows.Forms.TabPage();
            this.tableSellReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sellCbxDateFormat = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.exportExcelSell = new System.Windows.Forms.Button();
            this.dtpEndSell = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSell = new System.Windows.Forms.DateTimePicker();
            this.btnSellSearch = new System.Windows.Forms.Button();
            this.cbxSellSearch = new System.Windows.Forms.ComboBox();
            this.sellSearch = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.total.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImportReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSellReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtAccName);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 64);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtAccName
            // 
            this.txtAccName.AutoSize = true;
            this.txtAccName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccName.Location = new System.Drawing.Point(13, 15);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(128, 26);
            this.txtAccName.TabIndex = 2;
            this.txtAccName.Text = "Acc Name";
            // 
            // picExit
            // 
            this.picExit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.picExit.Location = new System.Drawing.Point(945, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(36, 38);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // ABC
            // 
            this.ABC.AutoSize = true;
            this.ABC.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ABC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ABC.Location = new System.Drawing.Point(438, 18);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(171, 32);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.total);
            this.tabControl1.Controls.Add(this.import);
            this.tabControl1.Controls.Add(this.sell);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 596);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Controls.Add(this.panel6);
            this.total.Controls.Add(this.panel4);
            this.total.Controls.Add(this.panel3);
            this.total.Controls.Add(this.panel5);
            this.total.Controls.Add(this.panel1);
            this.total.ImageIndex = 0;
            this.total.Location = new System.Drawing.Point(4, 24);
            this.total.Name = "total";
            this.total.Padding = new System.Windows.Forms.Padding(3);
            this.total.Size = new System.Drawing.Size(1012, 568);
            this.total.TabIndex = 0;
            this.total.Text = "Tổng";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.txtTotalManufactor);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(755, 289);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 123);
            this.panel6.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_CakeStore.Properties.Resources.food_truck_36px;
            this.pictureBox2.Location = new System.Drawing.Point(12, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtTotalManufactor
            // 
            this.txtTotalManufactor.AutoSize = true;
            this.txtTotalManufactor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalManufactor.Location = new System.Drawing.Point(118, 74);
            this.txtTotalManufactor.Name = "txtTotalManufactor";
            this.txtTotalManufactor.Size = new System.Drawing.Size(22, 25);
            this.txtTotalManufactor.TabIndex = 2;
            this.txtTotalManufactor.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(77, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nhà Cung Cấp";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txtTotalOrder);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(419, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 123);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_CakeStore.Properties.Resources.purchase_order_36px;
            this.pictureBox4.Location = new System.Drawing.Point(12, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.AutoSize = true;
            this.txtTotalOrder.Location = new System.Drawing.Point(131, 74);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(22, 25);
            this.txtTotalOrder.TabIndex = 2;
            this.txtTotalOrder.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(102, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn Hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.txtTotalCustomer);
            this.panel3.Controls.Add(this.customer);
            this.panel3.Location = new System.Drawing.Point(755, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 123);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_CakeStore.Properties.Resources.customer_36px;
            this.pictureBox3.Location = new System.Drawing.Point(12, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.AutoSize = true;
            this.txtTotalCustomer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCustomer.Location = new System.Drawing.Point(129, 74);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.Size = new System.Drawing.Size(22, 25);
            this.txtTotalCustomer.TabIndex = 2;
            this.txtTotalCustomer.Text = "0";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.customer.Location = new System.Drawing.Point(95, 18);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(105, 19);
            this.customer.TabIndex = 1;
            this.customer.Text = "Khách Hàng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.txtTotalCake);
            this.panel5.Controls.Add(this.cake);
            this.panel5.Location = new System.Drawing.Point(78, 289);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 123);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_CakeStore.Properties.Resources.cake_36px;
            this.pictureBox5.Location = new System.Drawing.Point(14, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // txtTotalCake
            // 
            this.txtTotalCake.AutoSize = true;
            this.txtTotalCake.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCake.Location = new System.Drawing.Point(125, 74);
            this.txtTotalCake.Name = "txtTotalCake";
            this.txtTotalCake.Size = new System.Drawing.Size(22, 25);
            this.txtTotalCake.TabIndex = 2;
            this.txtTotalCake.Text = "0";
            // 
            // cake
            // 
            this.cake.AutoSize = true;
            this.cake.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cake.Location = new System.Drawing.Point(116, 22);
            this.cake.Name = "cake";
            this.cake.Size = new System.Drawing.Size(50, 19);
            this.cake.TabIndex = 1;
            this.cake.Text = "Bánh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtTotalEmployee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(78, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 123);
            this.panel1.TabIndex = 0;
            // 
            // txtTotalEmployee
            // 
            this.txtTotalEmployee.AutoSize = true;
            this.txtTotalEmployee.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEmployee.Location = new System.Drawing.Point(125, 74);
            this.txtTotalEmployee.Name = "txtTotalEmployee";
            this.txtTotalEmployee.Size = new System.Drawing.Size(22, 25);
            this.txtTotalEmployee.TabIndex = 2;
            this.txtTotalEmployee.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_CakeStore.Properties.Resources.member_36px;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // import
            // 
            this.import.Controls.Add(this.tableImportReport);
            this.import.Controls.Add(this.groupBox2);
            this.import.ImageIndex = 1;
            this.import.Location = new System.Drawing.Point(4, 24);
            this.import.Name = "import";
            this.import.Padding = new System.Windows.Forms.Padding(3);
            this.import.Size = new System.Drawing.Size(1012, 568);
            this.import.TabIndex = 1;
            this.import.Text = "Nhập Hàng";
            this.import.UseVisualStyleBackColor = true;
            // 
            // tableImportReport
            // 
            this.tableImportReport.AllowUserToAddRows = false;
            this.tableImportReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableImportReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableImportReport.Location = new System.Drawing.Point(-4, 112);
            this.tableImportReport.Name = "tableImportReport";
            this.tableImportReport.RowTemplate.Height = 25;
            this.tableImportReport.Size = new System.Drawing.Size(1020, 456);
            this.tableImportReport.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImportDateFormat);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.exportExcel);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbxSearch);
            this.groupBox2.Controls.Add(this.searchValue);
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1014, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // ImportDateFormat
            // 
            this.ImportDateFormat.FormattingEnabled = true;
            this.ImportDateFormat.Location = new System.Drawing.Point(695, 20);
            this.ImportDateFormat.Margin = new System.Windows.Forms.Padding(2);
            this.ImportDateFormat.Name = "ImportDateFormat";
            this.ImportDateFormat.Size = new System.Drawing.Size(57, 23);
            this.ImportDateFormat.TabIndex = 14;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Project_CakeStore.Properties.Resources.refresh;
            this.pictureBox6.Location = new System.Drawing.Point(757, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // exportExcel
            // 
            this.exportExcel.BackColor = System.Drawing.Color.Red;
            this.exportExcel.ForeColor = System.Drawing.Color.White;
            this.exportExcel.Location = new System.Drawing.Point(868, 57);
            this.exportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(106, 35);
            this.exportExcel.TabIndex = 12;
            this.exportExcel.Text = "Xuat Excel";
            this.exportExcel.UseVisualStyleBackColor = false;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(995, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(363, 61);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 23);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.Value = new System.DateTime(2022, 11, 11, 13, 10, 16, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(126, 61);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 23);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.Value = new System.DateTime(2022, 1, 1, 15, 31, 0, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(598, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(126, 20);
            this.cbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(105, 23);
            this.cbxSearch.TabIndex = 6;
            // 
            // searchValue
            // 
            this.searchValue.Location = new System.Drawing.Point(255, 20);
            this.searchValue.Margin = new System.Windows.Forms.Padding(2);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(436, 23);
            this.searchValue.TabIndex = 7;
            // 
            // sell
            // 
            this.sell.Controls.Add(this.tableSellReport);
            this.sell.Controls.Add(this.groupBox1);
            this.sell.ImageIndex = 2;
            this.sell.Location = new System.Drawing.Point(4, 24);
            this.sell.Name = "sell";
            this.sell.Padding = new System.Windows.Forms.Padding(3);
            this.sell.Size = new System.Drawing.Size(1012, 568);
            this.sell.TabIndex = 2;
            this.sell.Text = "Bán Hàng";
            this.sell.UseVisualStyleBackColor = true;
            // 
            // tableSellReport
            // 
            this.tableSellReport.AllowUserToAddRows = false;
            this.tableSellReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSellReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSellReport.Location = new System.Drawing.Point(-1, 112);
            this.tableSellReport.Name = "tableSellReport";
            this.tableSellReport.RowTemplate.Height = 25;
            this.tableSellReport.Size = new System.Drawing.Size(1020, 456);
            this.tableSellReport.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellCbxDateFormat);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.exportExcelSell);
            this.groupBox1.Controls.Add(this.dtpEndSell);
            this.groupBox1.Controls.Add(this.dtpStartSell);
            this.groupBox1.Controls.Add(this.btnSellSearch);
            this.groupBox1.Controls.Add(this.cbxSellSearch);
            this.groupBox1.Controls.Add(this.sellSearch);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1014, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // sellCbxDateFormat
            // 
            this.sellCbxDateFormat.FormattingEnabled = true;
            this.sellCbxDateFormat.Location = new System.Drawing.Point(699, 20);
            this.sellCbxDateFormat.Margin = new System.Windows.Forms.Padding(2);
            this.sellCbxDateFormat.Name = "sellCbxDateFormat";
            this.sellCbxDateFormat.Size = new System.Drawing.Size(57, 23);
            this.sellCbxDateFormat.TabIndex = 15;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Project_CakeStore.Properties.Resources.refresh;
            this.pictureBox7.Location = new System.Drawing.Point(761, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // exportExcelSell
            // 
            this.exportExcelSell.BackColor = System.Drawing.Color.Red;
            this.exportExcelSell.ForeColor = System.Drawing.Color.White;
            this.exportExcelSell.Location = new System.Drawing.Point(870, 61);
            this.exportExcelSell.Margin = new System.Windows.Forms.Padding(2);
            this.exportExcelSell.Name = "exportExcelSell";
            this.exportExcelSell.Size = new System.Drawing.Size(106, 32);
            this.exportExcelSell.TabIndex = 13;
            this.exportExcelSell.Text = "Xuat Excel";
            this.exportExcelSell.UseVisualStyleBackColor = false;
            this.exportExcelSell.Click += new System.EventHandler(this.exportExcelSell_Click);
            // 
            // dtpEndSell
            // 
            this.dtpEndSell.Location = new System.Drawing.Point(358, 64);
            this.dtpEndSell.Name = "dtpEndSell";
            this.dtpEndSell.Size = new System.Drawing.Size(200, 23);
            this.dtpEndSell.TabIndex = 10;
            // 
            // dtpStartSell
            // 
            this.dtpStartSell.Location = new System.Drawing.Point(132, 64);
            this.dtpStartSell.Name = "dtpStartSell";
            this.dtpStartSell.Size = new System.Drawing.Size(200, 23);
            this.dtpStartSell.TabIndex = 9;
            this.dtpStartSell.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // btnSellSearch
            // 
            this.btnSellSearch.BackColor = System.Drawing.Color.Red;
            this.btnSellSearch.ForeColor = System.Drawing.Color.White;
            this.btnSellSearch.Location = new System.Drawing.Point(602, 61);
            this.btnSellSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSellSearch.Name = "btnSellSearch";
            this.btnSellSearch.Size = new System.Drawing.Size(170, 32);
            this.btnSellSearch.TabIndex = 8;
            this.btnSellSearch.Text = "Tìm Kiếm";
            this.btnSellSearch.UseVisualStyleBackColor = false;
            this.btnSellSearch.Click += new System.EventHandler(this.btnSellSearch_Click);
            // 
            // cbxSellSearch
            // 
            this.cbxSellSearch.FormattingEnabled = true;
            this.cbxSellSearch.Location = new System.Drawing.Point(132, 20);
            this.cbxSellSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSellSearch.Name = "cbxSellSearch";
            this.cbxSellSearch.Size = new System.Drawing.Size(105, 23);
            this.cbxSellSearch.TabIndex = 6;
            // 
            // sellSearch
            // 
            this.sellSearch.Location = new System.Drawing.Point(268, 20);
            this.sellSearch.Margin = new System.Windows.Forms.Padding(2);
            this.sellSearch.Name = "sellSearch";
            this.sellSearch.Size = new System.Drawing.Size(427, 23);
            this.sellSearch.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coins-icon.png");
            this.imageList1.Images.SetKeyName(1, "Shoppingcart-03-arrow-down-icon.png");
            this.imageList1.Images.SetKeyName(2, "cash-icon.png");
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 666);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.total.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableImportReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableSellReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label txtAccName;
        private PictureBox picExit;
        private Label label1;
        private Label ABC;
        private TabControl tabControl1;
        private TabPage total;
        private TabPage import;
        private TabPage sell;
        private Panel panel6;
        private Label txtTotalManufactor;
        private Label label11;
        private Panel panel3;
        private Label txtTotalCustomer;
        private Label customer;
        private Panel panel5;
        private Label txtTotalCake;
        private Label cake;
        private Panel panel1;
        private Label txtTotalEmployee;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox searchValue;
        private GroupBox groupBox1;
        private DateTimePicker dtpEndSell;
        private DateTimePicker dtpStartSell;
        private Button btnSellSearch;
        private ComboBox cbxSellSearch;
        private TextBox sellSearch;
        private ImageList imageList1;
        private BindingSource bindingSource1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label txtTotalOrder;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private DataGridView tableImportReport;
        private DataGridView dataGridView1;
        private Button exportExcel;
        private DataGridView tableSellReport;
        private Button exportExcelSell;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private ComboBox ImportDateFormat;
        private ComboBox sellCbxDateFormat;
    }
}