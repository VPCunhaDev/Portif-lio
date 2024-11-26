using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace vpcunha_clientes
{
    public partial class Form2_2_CadastrarPF : Form
    {
        public Form2_2_CadastrarPF()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" +dbce_pasta+ ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            SqlCeCommand comando = new SqlCeCommand();

            try
            {
                int numero_celular;
                int.TryParse(masked_celular.Text,out numero_celular);
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO cliente_pessoa_fisica(nome,sobrenome,email,celular) VALUES " +
                    "('"+txt_nome.Text+"','"+txt_sobrenome.Text+"','"+txt_email.Text+"','"+numero_celular+"')";
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
