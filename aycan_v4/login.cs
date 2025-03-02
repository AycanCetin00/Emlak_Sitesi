using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace aycan_v4
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (ValidateUser(username, password))
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}