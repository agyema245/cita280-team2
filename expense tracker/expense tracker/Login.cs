using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expense_tracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn(UserTxt.Text, passwordTxt.Text);
            login.msg();

        }

    }
    class LogIn
    {
        string username;
        string password;
        public LogIn(string _username, string _password)
        {
            username = _username;
            password = _password;
        }
        public void msg()
        {
            MessageBox.Show(username);
        }
    }

}
