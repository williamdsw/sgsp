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
    class Perfil
    {
        #region Atributos/Variáveis

        string _Nome;

        int _IdLogin;

        DateTime _DataCadastro;

        #endregion

        //Instanciamento de classes
        Banco bd = new Banco();

        #region Método Construtor

        public Perfil(string nome, int idLogin, DateTime dataCadastro)
        {
            _Nome = nome;
            _IdLogin = idLogin;
            _DataCadastro = dataCadastro;
        }

        #endregion

        #region Método de inserção de dados (INSERT)

        public string Insere(string nome, int idLogin, DateTime dataCadastro)
        {
            try
            {
                string sql = "INSERT INTO perfil (NOME, DATA_CADASTRO, ID_LOGIN) " +
                             "VALUES (@NOME, @DATA_CADASTRO, @ID_LOGIN)";

                MySqlCommand cmd =  new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", nome);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataCadastro);
                cmd.Parameters.AddWithValue("@ID_LOGIN", idLogin);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Perfil cadastrado com sucesso";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar perfil!\n\n" + ex.Message;
            }
        }
        #endregion
    }
}
