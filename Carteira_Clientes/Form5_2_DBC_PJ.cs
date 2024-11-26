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
    public partial class Form5_2_DBC_PJ : Form
    {
        public Form5_2_DBC_PJ()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (masked_cnpj.Text == "" && txt_email.Text == "")
            {
                lbl_filtro.Text = "Preencha um dos campos acima !";
            }
        }

        private void btn_todos_cadastros_Click(object sender, EventArgs e)
        {
            string dbce_pasta = Application.StartupPath + @"\vpcunha_carteira_dbce.sdf";
            string dbce_login = @"DataSource="+dbce_pasta+";Password='vpcunha123'";
            SqlCeConnection conexao = new SqlCeConnection(dbce_login);
            DataTable dados = new DataTable();

            try
            {
                dgview_pj.Rows.Clear();
                string query = "SELECT*FROM cliente_pessoa_juridica";
                conexao.Open();
                SqlCeDataAdapter ceDataAdapter = new SqlCeDataAdapter(query,conexao);
                ceDataAdapter.Fill(dados);

                foreach (DataRow dado in dados.Rows)
                {
                    dgview_pj.Rows.Add(dado.ItemArray);
                }

                if (dados.ToString() == "")
                {
                    lbl_status_dois.Text = "Nenhum dado cadastrado no banco !";
                }
                else
                {
                    lbl_status_dois.Text = "Dados obtido com sucesso !";
                }
            }
            catch (Exception ex) 
            {
                lbl_status_dois.Text = ex.Message;
            }
        }
    }
}
