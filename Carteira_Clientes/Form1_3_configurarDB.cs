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
    public partial class Form1_3_configurarDB : Form
    {
        public Form1_3_configurarDB()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_criar_DB_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";

            SqlCeEngine dbce = new SqlCeEngine(dbce_login);
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);

            if (!File.Exists(dbce_pasta))
            {
                dbce.CreateDatabase();

                try
                {
                    SqlCeCommand comando = new SqlCeCommand();
                    conexao.Open();
                    comando.Connection = conexao;
                    comando.CommandText = "CREATE TABLE usuarios_login (nome NVARCHAR(20), sobrenome NVARCHAR(40), email NVARCHAR(50), celular int, login NVARCHAR(10) PRIMARY KEY NOT NULL, senha NVARCHAR(5) NOT NULL)";
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexao.Close();
                    lbl_status_db.Text = "DataBase criado com sucesso !";
                }
                catch (Exception ex) 
                {
                    lbl_status_db.Text = ex.Message;
                }
            }
            else
            {
                lbl_status_db.Text = "DataBase já criado !";
            }
        }

        private void btn_pf_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            SqlCeCommand comando = new SqlCeCommand();

            try
            {
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE cliente_pessoa_fisica (nome NVARCHAR(20), sobrenome NVARCHAR(50), email NVARCHAR(50) PRIMARY KEY NOT NULL, celular int)";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
                lbl_status_tabela.Text = "Tabela criada com sucesso !";
            }
            catch (Exception ex) { lbl_status_tabela.Text = ex.Message; }
        }

        private void btn_pj_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            SqlCeCommand comando = new SqlCeCommand();

            try
            {
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE cliente_pessoa_juridica(nome NVARCHAR(20), email NVARCHAR(50), cnpj INT PRIMARY KEY NOT NULL, celular INT)";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();
                lbl_status_tabela.Text = "Tabela criada com sucesso !";
            }
            catch (Exception ex)
            {
                lbl_status_tabela.Text= ex.Message;
            }
        }
    }
}
