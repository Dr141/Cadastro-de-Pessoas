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
        private int auxiliar = 0;
        private ConexãoDB dB = new ConexãoDB();
        private LogSistema log = new LogSistema();

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

            if ((tbNome.Text.Trim() != "") && (mtCPF.Text != ""))
            {
                if (this.auxiliar == 0 && dB.Insert(mtCPF.Text, tbNome.Text, mtData.Text, tbCidade.Text, cbUF.Text))
                {                    
                    this.habilitarBotao(1);
                    this.PreencherTabela(dB.Consulta());
                }
                else if (this.auxiliar == 1 && btAlterar.Text == "Cancelar")
                {
                    this.auxiliar = 0;
                    dB.alteracao(mtCPF.Text, tbNome.Text, mtData.Text, tbCidade.Text, cbUF.Text);
                    this.PreencherTabela(dB.Consulta());
                    this.habilitarBotao(1);
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
                    tbNome.Enabled = true;
                    mtCPF.Enabled = true;
                    tbCidade.Enabled = true;
                    cbUF.Enabled = true;
                    mtData.Enabled = true;
                    break;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (btAlterar.Text == "Cancelar")
            {
                this.habilitarBotao(1);
            }
            else if(btAlterar.Text == "Alterar")
            {
                this.auxiliar = 1;
                btAlterar.Text = "Cancelar";
                btIncluir.Text = "Gravar";
                btExcluir.Enabled = false;
                this.habilitarBotao(2);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string cpf = dgDadosPessoas.SelectedRows[0].Cells[0].Value.ToString();

            dB.Excluir(cpf);
            this.PreencherTabela(dB.Consulta());
        }

        private void dgDadosPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PreencherInforma();            
        }

        private void PreencherInforma()
        {
            try
            {
                mtCPF.Text = dgDadosPessoas.SelectedRows[0].Cells[0].Value.ToString();
                tbNome.Text = dgDadosPessoas.SelectedRows[0].Cells[0 + 1].Value.ToString();
                mtData.Text = dgDadosPessoas.SelectedRows[0].Cells[0 + 2].Value.ToString();
                tbCidade.Text = dgDadosPessoas.SelectedRows[0].Cells[0 + 3].Value.ToString();
                cbUF.Text = dgDadosPessoas.SelectedRows[0].Cells[0 + 4].Value.ToString();
                log.Escrever("Carregado informações na tela com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Escrever("Erro ao carregado informações na tela. " + ex.Message + ". " + ex.InnerException);
            }
            
        }
    }
}
