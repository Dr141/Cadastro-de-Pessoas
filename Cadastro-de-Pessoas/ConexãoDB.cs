using System;
using System.Collections.Generic;
using System.Data;
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
        private string caminhoDB { get;} = Application.StartupPath + @"\CadastroPessoas.sdf";
        private string strConecxao { get; set; } 

        public void CriarDB()
        {
            this.strConecxao = "DataSource=" + caminhoDB + ";Password=1234";
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
                        cmd.CommandText = "CREATE TABLE PESSOAS (CPF NVARCHAR(11) NOT NULL PRIMARY KEY, NOME NVARCHAR(100) NOT NULL, DATA_NASCIMENTO NVARCHAR(18), CIDADE_NASCIMENTO NVARCHAR(100), UF_NASCIMENTO nchar(2))";
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
        public bool Insert(string cpf, string nome, string dt_nascimento, string cidade, string uf)
        {
            string valores = $"('{cpf}', '{nome}', '{dt_nascimento}', '{cidade}', '{uf}');";
            var resultado = false;
            string caminhoDB = Application.StartupPath + @"\CadastroPessoas.sdf";
            string strConecxao = "DataSource=" + caminhoDB + ";Password=1234";

            SqlCeConnection sqlCeConnection = new SqlCeConnection();
            SqlCeCommand sqlCeCommand = new SqlCeCommand();

            try
            {
                sqlCeConnection.ConnectionString = strConecxao;
                sqlCeConnection.Open();
                
                sqlCeCommand.Connection = sqlCeConnection;
                sqlCeCommand.CommandText = "INSERT INTO PESSOAS (CPF, NOME, DATA_NASCIMENTO, CIDADE_NASCIMENTO, UF_NASCIMENTO) VALUES " + valores;
                sqlCeCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na inserção de dados. " + ex.Message);
                resultado = false;
            }
            finally
            {
                sqlCeCommand.Dispose();
                sqlCeConnection.Close();
            }

            return resultado;
        }

        public DataTable Consulta()
        {
            string caminhoDB = Application.StartupPath + @"\CadastroPessoas.sdf";
            string strConecxao = "DataSource=" + caminhoDB + ";Password=1234";
            DataTable dados = new DataTable();
            SqlCeConnection sqlCeConnection = new SqlCeConnection();

            try
            {
                string query = "SELECT *FROM PESSOAS";
                sqlCeConnection.ConnectionString = strConecxao;
                sqlCeConnection.Open ();
                SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter(query, sqlCeConnection);
                sqlCeDataAdapter.Fill(dados);
                sqlCeDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar select. " + ex.Message);
            }
            finally
            {
                sqlCeConnection.Close ();
            }
            return dados;
        }

        public void Excluir(String cpf)
        {
            string valores = $"'{cpf}';";
            string caminhoDB = Application.StartupPath + @"\CadastroPessoas.sdf";
            string strConecxao = "DataSource=" + caminhoDB + ";Password=1234";

            SqlCeConnection sqlCeConnection = new SqlCeConnection();
            SqlCeCommand sqlCeCommand = new SqlCeCommand();

            try
            {
                sqlCeConnection.ConnectionString = strConecxao;
                sqlCeConnection.Open();

                sqlCeCommand.Connection = sqlCeConnection;
                sqlCeCommand.CommandText = "DELETE FROM PESSOAS WHERE CPF = " + valores;
                sqlCeCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na exclusão de dados. " + ex.Message);
            }
            finally
            {
                sqlCeCommand.Dispose();
                sqlCeConnection.Close();
            }
        }

        public void alteracao(string cpf, string nome, string dt_nascimento, string cidade, string uf)
        {
            string valores = $"CPF = '{cpf}', NOME = '{nome}', DATA_NASCIMENTO = '{dt_nascimento}', CIDADE_NASCIMENTO = '{cidade}', UF_NASCIMENTO = '{uf}'";
            
            SqlCeConnection sqlCeConnection = new SqlCeConnection();
            SqlCeCommand sqlCeCommand = new SqlCeCommand();

            try
            {
                sqlCeConnection.ConnectionString = strConecxao;
                sqlCeConnection.Open();

                sqlCeCommand.Connection = sqlCeConnection;
                sqlCeCommand.CommandText = "UPDATE PESSOAS SET " + valores + $"WHERE CPF ='{cpf}';";
                sqlCeCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na alteração de dados. " + ex.Message);
            }
            finally
            {
                sqlCeCommand.Dispose();
                sqlCeConnection.Close();
            }
        }
    }
}
