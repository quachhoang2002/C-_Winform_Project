namespace Project_CakeStore.GUI
{
    partial class accountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.txtAccName1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportEcel = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableAccount = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAccName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAccount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.txtAccName1);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 64);
            this.panel2.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.exit.Location = new System.Drawing.Point(854, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 38);
            this.exit.TabIndex = 24;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtAccName1
            // 
            this.txtAccName1.AutoSize = true;
            this.txtAccName1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccName1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccName1.Location = new System.Drawing.Point(13, 18);
            this.txtAccName1.Name = "txtAccName1";
            this.txtAccName1.Size = new System.Drawing.Size(128, 26);
            this.txtAccName1.TabIndex = 2;
            this.txtAccName1.Text = "Acc Name";
            // 
            // picExit
            // 
            this.picExit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.picExit.Location = new System.Drawing.Point(976, 16);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(36, 38);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
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
            this.ABC.Location = new System.Drawing.Point(381, 18);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(171, 32);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportEcel);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.tableAccount);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(9, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 328);
            this.panel1.TabIndex = 3;
            // 
            // btnExportEcel
            // 
            this.btnExportEcel.BackColor = System.Drawing.Color.Red;
            this.btnExportEcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportEcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportEcel.Location = new System.Drawing.Point(678, 271);
            this.btnExportEcel.Name = "btnExportEcel";
            this.btnExportEcel.Size = new System.Drawing.Size(105, 41);
            this.btnExportEcel.TabIndex = 25;
            this.btnExportEcel.Text = "Xuất Excel";
            this.btnExportEcel.UseVisualStyleBackColor = false;
            this.btnExportEcel.Click += new System.EventHandler(this.btnExportEcel_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox14);
            this.panel11.Controls.Add(this.btnSearch);
            this.panel11.Location = new System.Drawing.Point(473, 118);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(410, 140);
            this.panel11.TabIndex = 5;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.groupBox18);
            this.groupBox14.Location = new System.Drawing.Point(12, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(357, 74);
            this.groupBox14.TabIndex = 12;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Tìm kiếm";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtContent);
            this.groupBox17.Location = new System.Drawing.Point(194, 21);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(143, 46);
            this.groupBox17.TabIndex = 2;
            this.groupBox17.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(24, 18);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(100, 23);
            this.txtContent.TabIndex = 1;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.cmbTypeSearch);
            this.groupBox18.Location = new System.Drawing.Point(9, 18);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(145, 50);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(11, 16);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(121, 23);
            this.cmbTypeSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(12, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 40);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(562, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cmbEmpID);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(481, 46);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(366, 32);
            this.panel10.TabIndex = 4;
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(136, 8);
            this.cmbEmpID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(135, 23);
            this.cmbEmpID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhân viên:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmbPermission);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(481, 11);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(366, 32);
            this.panel9.TabIndex = 3;
            // 
            // cmbPermission
            // 
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Location = new System.Drawing.Point(81, 8);
            this.cmbPermission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(133, 23);
            this.cmbPermission.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quyền:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtAccID);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(7, 11);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(449, 32);
            this.panel8.TabIndex = 2;
            // 
            // txtAccID
            // 
            this.txtAccID.Enabled = false;
            this.txtAccID.Location = new System.Drawing.Point(46, 8);
            this.txtAccID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(300, 23);
            this.txtAccID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // tableAccount
            // 
            this.tableAccount.AllowUserToAddRows = false;
            this.tableAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAccount.Location = new System.Drawing.Point(7, 118);
            this.tableAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAccount.Name = "tableAccount";
            this.tableAccount.RowHeadersWidth = 62;
            this.tableAccount.RowTemplate.Height = 33;
            this.tableAccount.Size = new System.Drawing.Size(449, 201);
            this.tableAccount.TabIndex = 3;
            this.tableAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableAccount_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(7, 82);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 32);
            this.panel5.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(102, 7);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(300, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAccName2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(7, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 32);
            this.panel4.TabIndex = 1;
            // 
            // txtAccName2
            // 
            this.txtAccName2.Location = new System.Drawing.Point(135, 8);
            this.txtAccName2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAccName2.Name = "txtAccName2";
            this.txtAccName2.Size = new System.Drawing.Size(300, 23);
            this.txtAccName2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản:";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteAccount.Location = new System.Drawing.Point(376, 421);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(88, 40);
            this.btnDeleteAccount.TabIndex = 23;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.BackColor = System.Drawing.Color.Red;
            this.btnChangeAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeAccount.Location = new System.Drawing.Point(188, 421);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(88, 40);
            this.btnChangeAccount.TabIndex = 22;
            this.btnChangeAccount.Text = "Sửa";
            this.btnChangeAccount.UseVisualStyleBackColor = false;
            this.btnChangeAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Red;
            this.btnAddAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAccount.Location = new System.Drawing.Point(16, 421);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(88, 40);
            this.btnAddAccount.TabIndex = 21;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(913, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnChangeAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "accountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableAccount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label txtAccName1;
        private PictureBox picExit;
        private Label label1;
        private Label ABC;
        private Panel panel1;
        private Panel panel5;
        private TextBox txtPass;
        private Label label3;
        private Panel panel4;
        private TextBox txtAccName2;
        private Label label2;
        private DataGridView tableAccount;
        private Panel panel8;
        private TextBox txtAccID;
        private Label label6;
        private Panel panel9;
        private Label label7;
        private GroupBox groupBox14;
        private GroupBox groupBox17;
        private TextBox txtContent;
        private GroupBox groupBox18;
        private ComboBox cmbTypeSearch;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDeleteAccount;
        private Button btnChangeAccount;
        private Button btnAddAccount;
        private Panel panel10;
        private ComboBox cmbEmpID;
        private Label label8;
        private Panel panel11;
        private ComboBox cmbPermission;
        private Button btnExportEcel;
        private PictureBox exit;
    }
}