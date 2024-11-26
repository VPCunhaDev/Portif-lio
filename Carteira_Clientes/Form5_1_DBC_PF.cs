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
    public partial class Form5_1_DBC_PF : Form
    {
        public Form5_1_DBC_PF()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
                    string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
                    string dbce_login = @"DataSource= " + dbce_pasta + ";Password='vpcunha123'";
                    SqlCeConnection conexao = new SqlCeConnection(dbce_login);
                    DataTable dados = new DataTable();

            if (txt_nome.Text =="" && txt_email.Text == "")
            {
                lbl_status_filtro.Text = "Preencha um dos campos acima !";
            }
            else if (txt_email.Text == "")
            {
                try
                {
                    dgview_pf.Rows.Clear();
                    string nome = txt_nome.Text;
                    string query = "SELECT* FROM cliente_pessoa_fisica WHERE NOME = '"+nome+"'";
                    SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(query,conexao);
                    conexao.Open();
                    ceDataAdapter.Fill(dados);

                    foreach (DataRow dado in dados.Rows)
                    {
                        dgview_pf.Rows.Add(dado.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    lbl_status_filtro.Text = ex.Message;
                }
                txt_nome.Clear();
                conexao.Close();
            }
            else
            {
                try
                {
                    dgview_pf.Rows.Clear();
                    string email = txt_email.Text;
                    string query = "SELECT* FROM cliente_pessoa_fisica WHERE NOME = '"+email+"'";
                    SqlCeDataAdapter ceAdapter = new SqlCeDataAdapter(query, conexao);
                    conexao.Open();
                    ceAdapter.Fill(dados);

                    foreach (DataRow dado in dados.Rows)
                    {
                        dgview_pf.Rows.Add(dado.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    lbl_status_filtro.Text = ex.Message;
                }
                txt_email.Clear();
                conexao.Close();
            }
        }

        private void btn_todos_cadastros_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath +@"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource=" +dbce_pasta + ";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            DataTable dados = new DataTable();

            try
            {
                dgview_pf.Rows.Clear();
                string query = "SELECT*FROM cliente_pessoa_fisica";
                SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(query, conexao);
                conexao.Open();
                ceDataAdapter.Fill(dados);

                foreach (DataRow dado in dados.Rows)
                {
                    dgview_pf.Rows.Add(dado.ItemArray);
                }
                lbl_status_dois.Text = "Dados obtidos com sucesso !";
            }
            catch (Exception ex) 
            {
                lbl_status_dois.Text = ex.Message;
                conexao.Close();
            }
        }
    }
}
