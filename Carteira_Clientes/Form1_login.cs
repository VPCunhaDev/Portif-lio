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
    public partial class Form1_login : Form
    {
        public Form1_login()
        {
            InitializeComponent();
        }

        private void primeiroAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_1_primeiro_acesso form1_1_primeiro_acesso = new Form1_1_primeiro_acesso();
            form1_1_primeiro_acesso.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Form2_1_options form2_1_Options = new Form2_1_options();

            string dados_login;
            string dados_senha;
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource="+dbce_pasta+";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            DataTable dados = new DataTable();


            try
            {
                string login = txt_login.Text;
                string senha = txt_senha.Text;
                SqlCeCommand comando = new SqlCeCommand();
                SqlCeDataReader ler_dados;
                comando.CommandText = "SELECT*FROM usuarios_login WHERE login = '"+login+"'" ;
                conexao.Open();
                comando.Connection = conexao;
                ler_dados = comando.ExecuteReader();

                if (ler_dados.Read())
                {
                    dados_login = ler_dados[4].ToString();
                    dados_senha = ler_dados[5].ToString();

                    if (dados_login == txt_login.Text && dados_senha == txt_senha.Text)
                    {
                        lbl_status.Text = "...";
                        form2_1_Options.Show();
                    }
                }
                else
                {
                    lbl_status.Text = "Dados incorretos";
                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
            }
            conexao.Close();
        }

        private void strip_configurarDB_Click(object sender, EventArgs e)
        {
            Form1_3_configurarDB form1_3_configurarDB = new Form1_3_configurarDB();
            form1_3_configurarDB.Show();
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
