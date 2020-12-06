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
    class EmissaoAtendimento
    {
        #region Atributos/Variáveis

        string _Encaminhado, _Requerente, _Relato, _Providencias, _Status, _ProntuarioAluno;

        #endregion

        #region Instanciando o banco

        Banco bd = new Banco();

        #endregion

        #region Método construtor

        public EmissaoAtendimento(string encaminhado, string requerente, string relato, string providencias, 
                                  string status, string prontuarioAluno)
        {
            _Encaminhado = encaminhado;
            _Requerente = requerente;
            _Relato = relato;
            _Providencias = providencias;
            _Status = status;
            _ProntuarioAluno = prontuarioAluno;
        }

        #endregion

        //sobrecarga do construtor
        public EmissaoAtendimento()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(string encaminhado, string requerente, string relato, string providencias,
                             string status, string prontuarioAluno)
        {
            try
            {
                string sql = "INSERT INTO emissao_atendimento (ENCAMINHADO, REQUERENTE, RELATO, " +
                                                              "PROVIDENCIAS, STATUS, PRONTUARIO_ALUNO, PRONTUARIO_FUNCIONARIO) " + 
                            "VALUES (@ENCAMINHADO, @REQUERENTE, @RELATO, @PROVIDENCIAS, @STATUS, " +
                                    "@PRONTUARIO_ALUNO, '123456')";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@ENCAMINHADO", encaminhado);
                cmd.Parameters.AddWithValue("@REQUERENTE", requerente);
                cmd.Parameters.AddWithValue("@RELATO", relato);
                cmd.Parameters.AddWithValue("@PROVIDENCIAS", providencias);
                cmd.Parameters.AddWithValue("@STATUS", status);
                cmd.Parameters.AddWithValue("@PRONTUARIO_ALUNO", prontuarioAluno);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Atendimento emitido!";
            }
            catch (Exception ex)
            {
                return "Falha ao emitir atendimento" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)

        public string Altera(string idEmissao, string status)
        {
            try
            {
                string sql = "UPDATE emissao_atendimento " +
                             "SET STATUS = @STATUS " +
                             "WHERE ID_EMISSAO = " + idEmissao;

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@STATUS", status);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Status alterado!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar status da Emissão!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método pra pegar os IDs da Emissão (SELECT) [DataTable]

        public DataTable GetIDCount()
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT ID_EMISSAO " +
                             "FROM emissao_atendimento";

                MySqlConnection cnn = bd.Conecta();

                MySqlCommand cmd = new MySqlCommand(sql, cnn);

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar número de IDs : \n" + ex.Message);

                return null;
            }
        }

        #endregion

        #region Método para pegar o histórico de emissões do aluno (SELECT) [DataTable]

        public DataTable HistoricoAluno(string prontuarioAluno)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM emissao_atendimento " +
                             "WHERE PRONTUARIO_ALUNO = " + "'" + prontuarioAluno + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dt);

                da.Dispose();

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o histórico do aluno \n" + ex.Message);

                return null;
            }
        }

        #endregion
    }
}
