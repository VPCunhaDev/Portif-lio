namespace vpcunha_clientes
{
    partial class Form2_3_CadastrarPJ
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masked_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.masked_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome_fantasia = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.lbl_nome_fantasia = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masked_celular);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.masked_cnpj);
            this.groupBox1.Controls.Add(this.txt_nome_fantasia);
            this.groupBox1.Controls.Add(this.lbl_celular);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_cnpj);
            this.groupBox1.Controls.Add(this.lbl_nome_fantasia);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoa Jurídica";
            // 
            // masked_celular
            // 
            this.masked_celular.Location = new System.Drawing.Point(263, 65);
            this.masked_celular.Mask = "(00) 0-0000-0000";
            this.masked_celular.Name = "masked_celular";
            this.masked_celular.Size = new System.Drawing.Size(156, 20);
            this.masked_celular.TabIndex = 7;
            this.masked_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(263, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(156, 20);
            this.txt_email.TabIndex = 6;
            // 
            // masked_cnpj
            // 
            this.masked_cnpj.Location = new System.Drawing.Point(53, 65);
            this.masked_cnpj.Mask = "00.000.000/0000-00";
            this.masked_cnpj.Name = "masked_cnpj";
            this.masked_cnpj.Size = new System.Drawing.Size(140, 20);
            this.masked_cnpj.TabIndex = 5;
            this.masked_cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nome_fantasia
            // 
            this.txt_nome_fantasia.Location = new System.Drawing.Point(53, 26);
            this.txt_nome_fantasia.Name = "txt_nome_fantasia";
            this.txt_nome_fantasia.Size = new System.Drawing.Size(140, 20);
            this.txt_nome_fantasia.TabIndex = 4;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(212, 68);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(45, 13);
            this.lbl_celular.TabIndex = 3;
            this.lbl_celular.Text = "Celular :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(216, 29);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Location = new System.Drawing.Point(7, 68);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(40, 13);
            this.lbl_cnpj.TabIndex = 1;
            this.lbl_cnpj.Text = "CNPJ :";
            this.lbl_cnpj.Click += new System.EventHandler(this.lbl_cnpj_Click);
            // 
            // lbl_nome_fantasia
            // 
            this.lbl_nome_fantasia.AutoSize = true;
            this.lbl_nome_fantasia.Location = new System.Drawing.Point(6, 29);
            this.lbl_nome_fantasia.Name = "lbl_nome_fantasia";
            this.lbl_nome_fantasia.Size = new System.Drawing.Size(41, 13);
            this.lbl_nome_fantasia.TabIndex = 0;
            this.lbl_nome_fantasia.Text = "Nome :";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(149, 175);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(250, 175);
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
            this.lbl_status.Location = new System.Drawing.Point(25, 126);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(16, 13);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.Text = "...";
            // 
            // Form2_3_CadastrarPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 210);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2_3_CadastrarPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Pessoa Jurídica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nome_fantasia;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox txt_nome_fantasia;
        private System.Windows.Forms.MaskedTextBox masked_cnpj;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox masked_celular;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_status;
    }
}