namespace Project_CakeStore.GUI
{
    partial class importForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportEcel = new System.Windows.Forms.Button();
            this.tableImport = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableImport)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnExportEcel);
            this.panel1.Controls.Add(this.tableImport);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.groupBox14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnExportEcel
            // 
            this.btnExportEcel.BackColor = System.Drawing.Color.Red;
            this.btnExportEcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportEcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportEcel.Location = new System.Drawing.Point(727, 131);
            this.btnExportEcel.Name = "btnExportEcel";
            this.btnExportEcel.Size = new System.Drawing.Size(105, 41);
            this.btnExportEcel.TabIndex = 26;
            this.btnExportEcel.Text = "Xuất Excel";
            this.btnExportEcel.UseVisualStyleBackColor = false;
            this.btnExportEcel.Click += new System.EventHandler(this.btnExportEcel_Click);
            // 
            // tableImport
            // 
            this.tableImport.AllowUserToAddRows = false;
            this.tableImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableImport.Location = new System.Drawing.Point(31, 178);
            this.tableImport.Name = "tableImport";
            this.tableImport.RowHeadersWidth = 51;
            this.tableImport.RowTemplate.Height = 25;
            this.tableImport.Size = new System.Drawing.Size(801, 333);
            this.tableImport.TabIndex = 20;
            this.tableImport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableImport_CellDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(581, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 41);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(581, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 41);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.groupBox17);
            this.groupBox14.Controls.Add(this.groupBox18);
            this.groupBox14.Location = new System.Drawing.Point(218, 70);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(357, 102);
            this.groupBox14.TabIndex = 12;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Tìm kiếm";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtAccName);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 64);
            this.panel2.TabIndex = 4;
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
            // importForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 527);
            this.Controls.Add(this.panel1);
            this.Name = "importForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showImportDetailForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableImport)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
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
        private GroupBox groupBox14;
        private GroupBox groupBox17;
        private TextBox txtContent;
        private GroupBox groupBox18;
        private ComboBox cmbTypeSearch;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView tableImport;
        private Button btnExportEcel;
    }
}