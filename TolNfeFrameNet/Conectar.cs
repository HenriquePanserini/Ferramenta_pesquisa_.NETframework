using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace TolNfeFrameNet
{
    class Conectar
    {


        public static string line;
       

        public static string readwrite()
        {
            try
            {

                //Caminho de para o text
                const string caminho = ("C:\\Users\\User\\source\\repos\\TolNfeFrameNet\\conectar.txt");
                //Busca o arquivo txt conectar
                 
                StreamReader sr = new StreamReader(caminho);

                //Le cada linha do arquivo txt
                do
                {
                    Console.WriteLine(line);
                    line = line + sr.ReadLine() + ";";

                } while (!sr.EndOfStream);

                //Retira ponto e virgula final da leitura de arquivo .txt
                var redLine = line.Remove(line.Length-1);
                sr.Close();
                Console.ReadLine();
                //Retorna valor da leitura do arquivo .txt
                return redLine;
            }
            catch (EndOfStreamException ex)
            {

                //Mensagem de console de erro na leitura de arquivo
                Console.WriteLine("Exception: " + ex.Message);
                return null;

            }
            finally
            {

                Console.WriteLine("Executing finally block.");
                
            }

        }

        public static MySqlConnection GetConnection()
        {
            //Leitura de arquivo .txt de conexão
            string readConect = readwrite().Trim();
            MySqlConnection sqlConnection = new MySqlConnection(readConect);
            try
            {

                //Abertura de conexão com o banco de dados
                sqlConnection.Open();
                //Status do banco de dados
                var alertConect = sqlConnection.State;
                Console.WriteLine("Conexao obtida com  MySQl/Status: " + alertConect);

            }
            catch (MySqlException ex)
            {

                //Mensagem de erro de banco de dados nao conectado
                var alertConect = sqlConnection.State;
                MessageBox.Show("Conexao MySQl: '\n'" + ex.Message + " Status: " + alertConect, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
      
            //Retorno do valor da conexão
            return sqlConnection;
        }

        public static MySqlCommand EXEC_QUERY(string query)
        {

            MySqlConnection exeConect = GetConnection();
            try
            {

                //Instancia a classe conectar
                Conectar conexao = new Conectar();
                //Comando para execução da Query
                MySqlCommand comando = new MySqlCommand(Convert.ToString(query), exeConect);
                //Adaptador de dados para a tabela
                comando.ExecuteNonQuery();
                return comando;

            }
            catch (MySqlException ex)
            {

                //Se conexao nao for estabelecida
                MessageBox.Show("Conexão não foi estabelecida: " + ex.Message);
                Conectar conexao = new Conectar();
                var connectionState = exeConect.State;
                return null;

            }
          


        }


    }
    
}
