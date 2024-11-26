using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpcunha_clientes
{
    public partial class Form2_1_options : Form
    {
        public Form2_1_options()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2_2_CadastrarPF form2_2_cadastrarPF = new Form2_2_CadastrarPF();
            form2_2_cadastrarPF.Show();
        }

        private void pJToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2_3_CadastrarPJ form2_3_cadastrarPJ = new Form2_3_CadastrarPJ();
            form2_3_cadastrarPJ.Show();
        }

        private void pFToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3_1_EditarPF form3_1_EditarPF = new Form3_1_EditarPF();
            form3_1_EditarPF.Show();
        }

        private void pJToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3_2_EditarPJ form3_2_EditarPJ = new Form3_2_EditarPJ();
            form3_2_EditarPJ.Show();
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3_3_EditarProcurar form3_3_EditarProcurar = new Form3_3_EditarProcurar();
            form3_3_EditarProcurar.Show();
        }

        private void pFToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form4_1_ExcluirPF form4_1_ExcluirPF = new Form4_1_ExcluirPF();
            form4_1_ExcluirPF.Show();
        }

        private void pJToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form4_2_ExcluirPJ form4_2_ExcluirPJ = new Form4_2_ExcluirPJ();
            form4_2_ExcluirPJ.Show();
        }

        private void procurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4_3_ExcluirProcurar form4_3_ExcluirProcurar = new Form4_3_ExcluirProcurar();
            form4_3_ExcluirProcurar.Show();
        }

        private void pFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_1_DBC_PF form5_1_DBC_PF = new Form5_1_DBC_PF();
            form5_1_DBC_PF.Show();
        }

        private void pJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_2_DBC_PJ form5_2_DBC_PJ = new Form5_2_DBC_PJ();
            form5_2_DBC_PJ.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5_3_DBC_all form5_3_DBC_all = new Form5_3_DBC_all();
            form5_3_DBC_all.Show();
        }
    }
}
