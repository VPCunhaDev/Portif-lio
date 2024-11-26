namespace vpcunha_clientes
{
    partial class Form5_2_DBC_PJ
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
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.masked_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dgview_pj = new System.Windows.Forms.DataGridView();
            this.btn_todos_cadastros = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_status_dois = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filtrar);
            this.groupBox1.Controls.Add(this.lbl_filtro);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.masked_cnpj);
            this.groupBox1.Controls.Add(this.lbl_cnpj);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro :";
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Location = new System.Drawing.Point(11, 31);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(40, 13);
            this.lbl_cnpj.TabIndex = 0;
            this.lbl_cnpj.Text = "CNPJ :";
            // 
            // masked_cnpj
            // 
            this.masked_cnpj.Location = new System.Drawing.Point(57, 28);
            this.masked_cnpj.Name = "masked_cnpj";
            this.masked_cnpj.Size = new System.Drawing.Size(200, 20);
            this.masked_cnpj.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(275, 31);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail : ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(325, 28);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 3;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Location = new System.Drawing.Point(11, 60);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(16, 13);
            this.lbl_filtro.TabIndex = 4;
            this.lbl_filtro.Text = "...";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(231, 72);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 5;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dgview_pj
            // 
            this.dgview_pj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_pj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.email,
            this.cnpj,
            this.celular});
            this.dgview_pj.Location = new System.Drawing.Point(13, 127);
            this.dgview_pj.Name = "dgview_pj";
            this.dgview_pj.Size = new System.Drawing.Size(536, 374);
            this.dgview_pj.TabIndex = 1;
            // 
            // btn_todos_cadastros
            // 
            this.btn_todos_cadastros.Location = new System.Drawing.Point(13, 507);
            this.btn_todos_cadastros.Name = "btn_todos_cadastros";
            this.btn_todos_cadastros.Size = new System.Drawing.Size(536, 23);
            this.btn_todos_cadastros.TabIndex = 2;
            this.btn_todos_cadastros.Text = "Todos os cadastros pessoa jurídica";
            this.btn_todos_cadastros.UseVisualStyleBackColor = true;
            this.btn_todos_cadastros.Click += new System.EventHandler(this.btn_todos_cadastros_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(244, 570);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_status_dois
            // 
            this.lbl_status_dois.AutoSize = true;
            this.lbl_status_dois.Location = new System.Drawing.Point(10, 544);
            this.lbl_status_dois.Name = "lbl_status_dois";
            this.lbl_status_dois.Size = new System.Drawing.Size(16, 13);
            this.lbl_status_dois.TabIndex = 4;
            this.lbl_status_dois.Text = "...";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // cnpj
            // 
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            // 
            // Form5_2_DBC_PJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 605);
            this.Controls.Add(this.lbl_status_dois);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_todos_cadastros);
            this.Controls.Add(this.dgview_pj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5_2_DBC_PJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Pessoa Jurídica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.MaskedTextBox masked_cnpj;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridView dgview_pj;
        private System.Windows.Forms.Button btn_todos_cadastros;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_status_dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
    }
}