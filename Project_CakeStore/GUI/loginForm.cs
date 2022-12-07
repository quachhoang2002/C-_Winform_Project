using Project_CakeStore.BUS;
using Project_CakeStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_CakeStore.GUI
{
    public partial class loginForm : Form
    {

        account_BUS acc_BUS = new account_BUS();
        
        public loginForm()
        {
            InitializeComponent();
            
        }

        public String getName()
        {
            String userName = txtUserName.Text;
            String password = txtPass.Text;
            employee_DTO emp = acc_BUS.getEmpName(userName, password);
            return emp.getEmpName();
        }

        public String getId()
        {
            String userName = txtUserName.Text;
            String password = txtPass.Text;
            employee_DTO emp = acc_BUS.getEmpName(userName, password);
            return emp.getEmpID();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String password = txtPass.Text;

            if(userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Vui long nhap day du ten dang nhap va mat khau");
            } 
            else
            {
                if (acc_BUS.checkLogin(userName, password).Equals(account_DTO.Permission.Manager))
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(getName(), getId());
                    mainForm.Owner = this;
                    mainForm.ShowDialog();
                }
                else if (acc_BUS.checkLogin(userName, password).Equals(account_DTO.Permission.Employee))
                {
                    this.Hide();
                    employeeLoginForm employeeLoginForm = new employeeLoginForm(getName(), getId());
                    employeeLoginForm.Owner = this;
                    employeeLoginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau");
                    txtPass.Text = "";
                }
            }
        }
    }
}
