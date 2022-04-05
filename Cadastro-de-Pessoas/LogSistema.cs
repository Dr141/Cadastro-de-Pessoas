using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Pessoas
{
    internal class LogSistema
    {
        public string nomeArquivo { get; private set; } 
        public string srtArquivo { get; private set; }
        
        public bool InicaArquivo()
        {
            this.nomeArquivo = DateTime.Now.ToString() + ".log";
            this.srtArquivo = Application.StartupPath + this.nomeArquivo;
            
            try
            {
                if (!File.Exists(this.srtArquivo))
                {
                    StreamWriter stream = new StreamWriter(this.srtArquivo);
                    stream.Write("##------------------Inicio------------------##");
                    stream.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o arquivo .log. " + ex.Message);
                return false;
            }
        }

        public void Escrever(string mensagem)
        {
            if (this.InicaArquivo())
            {
                StreamWriter writer = new StreamWriter(this.srtArquivo);

                StreamReader reader = new StreamReader(this.srtArquivo);

                
            }
        }
    }
}
