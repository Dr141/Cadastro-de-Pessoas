using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Diagnostics;

namespace Cadastro_de_Pessoas
{
    public partial class Form1 : Form
    {
        ConexãoDB dB = new ConexãoDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dB.CriarDB();
            this.PreencherTabela(dB.Consulta());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btIncluir.Text = "Gravar";
            btAlterar.Text = "Cancelar";
            this.habilitarBotao(0);

            if ( (tbNome.Text.Trim() != "") && (mtCPF.Text != ""))
            {
                if (dB.Insert(mtCPF.Text, tbNome.Text, mtData.Text, tbCidade.Text, cbUF.Text))
                {                    
                    this.habilitarBotao(1);
                    this.PreencherTabela(dB.Consulta());
                }
            }           
        }


        private void habilitarBotao(int x)
        {
            switch (x)
            {
                case 0:
                    tbNome.Enabled = true;
                    mtCPF.Enabled = true;
                    mtData.Enabled = true;
                    tbNome.Enabled = true;
                    cbUF.Enabled = true;
                    tbCidade.Enabled = true;
                    btExcluir.Enabled = false;
                    break;
                case 1:
                    tbNome.Text = "";
                    mtCPF.Text = "";
                    tbCidade.Text = "";
                    cbUF.Text = "";
                    mtData.Text = "";
                    tbNome.Enabled = false;
                    mtCPF.Enabled = false;
                    mtData.Enabled = false;
                    tbNome.Enabled = false;
                    cbUF.Enabled = false;
                    tbCidade.Enabled = false;
                    btExcluir.Enabled = true;
                    btIncluir.Text = "Incluir";
                    btAlterar.Text = "Alterar";
                    break;
                case 2:
                    break;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (btAlterar.Text == "Cancelar")
            {
                this.habilitarBotao(1);
            }
        }

        private void PreencherTabela(DataTable dados)
        {
            dgDadosPessoas.Rows.Clear();
            foreach (DataRow dr in dados.Rows)
            {
                dgDadosPessoas.Rows.Add(dr.ItemArray);
            }
        }

        private void dgDadosPessoas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           //tbNome.Text = dgDadosPessoas.SelectedRows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string cpf = dgDadosPessoas.SelectedRows[0].Cells[0].Value.ToString();

            dB.Excluir(cpf);
            this.PreencherTabela(dB.Consulta());
        }
    }
}
