namespace Project_CakeStore.GUI
{
    partial class customerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNewestCusID = new System.Windows.Forms.Label();
            this.dtDayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbxCusSex = new System.Windows.Forms.ComboBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtAccName);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.picLogOut);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 92);
            this.panel2.TabIndex = 5;
            // 
            // txtAccName
            // 
            this.txtAccName.AutoSize = true;
            this.txtAccName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccName.Location = new System.Drawing.Point(46, 24);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(156, 32);
            this.txtAccName.TabIndex = 2;
            this.txtAccName.Text = "Acc Name";
            // 
            // picExit
            // 
            this.picExit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.picExit.Location = new System.Drawing.Point(929, 16);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(41, 50);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            // 
            // picLogOut
            // 
            this.picLogOut.Image = global::Project_CakeStore.Properties.Resources.Logout_36px;
            this.picLogOut.Location = new System.Drawing.Point(3, 16);
            this.picLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(35, 50);
            this.picLogOut.TabIndex = 2;
            this.picLogOut.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // ABC
            // 
            this.ABC.AutoSize = true;
            this.ABC.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ABC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ABC.Location = new System.Drawing.Point(407, 24);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(214, 40);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dtDayOfBirth);
            this.groupBox1.Controls.Add(this.cbxCusSex);
            this.groupBox1.Controls.Add(this.txtCusAddress);
            this.groupBox1.Controls.Add(this.txtCusPhone);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(591, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNewestCusID);
            this.groupBox4.Location = new System.Drawing.Point(6, 160);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(239, 43);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã KH mới nhất";
            // 
            // txtNewestCusID
            // 
            this.txtNewestCusID.AutoSize = true;
            this.txtNewestCusID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewestCusID.Location = new System.Drawing.Point(6, 22);
            this.txtNewestCusID.Name = "txtNewestCusID";
            this.txtNewestCusID.Size = new System.Drawing.Size(21, 20);
            this.txtNewestCusID.TabIndex = 2;
            this.txtNewestCusID.Text = "...";
            // 
            // dtDayOfBirth
            // 
            this.dtDayOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDayOfBirth.Location = new System.Drawing.Point(81, 110);
            this.dtDayOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtDayOfBirth.Name = "dtDayOfBirth";
            this.dtDayOfBirth.Size = new System.Drawing.Size(165, 27);
            this.dtDayOfBirth.TabIndex = 12;
            // 
            // cbxCusSex
            // 
            this.cbxCusSex.FormattingEnabled = true;
            this.cbxCusSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxCusSex.Location = new System.Drawing.Point(371, 74);
            this.cbxCusSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCusSex.Name = "cbxCusSex";
            this.cbxCusSex.Size = new System.Drawing.Size(165, 28);
            this.cbxCusSex.TabIndex = 11;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(371, 114);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(165, 74);
            this.txtCusAddress.TabIndex = 9;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(370, 38);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(165, 27);
            this.txtCusPhone.TabIndex = 8;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(81, 74);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(165, 27);
            this.txtCusName.TabIndex = 7;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(81, 34);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(165, 27);
            this.txtCusID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điện Thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "DoB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH:";
            // 
            // tableCustomer
            // 
            this.tableCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomer.Location = new System.Drawing.Point(9, 326);
            this.tableCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tableCustomer.Name = "tableCustomer";
            this.tableCustomer.RowHeadersWidth = 62;
            this.tableCustomer.RowTemplate.Height = 33;
            this.tableCustomer.Size = new System.Drawing.Size(591, 330);
            this.tableCustomer.TabIndex = 8;
            this.tableCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCustomer_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.cbxSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(641, 118);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(328, 198);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(14, 104);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(301, 42);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Location = new System.Drawing.Point(14, 64);
            this.cbxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(119, 28);
            this.cbxSearch.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 64);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 27);
            this.txtSearch.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(641, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(328, 330);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(177, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xuất Excel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nhập Excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(177, 134);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 50);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(14, 134);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(177, 30);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "customerForm";
            this.Text = "customerForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label txtAccName;
        private PictureBox picExit;
        private PictureBox picLogOut;
        private Label label1;
        private Label ABC;
        private GroupBox groupBox1;
        private ComboBox cbxCusSex;
        private TextBox txtCusAddress;
        private TextBox txtCusPhone;
        private TextBox txtCusName;
        private TextBox txtCusID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView tableCustomer;
        private GroupBox groupBox3;
        private Button btnSearch;
        private ComboBox cbxSearch;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button btnReset;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DateTimePicker dtDayOfBirth;
        private GroupBox groupBox4;
        private Label txtNewestCusID;
    }
}