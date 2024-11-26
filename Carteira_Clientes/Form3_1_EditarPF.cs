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
    public partial class Form3_1_EditarPF : Form
    {
        public Form3_1_EditarPF()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_pesquisar_nome.Text == "" && txt_pesquisar_email.Text == "")
            {
                try
                {
                    string dbce_pasta = Application.StartupPath + @"\vpcunha_clientes.sdf";
                    string dbce_login = @"DataSource=" + dbce_pasta + ";Password='vpcunha123'";
                    string dbce_pesquisar = "SELECT* FROM acesso_usuarios";

                    SqlCeConnection conexao = new SqlCeConnection(dbce_login);
                    SqlCeDataAdapter pesquisar_pf = new SqlCeDataAdapter(dbce_pesquisar, conexao);

                    DataTable dados = new DataTable();

                    conexao.Open();
                    pesquisar_pf.Fill(dados);

                    foreach (DataRow dado in dados.Rows)
                    {
                        dgview_resultados_pf.Rows.Add(dado.ItemArray);
                    }
                    conexao.Close();
                }
                catch (Exception ex) {
                    lbl_erro.Text = ex.Message;
                }

            }
        }
    }
}
