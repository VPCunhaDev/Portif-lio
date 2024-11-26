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
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace vpcunha_clientes
{
    public partial class Form1_1_primeiro_acesso : Form
    {
        public Form1_1_primeiro_acesso()
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
            string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            SqlCeCommand comando = new SqlCeCommand();

            try
            {
                int numero_celular;
                int.TryParse(masked_celular.Text, out numero_celular);

                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO usuarios_login (nome,sobrenome,email,celular,login,senha) " +
                    "VALUES ('" + txt_nome.Text + "','" + txt_sobrenome.Text+ "','" + txt_email.Text + "','" + numero_celular + "','" + txt_criar_login.Text + "','" + txt_criar_senha.Text + "')";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
                lbl_status.Text = "Usuário cadastrado no DB !";
            }
            catch (Exception ex) 
            {
                lbl_status.Text = ex.Message;
            }

        }

        private void Form1_1_primeiro_acesso_Load(object sender, EventArgs e)
        {

        }
    }
}
