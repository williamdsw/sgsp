using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--
using System.Data;                  
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SGSP___Desktop
{
    class Login                
    {
        #region Atributos/Variáveis

        private string _Prontuario, _Senha, _Perfil, _Status;

        #endregion

        //Instanciamento do banco
        Banco bd = new Banco();

        #region Método Construtor

        public Login(string prontuario, string senha, string perfil, string status)
        {
            _Prontuario = prontuario;
            _Senha = senha;
            _Perfil = perfil;
            _Status = status;
        }

        #endregion

        //sobrecarga do construtor
        public Login()
        { }

        #region Método de inserção de dados (INSERT) [string]

        public string Insere(string prontuario, string senha, string perfil, string status)
        {
            try
            {
                //o método de criptografar as senhas usado é o ENCODE(valor, tipo da chave)
                //e para descriptografar é DECODE(valor, tipo da chave)

                string sql = " INSERT INTO login (PRONTUARIO, SENHA, PERFIL, STATUS)" +
                             " VALUES (@PRONTUARIO, ENCODE(@SENHA, 'minhaChave'), " +
                                      "@PERFIL, @STATUS)";

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@PRONTUARIO", prontuario);
                cmd.Parameters.AddWithValue("@SENHA", senha);
                cmd.Parameters.AddWithValue("@PERFIL", perfil);
                cmd.Parameters.AddWithValue("@STATUS", status);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Usuário cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar Usuário!\n\n" + ex.Message;
            }
        }

        #endregion
    
        #region Método para alterar dados (UPDATE) [string]

        public string Altera(string idLogin, string senha, string perfil, string status)
        {
            try
            {
                string sql = "UPDATE login " +
                             "SET SENHA = ENCODE(@SENHA, 'minhaChave'), " +
                             "PERFIL = @PERFIL, " +
                             "STATUS = @STATUS " +
                             "WHERE ID_LOGIN = " + idLogin;          //parâmetro do código do usuário

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@SENHA", senha);
                cmd.Parameters.AddWithValue("@PERFIL", perfil);
                cmd.Parameters.AddWithValue("@STATUS", status);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados do Login!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para retornar campos do Login (SELECT) [string]

        public string GetOutros(string pcampo, string prontuario)
        {
            try
            {
                string sql = " SELECT " + pcampo + " FROM login" +
                             " WHERE PRONTUARIO = " + "'" + prontuario + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string campo = dr[pcampo].ToString();

                bd.Desconecta(cmd.Connection);

                return campo;
            }
            catch (Exception ex)
            {
                return "Erro ao retornar dados : " + ex.Message;
            }
        }

        #endregion

        #region Método de verificação de login (SELECT) [bool]

        public bool VerificaLogin(string prontuario, string senha)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT PRONTUARIO FROM login " +
                             "WHERE PRONTUARIO = @PRONTUARIO " +
                             "AND DECODE(SENHA, 'minhaChave') = @SENHA";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@PRONTUARIO", prontuario);
                cmd.Parameters.AddWithValue("@SENHA", senha);

                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                da.Dispose();

                bd.Desconecta(cmd.Connection);

                //se retornar uma linha com o nome e senha do usuário, então irá acessar o sistema
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }        
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao verificar a autenticação do usuário : \n" + ex.Message);

                return false;
            }
        }

        #endregion

        #region Método para retornar ID do Login (SELECT) [int]

        public int GetIDLogin(string prontuario)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = " SELECT ID_LOGIN FROM login" +
                             " WHERE PRONTUARIO = " + "'" + prontuario + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                int id = Convert.ToInt16(dr["ID_LOGIN"]);

                bd.Desconecta(cmd.Connection);

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o ID do login : \n" + ex.Message);

                return 0;
            }
        }

        #endregion
    }
}
