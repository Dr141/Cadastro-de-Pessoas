using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Pessoas
{
    public class ConexãoDB
    {
        public ConexãoDB()
        {
            string caminhoDB = Application.StartupPath + @"\CadastroPessoas.sdf";
            string strConecxao = "DataSource=" + caminhoDB + ";Password=1234";
            SqlCeEngine sqlCeEngine = new SqlCeEngine();

            try
            {
                sqlCeEngine.LocalConnectionString = strConecxao;

                if (!File.Exists(caminhoDB))
                {
                    sqlCeEngine.CreateDatabase();

                    SqlCeConnection sqlCeConnection = new SqlCeConnection();
                    SqlCeCommand cmd = new SqlCeCommand();

                    try
                    {
                        sqlCeConnection.ConnectionString = strConecxao;
                        sqlCeConnection.Open();
                        cmd.Connection = sqlCeConnection;
                        cmd.CommandText = "CREATE TABLE PESSOAS (CPF integer NOT NULL PRIMARY KEY, NOME NVARCHAR(100) NOT NULL, DATA_NASCIMENTO NVARCHAR(18), CIDADE_NASCIMENTO NVARCHAR(100), UF_NASCIMENTO nchar(2))";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar criar DB. " + ex.Message);
                    }
                    finally
                    {
                        sqlCeConnection.Close();
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar encontrar o DB. " + ex.Message);
            }
            finally
            {
                sqlCeEngine.Dispose();
            }            
        }
    }
}
