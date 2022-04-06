using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Pessoas
{
    public class LogSistema
    {
        public string nomeArquivo { get; private set; } 
        
        public bool InicaArquivo()
        {
            this.nomeArquivo = "Dia_" + DateTime.Now.ToString().Remove(10).Replace("/", "") + ".log";
            
            try
            {
                if (!File.Exists(this.nomeArquivo))
                {
                    FileStream file = new FileStream(nomeArquivo, FileMode.Create);
                    file.Close();    
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
                FileStream file = new FileStream(nomeArquivo, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine( DateTime.Now.ToString() + ". " + mensagem); 
                writer.Close();
                file.Close();
            }
        }
    }
}
