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
    class Turma
    {       
        #region Variáveis (atributos)

        string _Nome, _Curso, _Duracao;

        int? _AnoInicio, _SemestreIngresso, _NumeroAlunos, _IdCurso;

        DateTime _DataCadastro;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        public Turma(string nome, string curso, string duracao, int? anoInicio, 
                     int? semestreIngresso, int? numeroAlunos, int? idCurso, 
                     DateTime dataCadastro)
        {
            _Nome = nome;
            _Curso = curso;
            _Duracao = duracao;
            _AnoInicio = anoInicio;
            _SemestreIngresso = semestreIngresso;
            _NumeroAlunos = numeroAlunos;
            _IdCurso = idCurso;
            _DataCadastro = dataCadastro;
        }

        #endregion

        //sobrecarga do construtor
        public Turma()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(string nome, string curso, string duracao, int? anoInicio,
                             int? semestreIngresso, int? numeroAlunos, int? idCurso,
                             DateTime dataCadastro)
        {
            try
            {
                string sql = "INSERT INTO turma (NOME, CURSO, DURACAO, ANO_INICIO, " +
                                                "SEMESTRE_INGRESSO, N_ALUNOS, ID_CURSO, " +
                                                "DATA_CADASTRO) " +
                             "VALUES (@NOME, @CURSO, @DURACAO, @ANO_INICIO, " +
                                     "@SEMESTRE_INGRESSO, @N_ALUNOS, @ID_CURSO, " +
                                     "@DATA_CADASTRO)";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@CURSO", curso);
                cmd.Parameters.AddWithValue("@DURACAO", duracao);
                cmd.Parameters.AddWithValue("@ANO_INICIO", anoInicio);
                cmd.Parameters.AddWithValue("@SEMESTRE_INGRESSO", semestreIngresso);
                cmd.Parameters.AddWithValue("@N_ALUNOS", numeroAlunos);
                cmd.Parameters.AddWithValue("@ID_CURSO", idCurso);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataCadastro);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Turma cadastrada!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar turma!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)
        
        public string Altera(string idTurma, string nome, string curso, string duracao, int? anoInicio,
                             int? semestreIngresso, int? numeroAlunos, int? idCurso)
                             
        {
            try
            {
                string sql = "UPDATE turma " +
                             "SET NOME = @NOME, " + 
                             "CURSO = @CURSO, " +
                             "DURACAO = @DURACAO, " +
                             "ANO_INICIO = @ANO_INICIO, " +
                             "SEMESTRE_INGRESSO = @SEMESTRE_INGRESSO, " +
                             "N_ALUNOS = @N_ALUNOS, " +
                             "ID_CURSO = @ID_CURSO " +
                             "WHERE ID_TURMA = " + idTurma;                

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@CURSO", curso);
                cmd.Parameters.AddWithValue("@DURACAO", duracao);
                cmd.Parameters.AddWithValue("@ANO_INICIO", anoInicio);
                cmd.Parameters.AddWithValue("@SEMESTRE_INGRESSO", semestreIngresso);
                cmd.Parameters.AddWithValue("@N_ALUNOS", numeroAlunos);
                cmd.Parameters.AddWithValue("@ID_CURSO", idCurso);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados do Turma!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para consultar nomes das turmas (SELECT) [DataTable]

        public DataTable NomeTurma(int? idCurso)
        {
            try
            {
                DataSet dset = new DataSet();

                DataTable dt = new DataTable();

                string sql = " SELECT NOME FROM turma " + 
                             " WHERE ID_CURSO = " + idCurso;

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dset);

                dt = dset.Tables[0];

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar os nomes das turmas : \n" + ex.Message);

                return null;
            }
        }

        #endregion
    }
}
