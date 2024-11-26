namespace vpcunha_clientes
{
    partial class Form2_2_CadastrarPF
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
            this.gp_pessoa_fisica = new System.Windows.Forms.GroupBox();
            this.masked_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.gp_pessoa_fisica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_pessoa_fisica
            // 
            this.gp_pessoa_fisica.Controls.Add(this.masked_celular);
            this.gp_pessoa_fisica.Controls.Add(this.txt_email);
            this.gp_pessoa_fisica.Controls.Add(this.txt_sobrenome);
            this.gp_pessoa_fisica.Controls.Add(this.txt_nome);
            this.gp_pessoa_fisica.Controls.Add(this.lbl_celular);
            this.gp_pessoa_fisica.Controls.Add(this.lbl_email);
            this.gp_pessoa_fisica.Controls.Add(this.lbl_sobrenome);
            this.gp_pessoa_fisica.Controls.Add(this.lbl_nome);
            this.gp_pessoa_fisica.Location = new System.Drawing.Point(13, 12);
            this.gp_pessoa_fisica.Name = "gp_pessoa_fisica";
            this.gp_pessoa_fisica.Size = new System.Drawing.Size(448, 112);
            this.gp_pessoa_fisica.TabIndex = 0;
            this.gp_pessoa_fisica.TabStop = false;
            this.gp_pessoa_fisica.Text = "Dados Pessoa Física";
            // 
            // masked_celular
            // 
            this.masked_celular.Location = new System.Drawing.Point(286, 75);
            this.masked_celular.Mask = "(00) 0-0000-0000";
            this.masked_celular.Name = "masked_celular";
            this.masked_celular.Size = new System.Drawing.Size(156, 20);
            this.masked_celular.TabIndex = 7;
            this.masked_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(286, 41);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(156, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(79, 75);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(140, 20);
            this.txt_sobrenome.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(140, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(235, 78);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(45, 13);
            this.lbl_celular.TabIndex = 3;
            this.lbl_celular.Text = "Celular :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(239, 44);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(6, 78);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(67, 13);
            this.lbl_sobrenome.TabIndex = 1;
            this.lbl_sobrenome.Text = "Sobrenome :";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 44);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome : ";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(151, 175);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(249, 175);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(19, 138);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(16, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "...";
            // 
            // Form2_2_CadastrarPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 210);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.gp_pessoa_fisica);
            this.Name = "Form2_2_CadastrarPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Pessoa Física";
            this.gp_pessoa_fisica.ResumeLayout(false);
            this.gp_pessoa_fisica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_pessoa_fisica;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox masked_celular;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_status;
    }
}