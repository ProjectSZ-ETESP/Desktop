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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        string numero = "";


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
            abasPrincipal.SelectedTab = tabRegistro;
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
            maskCPF();
            reset();
        }

        private void maskCPF()
        {
            txtCPF.Text = "12345678910";
            txtCPF.ForeColor = Color.Gray;
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

        private void senhaUrl_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabRegistro_Click(object sender, EventArgs e)
        {

        }

     

        private void txtCPF_Click(object sender, EventArgs e)
        {
            txtCPF.ForeColor = Color.Black;
            txtCPF.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Abrir Imagem";
            dialog.Filter = "Image Files (*.bmp; *.jpg; *.jpeg; *.png; *.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Image imagem = Image.FromFile(dialog.FileName);


                    pfpPaciente.BackgroundImage = imagem;

                    dialog.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void reset()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNasc.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            rdoMasc.Checked = true;
            pfpPaciente.BackgroundImage = null;
            txtNome.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" ||
                    txtCPF.Text == "" ||
                    txtDataNasc.Text == "" ||
                    txtTelefone.Text == "" ||
                    txtEmail.Text == "" ||
                    !txtEmail.Text.Contains("@")
                    )
            {
                MessageBox.Show("Dados inválidos ou não suficientes", "Erro!!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("🦋 Você está certo de suas escolhas?", "Registro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Paciente Cadastrado com sucesso", "Sucesso!!");
                    reset();                                    
                }                
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("🦋 Deseja apagar esse post?", "Moderação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Post Apagado com sucesso", "Sucesso!!");
                pnlPost.Visible = false;

            }
        }

        private void tabForum_Click(object sender, EventArgs e)
        {

        }
    }
}
