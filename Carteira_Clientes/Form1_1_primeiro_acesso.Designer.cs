namespace vpcunha_clientes
{
    partial class Form1_1_primeiro_acesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.group_dados_pessoais = new System.Windows.Forms.GroupBox();
            this.masked_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_status_senha = new System.Windows.Forms.Label();
            this.lbl_status_login = new System.Windows.Forms.Label();
            this.txt_criar_senha = new System.Windows.Forms.TextBox();
            this.txt_criar_login = new System.Windows.Forms.TextBox();
            this.lbl_criar_senha = new System.Windows.Forms.Label();
            this.lbl_criar_login = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_status_db = new System.Windows.Forms.Label();
            this.lbl_status_dados_login = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.group_dados_pessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_dados_pessoais
            // 
            this.group_dados_pessoais.Controls.Add(this.masked_celular);
            this.group_dados_pessoais.Controls.Add(this.txt_email);
            this.group_dados_pessoais.Controls.Add(this.lbl_celular);
            this.group_dados_pessoais.Controls.Add(this.lbl_email);
            this.group_dados_pessoais.Controls.Add(this.txt_sobrenome);
            this.group_dados_pessoais.Controls.Add(this.lbl_sobrenome);
            this.group_dados_pessoais.Controls.Add(this.txt_nome);
            this.group_dados_pessoais.Controls.Add(this.lbl_nome);
            this.group_dados_pessoais.Location = new System.Drawing.Point(12, 12);
            this.group_dados_pessoais.Name = "group_dados_pessoais";
            this.group_dados_pessoais.Size = new System.Drawing.Size(428, 104);
            this.group_dados_pessoais.TabIndex = 0;
            this.group_dados_pessoais.TabStop = false;
            this.group_dados_pessoais.Text = "Dados Pessoais";
            // 
            // masked_celular
            // 
            this.masked_celular.Location = new System.Drawing.Point(277, 64);
            this.masked_celular.Mask = "(00) 00000-0000";
            this.masked_celular.Name = "masked_celular";
            this.masked_celular.Size = new System.Drawing.Size(145, 20);
            this.masked_celular.TabIndex = 7;
            this.masked_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(277, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(145, 20);
            this.txt_email.TabIndex = 6;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(230, 67);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(48, 13);
            this.lbl_celular.TabIndex = 5;
            this.lbl_celular.Text = "Celular : ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(230, 29);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail :";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(79, 64);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(131, 20);
            this.txt_sobrenome.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(6, 67);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(67, 13);
            this.lbl_sobrenome.TabIndex = 2;
            this.lbl_sobrenome.Text = "Sobrenome :";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 26);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(131, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_status_senha);
            this.groupBox1.Controls.Add(this.lbl_status_login);
            this.groupBox1.Controls.Add(this.txt_criar_senha);
            this.groupBox1.Controls.Add(this.txt_criar_login);
            this.groupBox1.Controls.Add(this.lbl_criar_senha);
            this.groupBox1.Controls.Add(this.lbl_criar_login);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para Login";
            // 
            // lbl_status_senha
            // 
            this.lbl_status_senha.AutoSize = true;
            this.lbl_status_senha.Location = new System.Drawing.Point(230, 68);
            this.lbl_status_senha.Name = "lbl_status_senha";
            this.lbl_status_senha.Size = new System.Drawing.Size(87, 13);
            this.lbl_status_senha.TabIndex = 5;
            this.lbl_status_senha.Text = "Insira sua senha.";
            // 
            // lbl_status_login
            // 
            this.lbl_status_login.AutoSize = true;
            this.lbl_status_login.Location = new System.Drawing.Point(230, 32);
            this.lbl_status_login.Name = "lbl_status_login";
            this.lbl_status_login.Size = new System.Drawing.Size(80, 13);
            this.lbl_status_login.TabIndex = 4;
            this.lbl_status_login.Text = "Insira seu login.";
            // 
            // txt_criar_senha
            // 
            this.txt_criar_senha.Location = new System.Drawing.Point(91, 65);
            this.txt_criar_senha.Name = "txt_criar_senha";
            this.txt_criar_senha.Size = new System.Drawing.Size(119, 20);
            this.txt_criar_senha.TabIndex = 3;
            // 
            // txt_criar_login
            // 
            this.txt_criar_login.Location = new System.Drawing.Point(91, 29);
            this.txt_criar_login.Name = "txt_criar_login";
            this.txt_criar_login.Size = new System.Drawing.Size(119, 20);
            this.txt_criar_login.TabIndex = 2;
            // 
            // lbl_criar_senha
            // 
            this.lbl_criar_senha.AutoSize = true;
            this.lbl_criar_senha.Location = new System.Drawing.Point(6, 68);
            this.lbl_criar_senha.Name = "lbl_criar_senha";
            this.lbl_criar_senha.Size = new System.Drawing.Size(86, 13);
            this.lbl_criar_senha.TabIndex = 1;
            this.lbl_criar_senha.Text = "Crie sua senha : ";
            // 
            // lbl_criar_login
            // 
            this.lbl_criar_login.AutoSize = true;
            this.lbl_criar_login.Location = new System.Drawing.Point(6, 32);
            this.lbl_criar_login.Name = "lbl_criar_login";
            this.lbl_criar_login.Size = new System.Drawing.Size(79, 13);
            this.lbl_criar_login.TabIndex = 0;
            this.lbl_criar_login.Text = "Crie seu login : ";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(129, 305);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(248, 305);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_status_db
            // 
            this.lbl_status_db.AutoSize = true;
            this.lbl_status_db.Location = new System.Drawing.Point(18, 247);
            this.lbl_status_db.Name = "lbl_status_db";
            this.lbl_status_db.Size = new System.Drawing.Size(0, 13);
            this.lbl_status_db.TabIndex = 4;
            // 
            // lbl_status_dados_login
            // 
            this.lbl_status_dados_login.AutoSize = true;
            this.lbl_status_dados_login.Location = new System.Drawing.Point(18, 275);
            this.lbl_status_dados_login.Name = "lbl_status_dados_login";
            this.lbl_status_dados_login.Size = new System.Drawing.Size(0, 13);
            this.lbl_status_dados_login.TabIndex = 5;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(18, 260);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 6;
            // 
            // Form1_1_primeiro_acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 340);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_status_dados_login);
            this.Controls.Add(this.lbl_status_db);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_dados_pessoais);
            this.Name = "Form1_1_primeiro_acesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Primeiro Acesso";
            this.Load += new System.EventHandler(this.Form1_1_primeiro_acesso_Load);
            this.group_dados_pessoais.ResumeLayout(false);
            this.group_dados_pessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_dados_pessoais;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox masked_celular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_criar_senha;
        private System.Windows.Forms.Label lbl_criar_login;
        private System.Windows.Forms.TextBox txt_criar_senha;
        private System.Windows.Forms.TextBox txt_criar_login;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_status_senha;
        private System.Windows.Forms.Label lbl_status_login;
        private System.Windows.Forms.Label lbl_status_db;
        private System.Windows.Forms.Label lbl_status_dados_login;
        private System.Windows.Forms.Label lbl_status;
    }
}