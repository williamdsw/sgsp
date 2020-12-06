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
    class ModuloPerfil
    {
        #region Variáveis (atributos)

        int _IdModulo, _IdPerfil;

        bool _Permissao;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        public ModuloPerfil(int idModulo, int idPerfil, bool permissao)
        {
            _IdModulo = idModulo;
            _IdPerfil = idPerfil;
            _Permissao = permissao;
        }

        #endregion

        //sobrecarga do construtor
        public ModuloPerfil()
        { }

        #region Método para inserir dados (INSERT)

        public string Insere(int idModulo, int idPerfil, bool permissao)
        {
            try
            {
                string sql = "INSERT INTO modulo_perfil (ID_MODULO, ID_PERFIL, PERMISSAO, MODO, STATUS) " +
                             "VALUES (@ID_MODULO, @ID_PERFIL, @PERMISSAO, '', '') ";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@ID_MODULO", idModulo);
                cmd.Parameters.AddWithValue("@ID_PERFIL", idPerfil);
                cmd.Parameters.AddWithValue("@PERMISSAO", permissao);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)

        public string Altera(int idModulo, bool permissao, int idPerfil)
        {
            try
            {
                string sql = " UPDATE modulo_perfil " +
                             " SET PERMISSAO = @PERMISSAO  " +
                             " WHERE ID_MODULO = " + idModulo +
                             " AND ID_PERFIL = " + idPerfil;

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@PERMISSAO", permissao);

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

        #region Método de verficação das permissões dos módulos (SELECT) [bool]

        public bool GetPermissao(int idModulo, int idPerfil)
        {
            try
            {
                string sql = " SELECT PERMISSAO FROM modulo_perfil " +
                             " WHERE ID_MODULO = " + idModulo +
                             " AND ID_PERFIL = " + idPerfil;

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                bool permissao = Convert.ToBoolean(dr["PERMISSAO"]);

                bd.Desconecta(cmd.Connection);

                return permissao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar as permissões : \n" + ex.Message);

                return false;
            }
        }

        #endregion

        #region Método para retornar todas permissões dos módulos (SELECT) [List<string>]

        public List<string> ListaPermissoes(int idPerfil)
        {
            try
            {
                DataSet dset = new DataSet();

                DataTable dt = new DataTable();

                string sql = " SELECT PERMISSAO FROM modulo_perfil" +
                             " WHERE ID_PERFIL = " + idPerfil;

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dset);

                dt = dset.Tables[0];

                //aqui crio uma lista para pegar todas permissões (true/false) do banco
                List<string> permissao = new List<string>();

                //aqui preencho essa lista
                foreach (DataRow row in dt.Rows)
                {
                    permissao.Add(row["PERMISSAO"].ToString());
                }

                bd.Desconecta(cmd.Connection);

                return permissao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar as permissões : \n" + ex.Message);

                return null;
            }
        }

        #endregion
    }
}
