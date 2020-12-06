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
    class Modulo
    {
        #region Variáveis (atributos)

        string _Nome, _Plataforma;

        DateTime _DataCadastro;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        public Modulo(string nome, string plataforma, DateTime dataCadastro)
        {
            _Nome = nome;
            _Plataforma = plataforma;
            _DataCadastro = dataCadastro;
        }

        #endregion

        //sobrecarga do construtor
        public Modulo()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(string nome, string plataforma, DateTime dataCadastro)
        {
            try
            {
                string sql = "INSERT INTO modulo (NOME, SIGLA, DATA_CADASTRO, PLATAFORMA) " +
                             "VALUES (@NOME, 'SIGLA', @DATA_CADASTRO, @PLATAFORMA) ";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataCadastro);
                cmd.Parameters.AddWithValue("@PLATAFORMA", plataforma);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Módulo cadastrado!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar módulo!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)

        public string Altera(string nome, string plataforma, string idModulo)
        {
            try
            {
                string sql = "UPDATE modulo " +
                             "SET NOME = @NOME, " + 
                             "PLATAFORMA = @PLATAFORMA " +
                             "WHERE ID_MODULO = " + idModulo;                

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@PLATAFORMA", plataforma);
   
                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados do Módulo!\n\n" + ex.Message;
            }
        }
        
        #endregion
    }
}
