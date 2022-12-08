namespace Project_CakeStore.GUI
{
    partial class importProForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importProForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableCake = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.txtPriceAll = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableImport = new System.Windows.Forms.DataGridView();
            this.btnAddOldCake = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtOldQuantity = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtOldPrice = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOldCakeName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOldCateId = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtOldCakeId = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtPricePro = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtEmpName = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmbSuppName = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtImportID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCake)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tableCake);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.groupBox20);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tableImport);
            this.panel1.Controls.Add(this.btnAddOldCake);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 625);
            this.panel1.TabIndex = 0;
            // 
            // tableCake
            // 
            this.tableCake.AllowUserToAddRows = false;
            this.tableCake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCake.Location = new System.Drawing.Point(7, 269);
            this.tableCake.Name = "tableCake";
            this.tableCake.RowHeadersWidth = 51;
            this.tableCake.RowTemplate.Height = 25;
            this.tableCake.Size = new System.Drawing.Size(503, 306);
            this.tableCake.TabIndex = 20;
            this.tableCake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCake_CellClick);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Red;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(707, 581);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(147, 41);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(516, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 41);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.txtPriceAll);
            this.groupBox20.Location = new System.Drawing.Point(707, 514);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(143, 40);
            this.groupBox20.TabIndex = 17;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Tổng tiền";
            // 
            // txtPriceAll
            // 
            this.txtPriceAll.AutoSize = true;
            this.txtPriceAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceAll.Location = new System.Drawing.Point(52, 19);
            this.txtPriceAll.Name = "txtPriceAll";
            this.txtPriceAll.Size = new System.Drawing.Size(17, 17);
            this.txtPriceAll.TabIndex = 0;
            this.txtPriceAll.Text = "...";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(608, 533);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(516, 533);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableImport
            // 
            this.tableImport.AllowUserToAddRows = false;
            this.tableImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableImport.Location = new System.Drawing.Point(516, 251);
            this.tableImport.Name = "tableImport";
            this.tableImport.RowHeadersWidth = 51;
            this.tableImport.RowTemplate.Height = 25;
            this.tableImport.Size = new System.Drawing.Size(339, 250);
            this.tableImport.TabIndex = 14;
            // 
            // btnAddOldCake
            // 
            this.btnAddOldCake.BackColor = System.Drawing.Color.Red;
            this.btnAddOldCake.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddOldCake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOldCake.Location = new System.Drawing.Point(117, 581);
            this.btnAddOldCake.Name = "btnAddOldCake";
            this.btnAddOldCake.Size = new System.Drawing.Size(241, 41);
            this.btnAddOldCake.TabIndex = 12;
            this.btnAddOldCake.Text = "Nhập Hàng";
            this.btnAddOldCake.UseVisualStyleBackColor = false;
            this.btnAddOldCake.Click += new System.EventHandler(this.btnAddOldCake_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 323);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Location = new System.Drawing.Point(4, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 154);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm đã có";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtOldQuantity);
            this.groupBox6.Location = new System.Drawing.Point(279, 77);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 55);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Số lượng";
            // 
            // txtOldQuantity
            // 
            this.txtOldQuantity.Location = new System.Drawing.Point(13, 22);
            this.txtOldQuantity.Name = "txtOldQuantity";
            this.txtOldQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtOldQuantity.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtOldPrice);
            this.groupBox5.Location = new System.Drawing.Point(328, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 47);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Đơn giá";
            // 
            // txtOldPrice
            // 
            this.txtOldPrice.AutoSize = true;
            this.txtOldPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldPrice.Location = new System.Drawing.Point(29, 19);
            this.txtOldPrice.Name = "txtOldPrice";
            this.txtOldPrice.Size = new System.Drawing.Size(17, 17);
            this.txtOldPrice.TabIndex = 1;
            this.txtOldPrice.Text = "...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOldCakeName);
            this.groupBox4.Location = new System.Drawing.Point(169, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 47);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên sản phẩm";
            // 
            // txtOldCakeName
            // 
            this.txtOldCakeName.AutoSize = true;
            this.txtOldCakeName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldCakeName.Location = new System.Drawing.Point(24, 19);
            this.txtOldCakeName.Name = "txtOldCakeName";
            this.txtOldCakeName.Size = new System.Drawing.Size(17, 17);
            this.txtOldCakeName.TabIndex = 1;
            this.txtOldCakeName.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOldCateId);
            this.groupBox3.Location = new System.Drawing.Point(78, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại sản phẩm";
            // 
            // txtOldCateId
            // 
            this.txtOldCateId.AutoSize = true;
            this.txtOldCateId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldCateId.Location = new System.Drawing.Point(29, 19);
            this.txtOldCateId.Name = "txtOldCateId";
            this.txtOldCateId.Size = new System.Drawing.Size(17, 17);
            this.txtOldCateId.TabIndex = 1;
            this.txtOldCateId.Text = "...";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtOldCakeId);
            this.groupBox13.Location = new System.Drawing.Point(6, 24);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(143, 46);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mã sản phẩm";
            // 
            // txtOldCakeId
            // 
            this.txtOldCakeId.AutoSize = true;
            this.txtOldCakeId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldCakeId.Location = new System.Drawing.Point(24, 19);
            this.txtOldCakeId.Name = "txtOldCakeId";
            this.txtOldCakeId.Size = new System.Drawing.Size(17, 17);
            this.txtOldCakeId.TabIndex = 1;
            this.txtOldCakeId.Text = "...";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(519, 70);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(333, 175);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtPricePro);
            this.groupBox12.Location = new System.Drawing.Point(100, 129);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(143, 40);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Tổng tiền";
            // 
            // txtPricePro
            // 
            this.txtPricePro.AutoSize = true;
            this.txtPricePro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPricePro.Location = new System.Drawing.Point(32, 19);
            this.txtPricePro.Name = "txtPricePro";
            this.txtPricePro.Size = new System.Drawing.Size(17, 17);
            this.txtPricePro.TabIndex = 0;
            this.txtPricePro.Text = "...";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtDate);
            this.groupBox11.Location = new System.Drawing.Point(174, 70);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(143, 47);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ngày lập ";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(34, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(17, 17);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "...";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtEmpName);
            this.groupBox10.Location = new System.Drawing.Point(6, 70);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(143, 47);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nhân Viên";
            // 
            // txtEmpName
            // 
            this.txtEmpName.AutoSize = true;
            this.txtEmpName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpName.Location = new System.Drawing.Point(31, 19);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(17, 17);
            this.txtEmpName.TabIndex = 0;
            this.txtEmpName.Text = "...";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmbSuppName);
            this.groupBox9.Location = new System.Drawing.Point(174, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(143, 52);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Nhà cung cấp";
            // 
            // cmbSuppName
            // 
            this.cmbSuppName.FormattingEnabled = true;
            this.cmbSuppName.Location = new System.Drawing.Point(12, 19);
            this.cmbSuppName.Name = "cmbSuppName";
            this.cmbSuppName.Size = new System.Drawing.Size(121, 23);
            this.cmbSuppName.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtImportID);
            this.groupBox8.Location = new System.Drawing.Point(6, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(143, 52);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mã phiếu nhập";
            // 
            // txtImportID
            // 
            this.txtImportID.Location = new System.Drawing.Point(18, 22);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.Size = new System.Drawing.Size(100, 23);
            this.txtImportID.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtAccName);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 64);
            this.panel2.TabIndex = 2;
            // 
            // txtAccName
            // 
            this.txtAccName.AutoSize = true;
            this.txtAccName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccName.Location = new System.Drawing.Point(13, 18);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(128, 26);
            this.txtAccName.TabIndex = 2;
            this.txtAccName.Text = "Acc Name";
            // 
            // picExit
            // 
            this.picExit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.picExit.Location = new System.Drawing.Point(813, 12);
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
            this.ABC.Location = new System.Drawing.Point(356, 18);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(171, 32);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // importProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 625);
            this.Controls.Add(this.panel1);
            this.Name = "importProForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "importProForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCake)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label txtAccName;
        private PictureBox picExit;
        private Label label1;
        private Label ABC;
        private GroupBox groupBox7;
        private GroupBox groupBox12;
        private Label txtPricePro;
        private GroupBox groupBox11;
        private Label txtDate;
        private GroupBox groupBox10;
        private Label txtEmpName;
        private GroupBox groupBox9;
        private ComboBox cmbSuppName;
        private GroupBox groupBox8;
        private TextBox txtImportID;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private TextBox txtOldQuantity;
        private GroupBox groupBox5;
        private Label txtOldPrice;
        private GroupBox groupBox4;
        private Label txtOldCakeName;
        private GroupBox groupBox3;
        private Label txtOldCateId;
        private GroupBox groupBox13;
        private Button btnAddOldCake;
        private DataGridView tableImport;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox20;
        private Label txtPriceAll;
        private Button btnCancel;
        private Button btnPay;
        private DataGridView tableCake;
        private Label txtOldCakeId;
    }
}