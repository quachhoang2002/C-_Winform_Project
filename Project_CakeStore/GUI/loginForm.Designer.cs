namespace Project_CakeStore.GUI
{
    partial class loginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkLuu = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ABC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.checkLuu);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 528);
            this.panel1.TabIndex = 0;
            // 
            // checkLuu
            // 
            this.checkLuu.AutoSize = true;
            this.checkLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkLuu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkLuu.Location = new System.Drawing.Point(189, 338);
            this.checkLuu.Name = "checkLuu";
            this.checkLuu.Size = new System.Drawing.Size(140, 27);
            this.checkLuu.TabIndex = 5;
            this.checkLuu.Text = "Remember";
            this.checkLuu.UseVisualStyleBackColor = true;
            this.checkLuu.CheckedChanged += new System.EventHandler(this.checkLuu_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(189, 405);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(206, 268);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(234, 27);
            this.txtPass.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(206, 205);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 27);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(46, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.ABC);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 101);
            this.panel2.TabIndex = 0;
            // 
            // ABC
            // 
            this.ABC.AutoSize = true;
            this.ABC.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ABC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ABC.Location = new System.Drawing.Point(133, 25);
            this.ABC.Name = "ABC";
            this.ABC.Size = new System.Drawing.Size(249, 47);
            this.ABC.TabIndex = 0;
            this.ABC.Text = "ABC Bakery";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 531);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label ABC;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private CheckBox checkLuu;
    }
}