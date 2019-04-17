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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            ConnectionDB conn = new ConnectionDB("C: /Users/agyema245/Documents/Visual Studio/expense tracker/DataBase/ExpenseDB.accdb");
            string sqlString = "insert into userAccount (FirstName,LastName) Values('";
            sqlString += FNameTxt.Text + "','" + LNameTxt.Text + "')";
            conn.ExecuteQuery(sqlString);
        }

    }
}
