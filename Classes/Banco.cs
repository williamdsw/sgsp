using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--
using System.Data;              
using System.IO;                
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;


namespace SGSP___Desktop
{
    class Banco
    {
        #region Atributos/Variáveis

        //_Servidor = "10.114.50.231", _Usuario = "desktop",_Senha = "desktop", _Banco = "SGSP_DESKTOP";
        protected string _Servidor = "10.114.50.231", _Usuario = "desktop",
                         _Senha = "desktop";

        string _Banco = "SGSP_DESKTOP";

        //objeto do tipo da conexão do mysql
        MySqlConnection conexao = new MySqlConnection();

        #endregion          

        #region Método construtor

        public Banco()
        {}

        #endregion          

        #region String de Conexão [string]

        private string MontaString()
        {
            //Essa é uma string que monta os valores das variáveis para seus parâmetros para Conectar ao BD

            return " SERVER = " + _Servidor + ";" + " DATABASE = " + _Banco + ";" +
                   " PORT=3306;" + " UID = " + _Usuario + ";" + " PASSWORD = " + _Senha + ";" +
                   " ALLOW USER VARIABLES=TRUE;";      
        }

        #endregion

        #region Método de conexão [MySqlConnection]

        public MySqlConnection Conecta()
        {
            //esse é um método para Conectar ao banco.
            //primeiro instância-se uma nova conexão
            
            conexao = new MySqlConnection(MontaString());

            //utilizando o objeto de conexão, utiliza-se o método Open() para abrir essa conexão

            conexao.Open();    

            return conexao;
        }

        #endregion

        #region Método de desconexão [void]

        public void Desconecta(MySqlConnection conexao)
        {
            //Utiliza-se esse método para Desconectar do banco, usando o método Close()

            conexao.Close();         
        }
           
        #endregion

        //--------------------------------SELECT----------------------------------------------//

        #region Método para fazer a filtragem da tabela (SELECT) [DataTable]

        public DataTable Filtra(string tabela, string parametro, string palavraChave)
        {
            try
            {
                //comando SQL
                string cmd = "SELECT * FROM " + tabela +
                             " WHERE " + parametro + " LIKE " + "'" + palavraChave + "%'";

                //um DataAdapter que usa a string cmd e o método para conectar
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd, Conecta());

                DataTable dt = new DataTable();

                //Método Fill() do DataAdapter é usado para preencher um DataTable
                ad.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer filtragem da tabela \n" + ex.Message);

                return null;
            }
            finally
            {
                Desconecta(conexao);
            }
        }

        #endregion

        #region Método de consulta de dados (SELECT) [DataTable] 

        public DataTable Consulta(string tabela)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM " + tabela;

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados : \n" + ex.Message);

                return null;
            }
        }

        #endregion
        
        #region Método para consultar nomes (SELECT) [DataTable]

        public DataTable ConsultaNome(string tabela)
        {
            try
            {
                //cria um DataSet
                DataSet dset = new DataSet();

                //cria um DataTable
                DataTable dt = new DataTable();

                string sql = "SELECT NOME FROM " + tabela;

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dset);

                //seta os valores do DataTable de acordo com os valores da "tabela 0" do DataSet
                dt = dset.Tables[0];

                Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar os nomes : \n" + ex.Message);

                return null;
            }
        }

        #endregion

        #region Método para retornar ID (SELECT) [int]

        public int GetID(string nome, string campo, string tabela)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = " SELECT " + campo + " FROM " + tabela +
                             " WHERE NOME = " + "'" + nome + "'";

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                //id vai receber o valor de dr junto com a "tabela" dentro dos []
                int id = Convert.ToInt16(dr[campo]);

                Desconecta(cmd.Connection);

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar o código : \n" + ex.Message);

                return 0;
            }
        }

        #endregion

        #region Método para retornar o nome do usuário (SELECT) [string]

        public string GetNome(string campo, string prontuario, string tabela)
        {
            try
            {
                string sql = " SELECT NOME FROM " + tabela +
                             " WHERE " + campo + " = " + "'" + prontuario + "'";

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string nome = dr["NOME"].ToString();

                Desconecta(cmd.Connection);
          
                return nome;
            }
            catch (Exception ex)
            {
                return "Erro ao retornar os nomes \n" + ex.Message;
            }
        }

        #endregion

        #region Método para retornar Prontuário (SELECT) [string]

        public string GetProntuario(string campo, string valor, string tabela)
        {
            try
            {
                string sql = " SELECT PRONTUARIO FROM " + tabela +
                             " WHERE " + campo + " = " + "'" + valor + "'";

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string prontuario = dr["PRONTUARIO"].ToString(); ;

                Desconecta(cmd.Connection);

                return prontuario;
            }
            catch (Exception ex)
            {
                return "Erro ao retornar prontuário \n" + ex.Message;
            }
        }

        #endregion

        #region Método de verficação de existência de aluno/funcionário/usuário (SELECT) [bool]

        public bool Verifica(string campo, string tabela, string valor)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT " + campo + " FROM " + tabela +
                             " WHERE " + campo + " = " + "@" + campo;

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                cmd.Parameters.AddWithValue("@" + campo, valor);

                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(dt);
                da.Dispose();

                Desconecta(cmd.Connection);

                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar autenticação do login : \n" + ex.Message);

                return false;
            }
        }

        #endregion

        #region Método para consultar nomes das colunas (SELECT) [List<>]

        public List<string> NomeColunas(string tabela)
        {
            try
            {
                //Cria um DataSet
                DataSet dset = new DataSet();

                //instrução SQL
                string sql = "SELECT * FROM " + tabela;

                //novo comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                //novo DataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter();

                //atribuindo o comando
                da.SelectCommand = cmd;

                //preenchendo o DatSet
                da.Fill(dset);

                //criando um List que receberá os nomes das colunas
                List<string> colunas = new List<string>();

                //preenchendo o List
                foreach (DataColumn clm in dset.Tables[0].Columns)
                {
                    colunas.Add(clm.ToString());
                }

                Desconecta(cmd.Connection);

                return colunas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar as colunas da tabela : \n" + ex.Message);

                return null;
            }
        }

        #endregion

        //--------------------------------DELETE----------------------------------------------//

        #region Método para apagar dados (DELETE) [string]

        public string Apaga(string tabela, string campo, string valor)
        {
            try
            {
                string sql = " DELETE FROM " + tabela +
                             " WHERE " + campo + " = " + "'" + valor + "'";

                MySqlCommand cmd = new MySqlCommand(sql, Conecta());

                cmd.ExecuteNonQuery();

                Desconecta(cmd.Connection);

                return "Registro excluído";
            }
            catch (Exception ex)
            {
                return "Erro ao excluir registro!\n\n" + ex.Message;
            }
        }

        #endregion
    }
}
