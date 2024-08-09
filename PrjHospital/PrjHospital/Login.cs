using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PrjHospital
{
    public partial class telaLog : Form
    {
        public telaLog()
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

            //string email = txtEmail.Text;
            //if (!string.IsNullOrEmpty(email) && 
            //    !string.IsNullOrEmpty(txtPassword.Text) && 
            //    email.Contains("@"))
            //{
            //    Principal frm = new Principal();
            //    frm.ShowDialog();
            //    Close();
            //}

            if (cboRemember.Checked)
            {
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.Save(); 
            }

            Principal frm = new Principal();
            this.Hide();
            frm.ShowDialog();
            
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
                textBox.ForeColor = Color.Gray;
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

        string tema;


        private void Form1_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.remember)
            {
                Principal frm = new Principal();
                this.Hide();
                frm.ShowDialog();
            }

            tema = Properties.Settings.Default.theme;

            
            Color white = System.Drawing.ColorTranslator.FromHtml("#161817");            
            Color dark = System.Drawing.ColorTranslator.FromHtml("#387c64");

            switch (tema)
            {
                case "Tema Claro":
                    panel1.BackColor = dark;
                    menuStrip1.BackgroundImage = Properties.Resources.map_vector;
                     
                    break;
                case "Tema Escuro":
                    panel1.BackColor = white;
                    menuStrip1.BackgroundImage = Properties.Resources.Tela_Login;
                    break;
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
