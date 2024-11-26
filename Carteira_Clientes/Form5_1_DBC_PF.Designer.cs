namespace vpcunha_clientes
{
    partial class Form5_1_DBC_PF
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
            this.gp_filtro_pf = new System.Windows.Forms.GroupBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.lbl_status_filtro = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dgview_pf = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_todos_cadastros = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_status_dois = new System.Windows.Forms.Label();
            this.gp_filtro_pf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pf)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_filtro_pf
            // 
            this.gp_filtro_pf.Controls.Add(this.btn_filtrar);
            this.gp_filtro_pf.Controls.Add(this.lbl_status_filtro);
            this.gp_filtro_pf.Controls.Add(this.txt_email);
            this.gp_filtro_pf.Controls.Add(this.txt_nome);
            this.gp_filtro_pf.Controls.Add(this.lbl_email);
            this.gp_filtro_pf.Controls.Add(this.lbl_nome);
            this.gp_filtro_pf.Location = new System.Drawing.Point(13, 12);
            this.gp_filtro_pf.Name = "gp_filtro_pf";
            this.gp_filtro_pf.Size = new System.Drawing.Size(536, 109);
            this.gp_filtro_pf.TabIndex = 0;
            this.gp_filtro_pf.TabStop = false;
            this.gp_filtro_pf.Text = "Filtro :";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(231, 79);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 5;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // lbl_status_filtro
            // 
            this.lbl_status_filtro.AutoSize = true;
            this.lbl_status_filtro.Location = new System.Drawing.Point(8, 61);
            this.lbl_status_filtro.Name = "lbl_status_filtro";
            this.lbl_status_filtro.Size = new System.Drawing.Size(16, 13);
            this.lbl_status_filtro.TabIndex = 4;
            this.lbl_status_filtro.Text = "...";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(328, 27);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(58, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(200, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(281, 30);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome : ";
            // 
            // dgview_pf
            // 
            this.dgview_pf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_pf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sobrenome,
            this.email,
            this.celular});
            this.dgview_pf.Location = new System.Drawing.Point(13, 127);
            this.dgview_pf.Name = "dgview_pf";
            this.dgview_pf.Size = new System.Drawing.Size(536, 374);
            this.dgview_pf.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // sobrenome
            // 
            this.sobrenome.HeaderText = "Sobrenome";
            this.sobrenome.Name = "sobrenome";
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            // 
            // btn_todos_cadastros
            // 
            this.btn_todos_cadastros.Location = new System.Drawing.Point(13, 507);
            this.btn_todos_cadastros.Name = "btn_todos_cadastros";
            this.btn_todos_cadastros.Size = new System.Drawing.Size(536, 23);
            this.btn_todos_cadastros.TabIndex = 2;
            this.btn_todos_cadastros.Text = "Todos os cadastros pessoa física";
            this.btn_todos_cadastros.UseVisualStyleBackColor = true;
            this.btn_todos_cadastros.Click += new System.EventHandler(this.btn_todos_cadastros_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(244, 560);
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
            this.lbl_status_dois.Location = new System.Drawing.Point(12, 533);
            this.lbl_status_dois.Name = "lbl_status_dois";
            this.lbl_status_dois.Size = new System.Drawing.Size(16, 13);
            this.lbl_status_dois.TabIndex = 4;
            this.lbl_status_dois.Text = "...";
            // 
            // Form5_1_DBC_PF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 605);
            this.Controls.Add(this.lbl_status_dois);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_todos_cadastros);
            this.Controls.Add(this.dgview_pf);
            this.Controls.Add(this.gp_filtro_pf);
            this.Name = "Form5_1_DBC_PF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Pessoa Física";
            this.gp_filtro_pf.ResumeLayout(false);
            this.gp_filtro_pf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_pf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_filtro_pf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_status_filtro;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.DataGridView dgview_pf;
        private System.Windows.Forms.Button btn_todos_cadastros;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_status_dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
    }
}