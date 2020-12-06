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
    class Notificacao
    {
        #region Variáveis (atributos)

        string _Assunto, _Mensagem, _Prioridade;

        int _IdRemetente, _IdDestinatario;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        public Notificacao(string assunto, string mensagem, string prioridade, int idRemetente, int idDestinatario)
        {
            _Assunto = assunto;
            _Mensagem = mensagem;
            _Prioridade = prioridade;
            _IdRemetente = idRemetente;
            _IdDestinatario = idDestinatario;
        }

        #endregion

        //sobrecarga do construtor
        public Notificacao()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(string assunto, string mensagem, string prioridade, int idRemetente, int idDestinatario)
        {
            try
            {
                //comando SQL
                string sql = "INSERT INTO notificacoes (ASSUNTO, MENSAGEM, PRIORIDADE, " +
                                                       "ID_REM, ID_DES, VISUALIZACAO, DATA_CADASTRO) " +
                             "VALUES (@ASSUNTO, @MENSAGEM, @PRIORIDADE, @ID_REM, @ID_DES, @VISUALIZACAO, @DATA_CADASTRO)";

                //cria um novo objeto de comando
                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                //variável para definir a hora do cadastro da notificação
                string dataHora = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " " +
                                  DateTime.Now.ToLongTimeString();

                //método AddWithValue() adiciona uma valor ao parametro do banco
                cmd.Parameters.AddWithValue("@ASSUNTO", assunto);
                cmd.Parameters.AddWithValue("@MENSAGEM", mensagem);
                cmd.Parameters.AddWithValue("@PRIORIDADE", prioridade);
                cmd.Parameters.AddWithValue("@ID_REM", idRemetente);
                cmd.Parameters.AddWithValue("@ID_DES", idDestinatario);
                cmd.Parameters.AddWithValue("@VISUALIZACAO", 0);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataHora);

                //método ExecuteNonQuery() executa um comando de não-consulta
                cmd.ExecuteNonQuery();

                //desconecta do banco
                bd.Desconecta(cmd.Connection);

                //retorna uma mensagem
                return "Notificação enviada!";
            }
            catch (Exception ex)
            {
                //retorna mensagem de erro
                return "Erro ao enviar notificação!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para atualizar dados (UPDATE)

        public string Altera(int idNotificacao)
        {
            try
            {
                //comando sql
                string sql = "UPDATE notificacoes " +
                             "SET VISUALIZACAO = 1 " +
                             "WHERE ID = " + idNotificacao;

                //cria um novo objeto de comando
                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                //método ExecuteNonQuery() executa um comando de não-consulta
                cmd.ExecuteNonQuery();

                //desconecta do banco
                bd.Desconecta(cmd.Connection);

                //retorna mensagem de erro
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

        #region Método de consulta de notificações (SELECT) [DataTable]

        public DataTable Notificacoes(int idDestinatario)
        {
            try
            {
                //cria um objeto do tipo DataTable
                DataTable dt = new DataTable();

                //comando SQL
                string sql = "SELECT * FROM notificacoes " +
                             "WHERE ID_DES = " + idDestinatario;

                //cria um objeto do tipo Command
                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                //cria um DataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter();

                //atribui o objeto do Command para o SelectCommand do DataAdapter
                da.SelectCommand = cmd;

                //preenche o DataTable
                da.Fill(dt);

                //desconecta do banco
                bd.Desconecta(cmd.Connection);

                //retorna os valores do DataTable
                return dt;
            }
            catch (Exception ex)
            {
                //retorna mensagem de erro
                MessageBox.Show("Erro ao consultar notificações: \n" + ex.Message);

                return null;
            }
        }

        #endregion

        #region Método de consulta de notificações novas(SELECT) [DataTable]

        public DataTable NotificacoesNovas(int idDestinatario)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = " SELECT * FROM notificacoes " +
                             " WHERE ID_DES = " + idDestinatario +
                             " AND VISUALIZACAO = 0";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar notificações novas : \n" + ex.Message);

                return null;
            }
        }

        #endregion

        #region Método de consulta de notificação simultânea(SELECT) [DataTable]

        public DataTable NotificacaoNova(int idDestinatario, out bool novaMensagem)
        {
            try
            {
                DataTable dt = new DataTable();

                string dataHora = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " " +
                                  DateTime.Now.ToLongTimeString();

                string sql = " SELECT * FROM notificacoes " +
                             " WHERE ID_DES = " + idDestinatario +
                             " AND VISUALIZACAO = 0 " +
                             " AND DATA_CADASTRO = " + "'" + dataHora + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                da.Dispose();

                if (dt.Rows.Count == 1)
                {
                    novaMensagem = true;
                }
                else
                {
                    novaMensagem = false;
                }

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar notificações : \n" + ex.Message);

                novaMensagem = false;

                return null;
            }
        }

        #endregion

        #region Método de consulta de notificação simultânea do encaminhamento (SELECT) [DataTable]

        public DataTable EncaminhamentoNovo(string nomeProfissional, out bool novoEncaminhamento)
        {
            try
            {
                DataTable dt = new DataTable();

                string dataHora = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + " " +
                                  DateTime.Now.ToLongTimeString();

                string sql = " SELECT * FROM agendamento " +
                             " WHERE NOME_PROFISSIONAL = " + "'" + nomeProfissional + "'" +
                             " AND DATA_CADASTRO = " + "'" + dataHora + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                da.Dispose();

                if (dt.Rows.Count == 1)
                {
                    novoEncaminhamento = true;
                }
                else
                {
                    novoEncaminhamento = false;
                }

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a notificação do encaminhamento : \n" + ex.Message);

                novoEncaminhamento = false;

                return null;
            }
        }

        #endregion
    }
}
