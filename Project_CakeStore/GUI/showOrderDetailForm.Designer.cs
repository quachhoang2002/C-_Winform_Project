namespace Project_CakeStore.GUI
{
    partial class showOrderDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showOrderDetailForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccName = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableShowInfo = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrderId = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableShowInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 64);
            this.panel2.TabIndex = 4;
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
            this.picExit.Location = new System.Drawing.Point(813, 12);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tableShowInfo);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 393);
            this.panel1.TabIndex = 5;
            // 
            // tableShowInfo
            // 
            this.tableShowInfo.AllowUserToAddRows = false;
            this.tableShowInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableShowInfo.Location = new System.Drawing.Point(26, 71);
            this.tableShowInfo.Name = "tableShowInfo";
            this.tableShowInfo.RowTemplate.Height = 25;
            this.tableShowInfo.Size = new System.Drawing.Size(800, 273);
            this.tableShowInfo.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDate);
            this.groupBox4.Location = new System.Drawing.Point(651, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 51);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ngày lập hóa đơn";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(41, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(17, 17);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmp);
            this.groupBox3.Location = new System.Drawing.Point(440, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhân viên lập hóa đơn";
            // 
            // txtEmp
            // 
            this.txtEmp.AutoSize = true;
            this.txtEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmp.Location = new System.Drawing.Point(41, 19);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(17, 17);
            this.txtEmp.TabIndex = 1;
            this.txtEmp.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCus);
            this.groupBox2.Location = new System.Drawing.Point(233, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách hàng";
            // 
            // txtCus
            // 
            this.txtCus.AutoSize = true;
            this.txtCus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCus.Location = new System.Drawing.Point(41, 19);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(17, 17);
            this.txtCus.TabIndex = 1;
            this.txtCus.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa đơn";
            // 
            // txtOrderId
            // 
            this.txtOrderId.AutoSize = true;
            this.txtOrderId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderId.Location = new System.Drawing.Point(41, 19);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(17, 17);
            this.txtOrderId.TabIndex = 1;
            this.txtOrderId.Text = "...";
            // 
            // showOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "showOrderDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showOrderDetailForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableShowInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label txtAccName;
        private PictureBox picExit;
        private PictureBox picLogOut;
        private Label label1;
        private Label ABC;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label txtCus;
        private Label txtOrderId;
        private GroupBox groupBox3;
        private Label txtEmp;
        private GroupBox groupBox4;
        private Label txtDate;
        private DataGridView tableShowInfo;
    }
}