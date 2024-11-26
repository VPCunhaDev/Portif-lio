namespace vpcunha_clientes
{
    partial class Form1_3_configurarDB
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
            this.group_config_db = new System.Windows.Forms.GroupBox();
            this.btn_criar_DB = new System.Windows.Forms.Button();
            this.lbl_gp_db = new System.Windows.Forms.Label();
            this.group_config_tabelas = new System.Windows.Forms.GroupBox();
            this.btn_pj = new System.Windows.Forms.Button();
            this.btn_pf = new System.Windows.Forms.Button();
            this.lbl_gp_tabelas = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lbl_status_db = new System.Windows.Forms.Label();
            this.lbl_status_tabela = new System.Windows.Forms.Label();
            this.group_config_db.SuspendLayout();
            this.group_config_tabelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_config_db
            // 
            this.group_config_db.Controls.Add(this.lbl_status_db);
            this.group_config_db.Controls.Add(this.btn_criar_DB);
            this.group_config_db.Controls.Add(this.lbl_gp_db);
            this.group_config_db.Location = new System.Drawing.Point(21, 12);
            this.group_config_db.Name = "group_config_db";
            this.group_config_db.Size = new System.Drawing.Size(289, 121);
            this.group_config_db.TabIndex = 0;
            this.group_config_db.TabStop = false;
            this.group_config_db.Text = "Configurar Banco de Dados";
            // 
            // btn_criar_DB
            // 
            this.btn_criar_DB.Location = new System.Drawing.Point(107, 57);
            this.btn_criar_DB.Name = "btn_criar_DB";
            this.btn_criar_DB.Size = new System.Drawing.Size(75, 23);
            this.btn_criar_DB.TabIndex = 1;
            this.btn_criar_DB.Text = "Criar DB";
            this.btn_criar_DB.UseVisualStyleBackColor = true;
            this.btn_criar_DB.Click += new System.EventHandler(this.btn_criar_DB_Click);
            // 
            // lbl_gp_db
            // 
            this.lbl_gp_db.AutoSize = true;
            this.lbl_gp_db.Location = new System.Drawing.Point(22, 28);
            this.lbl_gp_db.Name = "lbl_gp_db";
            this.lbl_gp_db.Size = new System.Drawing.Size(244, 13);
            this.lbl_gp_db.TabIndex = 0;
            this.lbl_gp_db.Text = "Clique no botão abaixo para que o DB seja criado.";
            // 
            // group_config_tabelas
            // 
            this.group_config_tabelas.Controls.Add(this.lbl_status_tabela);
            this.group_config_tabelas.Controls.Add(this.btn_pj);
            this.group_config_tabelas.Controls.Add(this.btn_pf);
            this.group_config_tabelas.Controls.Add(this.lbl_gp_tabelas);
            this.group_config_tabelas.Location = new System.Drawing.Point(21, 157);
            this.group_config_tabelas.Name = "group_config_tabelas";
            this.group_config_tabelas.Size = new System.Drawing.Size(289, 121);
            this.group_config_tabelas.TabIndex = 1;
            this.group_config_tabelas.TabStop = false;
            this.group_config_tabelas.Text = "Configurar Tabelas";
            // 
            // btn_pj
            // 
            this.btn_pj.Location = new System.Drawing.Point(168, 60);
            this.btn_pj.Name = "btn_pj";
            this.btn_pj.Size = new System.Drawing.Size(75, 23);
            this.btn_pj.TabIndex = 2;
            this.btn_pj.Text = "Cliente PJ";
            this.btn_pj.UseVisualStyleBackColor = true;
            this.btn_pj.Click += new System.EventHandler(this.btn_pj_Click);
            // 
            // btn_pf
            // 
            this.btn_pf.Location = new System.Drawing.Point(48, 60);
            this.btn_pf.Name = "btn_pf";
            this.btn_pf.Size = new System.Drawing.Size(75, 23);
            this.btn_pf.TabIndex = 1;
            this.btn_pf.Text = "Cliente PF";
            this.btn_pf.UseVisualStyleBackColor = true;
            this.btn_pf.Click += new System.EventHandler(this.btn_pf_Click);
            // 
            // lbl_gp_tabelas
            // 
            this.lbl_gp_tabelas.AutoSize = true;
            this.lbl_gp_tabelas.Location = new System.Drawing.Point(45, 30);
            this.lbl_gp_tabelas.Name = "lbl_gp_tabelas";
            this.lbl_gp_tabelas.Size = new System.Drawing.Size(198, 13);
            this.lbl_gp_tabelas.TabIndex = 0;
            this.lbl_gp_tabelas.Text = "Selecione a(s) tabela(s) que deseja criar.";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(128, 294);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_status_db
            // 
            this.lbl_status_db.AutoSize = true;
            this.lbl_status_db.Location = new System.Drawing.Point(22, 94);
            this.lbl_status_db.Name = "lbl_status_db";
            this.lbl_status_db.Size = new System.Drawing.Size(74, 13);
            this.lbl_status_db.TabIndex = 2;
            this.lbl_status_db.Text = "Aguardando...";
            // 
            // lbl_status_tabela
            // 
            this.lbl_status_tabela.AutoSize = true;
            this.lbl_status_tabela.Location = new System.Drawing.Point(22, 96);
            this.lbl_status_tabela.Name = "lbl_status_tabela";
            this.lbl_status_tabela.Size = new System.Drawing.Size(74, 13);
            this.lbl_status_tabela.TabIndex = 3;
            this.lbl_status_tabela.Text = "Aguardando...";
            // 
            // Form1_3_configurarDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 329);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.group_config_tabelas);
            this.Controls.Add(this.group_config_db);
            this.Name = "Form1_3_configurarDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Configurar";
            this.group_config_db.ResumeLayout(false);
            this.group_config_db.PerformLayout();
            this.group_config_tabelas.ResumeLayout(false);
            this.group_config_tabelas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_config_db;
        private System.Windows.Forms.Label lbl_gp_db;
        private System.Windows.Forms.Button btn_criar_DB;
        private System.Windows.Forms.GroupBox group_config_tabelas;
        private System.Windows.Forms.Label lbl_gp_tabelas;
        private System.Windows.Forms.Button btn_pj;
        private System.Windows.Forms.Button btn_pf;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_status_db;
        private System.Windows.Forms.Label lbl_status_tabela;
    }
}