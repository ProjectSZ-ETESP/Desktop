using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtEmail.Text = "Insira seu e-mail";
            txtEmail.ForeColor = Color.Gray;
            txtPassword.Text = "Insira sua senha";
            txtPassword.ForeColor = Color.Gray;

            txtPassword.PasswordChar = '\0';
        }

        private void btnForgetei_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://google.com");
            Process.Start(sInfo);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.ShowDialog();
            this.Close();
        }

        private void checkEye()
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnEye.BackgroundImage = Properties.Resources.zoio;
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                btnEye.BackgroundImage = Properties.Resources.dormi;

                txtPassword.PasswordChar = '*';
            }
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            checkEye();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";            
            txtEmail.ForeColor = Color.Black;
            TextBox txt = (sender as TextBox);
            String texto = txt.Text;
            if (texto.StartsWith("Insira"))
            {
                txt.Text = "";
            }

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
            btnEye.BackgroundImage = Properties.Resources.dormi;
            txtPassword.PasswordChar = '*';

        }



    }
}
