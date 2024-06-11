using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjHospital
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioAtual_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha o aplicativo completamente quando o formulário atual é fechado
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            abasPrincipal.SelectedTab = tabPerfil;

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            abasPrincipal.SelectedTab = tabProntuario;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abasPrincipal.SelectedTab = tabConsulta;

        }

        private void btnForum_Click(object sender, EventArgs e)
        {
            abasPrincipal.SelectedTab = tabForum;

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            abasPrincipal.SelectedTab = tabConfig;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            loadConfig();
        }

        private void loadConfig()
        {
            cboColor.Items.Add("Padrão (Sistema)");

            cboColor.Items.Add("Tema Claro");
            cboColor.Items.Add("Tema Escuro");

            cboLanguage.Items.Add("PT-BR");
            cboLanguage.Items.Add("EN-US");

            cboNotific.Items.Add("Todos");

            cboNotific.Items.Add("Somente Forúm");
            cboNotific.Items.Add("Silencioso");

            cboColor.SelectedIndex = 0;
            cboLanguage.SelectedIndex = 0;
            cboNotific.SelectedIndex = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Abrir Imagem";
            dialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg; *.png; *.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    Image imagem = Image.FromFile(dialog.FileName);

                    
                    imagePerfil.BackgroundImage = imagem;
                    pfpLateral.BackgroundImage = imagem;

                    
                    dialog.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cboNotific_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
