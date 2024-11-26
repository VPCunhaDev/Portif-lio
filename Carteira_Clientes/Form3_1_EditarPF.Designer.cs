namespace vpcunha_clientes
{
    partial class Form3_1_EditarPF
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
            this.gp_pesquisar_pf = new System.Windows.Forms.GroupBox();
            this.lbl_pesquisar_nome = new System.Windows.Forms.Label();
            this.txt_pesquisar_nome = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_pesquisar_email = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.gp_resultados_pf = new System.Windows.Forms.GroupBox();
            this.dgview_resultados_pf = new System.Windows.Forms.DataGridView();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.gp_pesquisar_pf.SuspendLayout();
            this.gp_resultados_pf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_resultados_pf)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_pesquisar_pf
            // 
            this.gp_pesquisar_pf.Controls.Add(this.btn_pesquisar);
            this.gp_pesquisar_pf.Controls.Add(this.txt_pesquisar_email);
            this.gp_pesquisar_pf.Controls.Add(this.lbl_email);
            this.gp_pesquisar_pf.Controls.Add(this.txt_pesquisar_nome);
            this.gp_pesquisar_pf.Controls.Add(this.lbl_pesquisar_nome);
            this.gp_pesquisar_pf.Location = new System.Drawing.Point(12, 12);
            this.gp_pesquisar_pf.Name = "gp_pesquisar_pf";
            this.gp_pesquisar_pf.Size = new System.Drawing.Size(531, 89);
            this.gp_pesquisar_pf.TabIndex = 0;
            this.gp_pesquisar_pf.TabStop = false;
            this.gp_pesquisar_pf.Text = "Pesquisar :";
            // 
            // lbl_pesquisar_nome
            // 
            this.lbl_pesquisar_nome.AutoSize = true;
            this.lbl_pesquisar_nome.Location = new System.Drawing.Point(15, 25);
            this.lbl_pesquisar_nome.Name = "lbl_pesquisar_nome";
            this.lbl_pesquisar_nome.Size = new System.Drawing.Size(41, 13);
            this.lbl_pesquisar_nome.TabIndex = 0;
            this.lbl_pesquisar_nome.Text = "Nome :";
            // 
            // txt_pesquisar_nome
            // 
            this.txt_pesquisar_nome.Location = new System.Drawing.Point(62, 22);
            this.txt_pesquisar_nome.Name = "txt_pesquisar_nome";
            this.txt_pesquisar_nome.Size = new System.Drawing.Size(190, 20);
            this.txt_pesquisar_nome.TabIndex = 1;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(279, 25);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail :";
            // 
            // txt_pesquisar_email
            // 
            this.txt_pesquisar_email.Location = new System.Drawing.Point(326, 22);
            this.txt_pesquisar_email.Name = "txt_pesquisar_email";
            this.txt_pesquisar_email.Size = new System.Drawing.Size(190, 20);
            this.txt_pesquisar_email.TabIndex = 3;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(228, 60);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // gp_resultados_pf
            // 
            this.gp_resultados_pf.Controls.Add(this.dgview_resultados_pf);
            this.gp_resultados_pf.Location = new System.Drawing.Point(12, 107);
            this.gp_resultados_pf.Name = "gp_resultados_pf";
            this.gp_resultados_pf.Size = new System.Drawing.Size(531, 203);
            this.gp_resultados_pf.TabIndex = 1;
            this.gp_resultados_pf.TabStop = false;
            this.gp_resultados_pf.Text = "Resultados :";
            // 
            // dgview_resultados_pf
            // 
            this.dgview_resultados_pf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_resultados_pf.Location = new System.Drawing.Point(18, 19);
            this.dgview_resultados_pf.Name = "dgview_resultados_pf";
            this.dgview_resultados_pf.Size = new System.Drawing.Size(498, 150);
            this.dgview_resultados_pf.TabIndex = 0;
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Location = new System.Drawing.Point(127, 345);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(35, 13);
            this.lbl_erro.TabIndex = 2;
            this.lbl_erro.Text = "label1";
            // 
            // Form3_1_EditarPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.gp_resultados_pf);
            this.Controls.Add(this.gp_pesquisar_pf);
            this.Name = "Form3_1_EditarPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Editar PF";
            this.gp_pesquisar_pf.ResumeLayout(false);
            this.gp_pesquisar_pf.PerformLayout();
            this.gp_resultados_pf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_resultados_pf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_pesquisar_pf;
        private System.Windows.Forms.Label lbl_pesquisar_nome;
        private System.Windows.Forms.TextBox txt_pesquisar_nome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_pesquisar_email;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox gp_resultados_pf;
        private System.Windows.Forms.DataGridView dgview_resultados_pf;
        private System.Windows.Forms.Label lbl_erro;
    }
}