using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PrjHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetInitialTextAndColor(txtEmail, "Insira seu e-mail");
            SetInitialTextAndColor(txtPassword, "Insira sua senha");
            txtPassword.PasswordChar = '\0';
        }

        private void SetInitialTextAndColor(TextBox textBox, string initialText)
        {
            textBox.Text = initialText;
            textBox.ForeColor = Color.Gray;
        }

        private void btnForgetei_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!string.IsNullOrEmpty(email) && 
                !string.IsNullOrEmpty(txtPassword.Text) && 
                email.Contains("@"))
            {
                Principal frm = new Principal();
                frm.ShowDialog();
                Close();
            }
        }

        private void TogglePasswordVisibility()
        {
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
            btnEye.BackgroundImage = (txtPassword.PasswordChar == '*') ? 
                Properties.Resources.dormi : Properties.Resources.zoio;
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void txtBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtBox_Click(sender, e);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtBox_Click(sender, e);
        }
    }
}
