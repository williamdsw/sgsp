using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--
using System.Data;                  
using MySql.Data.MySqlClient;     

namespace SGSP___Desktop
{
    class Curso
    {
        #region Variáveis (atributos)

        string _Nome, _Periodo, _Nivel;

        DateTime _DataCadastro;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        public Curso(string nome, string periodo, string nivel, DateTime dataCadastro)
        {
            _Nome = nome;
            _Periodo = periodo;
            _Nivel = nivel;
            _DataCadastro = dataCadastro;
        }

        #endregion

        //sobrecarga do construtor
        public Curso()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(string nome, string periodo, string nivel, DateTime dataCadastro)
        {
            try
            {
                string sql = "INSERT INTO curso (NOME, PERIODO, NIVEL, DATA_CADASTRO) " +
                             "VALUES (@NOME, @PERIODO, @NIVEL, @DATA_CADASTRO) ";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@PERIODO", periodo);
                cmd.Parameters.AddWithValue("@NIVEL", nivel);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataCadastro);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Curso cadastrado!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar curso!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)
        
        public string Altera(string idCurso, string nome, string nivel, string periodo)
        {
            try
            {
                string sql = "UPDATE curso " +
                             "SET NOME = @NOME, " + 
                             "PERIODO = @PERIODO, " +
                             "NIVEL = @NIVEL " +
                             "WHERE ID_CURSO = " + idCurso;                

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@PERIODO", periodo);
                cmd.Parameters.AddWithValue("@NIVEL", nivel);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados do Curso!\n\n" + ex.Message;
            }
        }
        
        #endregion
    }
}
