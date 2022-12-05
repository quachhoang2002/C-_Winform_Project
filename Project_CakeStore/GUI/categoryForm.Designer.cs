namespace Project_CakeStore.GUI
{
    partial class categoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExportEcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCateID = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.tableCate = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCate)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox14);
            this.panel1.Controls.Add(this.tableCate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 528);
            this.panel1.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnExportEcel);
            this.groupBox7.Controls.Add(this.btnImportExcel);
            this.groupBox7.Controls.Add(this.btnClear);
            this.groupBox7.Controls.Add(this.btnEdit);
            this.groupBox7.Controls.Add(this.btnDelete);
            this.groupBox7.Controls.Add(this.btnAdd);
            this.groupBox7.Location = new System.Drawing.Point(521, 255);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(357, 259);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thao tác";
            // 
            // btnExportEcel
            // 
            this.btnExportEcel.BackColor = System.Drawing.Color.Red;
            this.btnExportEcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportEcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportEcel.Location = new System.Drawing.Point(224, 173);
            this.btnExportEcel.Name = "btnExportEcel";
            this.btnExportEcel.Size = new System.Drawing.Size(105, 41);
            this.btnExportEcel.TabIndex = 15;
            this.btnExportEcel.Text = "Xuất Excel";
            this.btnExportEcel.UseVisualStyleBackColor = false;
            this.btnExportEcel.Click += new System.EventHandler(this.btnExportEcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.Red;
            this.btnImportExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportExcel.Location = new System.Drawing.Point(31, 173);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(108, 41);
            this.btnImportExcel.TabIndex = 14;
            this.btnImportExcel.Text = "Nhập Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(224, 103);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 41);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(31, 103);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 41);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(224, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(31, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 41);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin danh mục";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCateName);
            this.groupBox4.Location = new System.Drawing.Point(288, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 53);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên danh mục";
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(24, 18);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(100, 23);
            this.txtCateName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCateID);
            this.groupBox2.Location = new System.Drawing.Point(37, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã danh mục";
            // 
            // txtCateID
            // 
            this.txtCateID.AutoSize = true;
            this.txtCateID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCateID.Location = new System.Drawing.Point(24, 23);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(17, 17);
            this.txtCateID.TabIndex = 0;
            this.txtCateID.Text = "...";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnSearch);
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.groupBox18);
            this.groupBox14.Location = new System.Drawing.Point(521, 73);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(357, 167);
            this.groupBox14.TabIndex = 13;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(133, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 41);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtContent);
            this.groupBox17.Location = new System.Drawing.Point(186, 34);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(143, 47);
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
            this.groupBox18.Location = new System.Drawing.Point(20, 31);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(145, 50);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(11, 17);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(121, 23);
            this.cmbTypeSearch.TabIndex = 1;
            // 
            // tableCate
            // 
            this.tableCate.AllowUserToAddRows = false;
            this.tableCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCate.Location = new System.Drawing.Point(3, 255);
            this.tableCate.Name = "tableCate";
            this.tableCate.RowHeadersWidth = 51;
            this.tableCate.RowTemplate.Height = 25;
            this.tableCate.Size = new System.Drawing.Size(487, 270);
            this.tableCate.TabIndex = 4;
            this.tableCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCate_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtAccName);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.picLogOut);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 64);
            this.panel2.TabIndex = 3;
            // 
            // txtAccName
            // 
            this.txtAccName.AutoSize = true;
            this.txtAccName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAccName.Location = new System.Drawing.Point(40, 18);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(128, 26);
            this.txtAccName.TabIndex = 2;
            this.txtAccName.Text = "Acc Name";
            // 
            // picExit
            // 
            this.picExit.Image = global::Project_CakeStore.Properties.Resources.chain_start_36px;
            this.picExit.Location = new System.Drawing.Point(848, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(36, 38);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picLogOut
            // 
            this.picLogOut.Image = global::Project_CakeStore.Properties.Resources.Logout_36px;
            this.picLogOut.Location = new System.Drawing.Point(3, 12);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(31, 38);
            this.picLogOut.TabIndex = 2;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
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
            this.ABC.Location = new System.Drawing.Point(366, 18);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(171, 32);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 529);
            this.Controls.Add(this.panel1);
            this.Name = "categoryForm";
            this.Text = "categoryForm";
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox7;
        private Button btnExportEcel;
        private Button btnImportExcel;
        private Button btnClear;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private TextBox txtCateName;
        private GroupBox groupBox2;
        private Label txtCateID;
        private GroupBox groupBox14;
        private Button btnSearch;
        private GroupBox groupBox17;
        private TextBox txtContent;
        private GroupBox groupBox18;
        private ComboBox cmbTypeSearch;
        private DataGridView tableCate;
        private Panel panel2;
        private Label txtAccName;
        private PictureBox picExit;
        private PictureBox picLogOut;
        private Label label1;
        private Label ABC;
    }
}