namespace vpcunha_clientes
{
    partial class Form1_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripmenu_opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_configurarDB = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_primeiro_acesso = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_opcoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripmenu_opcoes
            // 
            this.stripmenu_opcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_configurarDB,
            this.stripmenu_primeiro_acesso});
            this.stripmenu_opcoes.Name = "stripmenu_opcoes";
            this.stripmenu_opcoes.Size = new System.Drawing.Size(59, 20);
            this.stripmenu_opcoes.Text = "Opções";
            // 
            // strip_configurarDB
            // 
            this.strip_configurarDB.Name = "strip_configurarDB";
            this.strip_configurarDB.Size = new System.Drawing.Size(166, 22);
            this.strip_configurarDB.Text = "Configurar DB...";
            this.strip_configurarDB.Click += new System.EventHandler(this.strip_configurarDB_Click);
            // 
            // stripmenu_primeiro_acesso
            // 
            this.stripmenu_primeiro_acesso.Name = "stripmenu_primeiro_acesso";
            this.stripmenu_primeiro_acesso.Size = new System.Drawing.Size(166, 22);
            this.stripmenu_primeiro_acesso.Text = "Primeiro acesso...";
            this.stripmenu_primeiro_acesso.Click += new System.EventHandler(this.primeiroAcessoToolStripMenuItem_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(39, 198);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(33, 13);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(39, 228);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(83, 195);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 3;
            this.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_login.TextChanged += new System.EventHandler(this.txt_login_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(83, 225);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(96, 291);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 258);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(16, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "...";
            // 
            // Form1_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 326);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_opcoes;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_primeiro_acesso;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem strip_configurarDB;
        private System.Windows.Forms.Label lbl_status;
    }
}

