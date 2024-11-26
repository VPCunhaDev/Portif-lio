namespace vpcunha_clientes
{
    partial class Form1_2_erro
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
            this.lbl_erro_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_erro_info
            // 
            this.lbl_erro_info.AutoSize = true;
            this.lbl_erro_info.Location = new System.Drawing.Point(232, 174);
            this.lbl_erro_info.Name = "lbl_erro_info";
            this.lbl_erro_info.Size = new System.Drawing.Size(87, 13);
            this.lbl_erro_info.TabIndex = 0;
            this.lbl_erro_info.Text = "Usuário incorreto";
            // 
            // Form1_2_erro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_erro_info);
            this.Name = "Form1_2_erro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPCunha - Erro !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_erro_info;
    }
}