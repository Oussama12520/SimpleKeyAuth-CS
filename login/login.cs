using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.login_Load);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        public static KeyAuth.api KeyAuthApp = new KeyAuth.api(
            name: "",
            ownerid: "",
            version: "1.0"
        );

        private async void login_Load(object sender, EventArgs e)
        {
            await KeyAuthApp.init();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await KeyAuthApp.login(txtusername.Text, txtpass.Text);
            if (KeyAuthApp.response.success)
            {
                stats.ForeColor = Color.Green;
                stats.Text = "Login successful! Welcome, " + KeyAuthApp.user_data.username;
            }
            else
            {
                stats.ForeColor = Color.Red;
                stats.Text = "Login failed: " + KeyAuthApp.response.message;
            }
        }
        private void login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
