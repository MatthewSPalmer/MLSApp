using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLSApp
{

    public partial class Login : Form
    {
        int attempts = 0;
        public event ShowModifyDel? ShowModify;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "a" && txtPassword.Text == "a")
            {
                MessageBox.Show("Login Successful.");
                ShowModify();
                this.Hide();
            }
            else
            {
                // Lock controls after 2 failed attempts
                attempts++;
                if (attempts == 2)
                {
                    MessageBox.Show("User locked out.");
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                }
                int remaining = 2 - attempts;
                MessageBox.Show($"Incorrect Username or Password. {remaining} attempts remaining!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
