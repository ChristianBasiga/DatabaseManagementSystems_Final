using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystem.CustomUserControls
{
    public partial class LoginWindow : Form
    {
        Homepage from;
        public LoginWindow(Homepage from)
        {
            this.from = from;
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            if (sender is Homepage)
            {
                from = (Homepage)sender;

            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Need way to transfer data back and forth, without making password a public property, cause that's dumb.
            try
            {
                from.login(email.Text, password.Text);

                errorMessage.Visible = false;

                this.Close();

            }
            catch (Exception err)
            {
                errorMessage.Text = err.Message;
                errorMessage.Visible = true;
                //Put error message here
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
