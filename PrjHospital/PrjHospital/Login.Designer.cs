
namespace PrjHospital
{
    partial class telaLog
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLog));
            this.btnForgetei = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEye = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboRemember = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEye)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForgetei
            // 
            this.btnForgetei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForgetei.AutoSize = true;
            this.btnForgetei.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetei.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForgetei.Location = new System.Drawing.Point(48, 412);
            this.btnForgetei.Name = "btnForgetei";
            this.btnForgetei.Size = new System.Drawing.Size(190, 28);
            this.btnForgetei.TabIndex = 10;
            this.btnForgetei.Text = "Esqueci minha senha";
            this.btnForgetei.Click += new System.EventHandler(this.btnForgetei_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(20, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 24);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "a";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(124)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cboRemember);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogar);
            this.panel1.Controls.Add(this.btnForgetei);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 600);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PrjHospital.Properties.Resources.rec;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.btnEye);
            this.panel3.Location = new System.Drawing.Point(2, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 55);
            this.panel3.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPassword.Location = new System.Drawing.Point(21, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(215, 24);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "a";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnEye
            // 
            this.btnEye.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEye.BackColor = System.Drawing.Color.Transparent;
            this.btnEye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEye.BackgroundImage")));
            this.btnEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEye.Location = new System.Drawing.Point(242, 12);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(26, 26);
            this.btnEye.TabIndex = 13;
            this.btnEye.TabStop = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::PrjHospital.Properties.Resources.rec;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Location = new System.Drawing.Point(3, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 55);
            this.panel2.TabIndex = 17;
            // 
            // cboRemember
            // 
            this.cboRemember.AutoSize = true;
            this.cboRemember.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRemember.ForeColor = System.Drawing.SystemColors.Control;
            this.cboRemember.Location = new System.Drawing.Point(23, 334);
            this.cboRemember.Name = "cboRemember";
            this.cboRemember.Size = new System.Drawing.Size(140, 23);
            this.cboRemember.TabIndex = 15;
            this.cboRemember.Text = "Mantenha o login";
            this.cboRemember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboRemember.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::PrjHospital.Properties.Resources.logoDark_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(113, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogar.BackgroundImage = global::PrjHospital.Properties.Resources.Group_65;
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogar.Location = new System.Drawing.Point(129, 504);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(45, 45);
            this.btnLogar.TabIndex = 14;
            this.btnLogar.TabStop = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 599);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // telaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrjHospital.Properties.Resources.vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEye)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnLogar;
        private System.Windows.Forms.PictureBox btnEye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnForgetei;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox cboRemember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

