using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpcunha_clientes
{
    public partial class Form2_3_CadastrarPJ : Form
    {
        public Form2_3_CadastrarPJ()
        {
            InitializeComponent();
        }

        private void lbl_cnpj_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            SqlCeCommand comando = new SqlCeCommand();

            try
            {
                int numero_celular;
                int.TryParse(masked_celular.Text,out numero_celular);
                int numero_cnpj;
                int.TryParse(masked_cnpj.Text, out numero_cnpj);

                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO cliente_pessoa_juridica (nome,email,cnpj,celular) VALUES('"+txt_nome_fantasia.Text+"','"+txt_email.Text+"','"+numero_cnpj+"','"+numero_celular+"')";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
                lbl_status.Text = "Cadastro salvo !";
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
            }
        }
    }
}
