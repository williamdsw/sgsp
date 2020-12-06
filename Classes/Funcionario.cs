using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---
using System.Data;                  
using System.Windows.Forms;         
using MySql.Data.MySqlClient;

namespace SGSP___Desktop
{
    //essa classe herda da classe abstrata Pessoa
    class Funcionario : Pessoa
    {       
        //variáveis
        string _Cargo, _Turno;

        //instância do banco
        Banco bd = new Banco();

        #region Método construtor

        public Funcionario(string nome, string rg, string cpf, string naturalidade, string uf, 
                           string estadoCivil, string sexo, string cargo, string turno, 
                           string endereco, string bairro, string cep, string telefoneFixo, 
                           string celular, string email, string caminhoFoto, string prontuario, 
                           int? idade, DateTime? dataNascimento, DateTime? dataCadastro)
        {
            _Nome = nome;
            _Rg = rg;
            _Cpf = cpf;
            _Naturalidade = naturalidade;
            _Uf = uf;
            _EstadoCivil = estadoCivil;
            _Sexo = sexo;
            _Cargo = cargo;
            _Turno = turno;
            _Endereco = endereco;
            _Bairro = bairro;
            _Cep = cep;
            _TelefoneFixo = telefoneFixo;
            _Celular = celular;
            _Email = email;
            _CaminhoFoto = caminhoFoto;
            _Prontuario = prontuario;
            _DataNascimento = dataNascimento;
            _DataCadastro = dataCadastro;
            _Idade = idade;
        }

        #endregion

        //Sobrecarga do método construtor
        public Funcionario()
        { }

        #region Método para inserir dados (INSERT) [string]

        public override string Insere()
        {
            try
            {
                string sql = "INSERT INTO funcionarios (NOME, RG, CPF, NATURALIDADE, UF, ESTADO_CIVIL, SEXO, " +
                                                      "CARGO, TURNO, ENDERECO, BAIRRO, CEP, TELEFONE_FIXO, CELULAR, " +
                                                      "EMAIL, CAMINHO_FOTO, IDADE, PRONTUARIO, DATA_NASCIMENTO, " +
                                                      "DATA_CADASTRO) " +
                             "VALUES (@NOME, @RG, @CPF, @NATURALIDADE, @UF, @ESTADO_CIVIL, @SEXO, @CARGO, @TURNO, " +
                                     "@ENDERECO, @BAIRRO, @CEP, @TELEFONE_FIXO, @CELULAR, @EMAIL, @CAMINHO_FOTO, " +
                                     "@IDADE, @PRONTUARIO, @DATA_NASCIMENTO, @DATA_CADASTRO)";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", _Nome);
                cmd.Parameters.AddWithValue("@RG", _Rg);
                cmd.Parameters.AddWithValue("@CPF", _Cpf);
                cmd.Parameters.AddWithValue("@NATURALIDADE", _Naturalidade);
                cmd.Parameters.AddWithValue("@UF", _Uf);
                cmd.Parameters.AddWithValue("@ESTADO_CIVIL", _EstadoCivil);
                cmd.Parameters.AddWithValue("@SEXO", _Sexo);
                cmd.Parameters.AddWithValue("@CARGO", _Cargo);
                cmd.Parameters.AddWithValue("@TURNO", _Turno);
                cmd.Parameters.AddWithValue("@ENDERECO", _Endereco);
                cmd.Parameters.AddWithValue("@BAIRRO", _Bairro);
                cmd.Parameters.AddWithValue("@CEP", _Cep);
                cmd.Parameters.AddWithValue("@TELEFONE_FIXO", _TelefoneFixo);
                cmd.Parameters.AddWithValue("@CELULAR", _Celular);
                cmd.Parameters.AddWithValue("@EMAIL", _Email);
                cmd.Parameters.AddWithValue("@CAMINHO_FOTO", _CaminhoFoto);
                cmd.Parameters.AddWithValue("@IDADE", _Idade);
                cmd.Parameters.AddWithValue("@PRONTUARIO", _Prontuario);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _DataNascimento);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", _DataCadastro);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Servidor(a) cadastrado(a)!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar servidor(a)!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE) [string]

        public override string Altera()
        {
            try
            {
                string sql = "UPDATE funcionarios " +
                             "SET NOME = @NOME, " +
                             "RG = @RG, " +
                             "CPF = @CPF, " +
                             "NATURALIDADE = @NATURALIDADE, " +
                             "UF = @UF, " +
                             "ESTADO_CIVIL = @ESTADO_CIVIL, " +
                             "SEXO = @SEXO, " +
                             "CARGO = @CARGO, " +
                             "TURNO = @TURNO, " +
                             "ENDERECO = @ENDERECO, " +
                             "BAIRRO = @BAIRRO, " +
                             "CEP = @CEP, " +
                             "TELEFONE_FIXO = @TELEFONE_FIXO, " +
                             "CELULAR = @CELULAR, " +
                             "EMAIL = @EMAIL, " +
                             "CAMINHO_FOTO = @CAMINHO_FOTO, " +
                             "IDADE = @IDADE, " +
                             "DATA_NASCIMENTO = @DATA_NASCIMENTO " +
                             "WHERE PRONTUARIO = " + _Prontuario;                //parâmetro do código do funcionário

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", _Nome);
                cmd.Parameters.AddWithValue("@RG", _Rg);
                cmd.Parameters.AddWithValue("@CPF", _Cpf);
                cmd.Parameters.AddWithValue("@NATURALIDADE", _Naturalidade);
                cmd.Parameters.AddWithValue("@UF", _Uf);
                cmd.Parameters.AddWithValue("@ESTADO_CIVIL", _EstadoCivil);
                cmd.Parameters.AddWithValue("@SEXO", _Sexo);
                cmd.Parameters.AddWithValue("@CARGO", _Cargo);
                cmd.Parameters.AddWithValue("@TURNO", _Turno);
                cmd.Parameters.AddWithValue("@ENDERECO", _Endereco);
                cmd.Parameters.AddWithValue("@BAIRRO", _Bairro);
                cmd.Parameters.AddWithValue("@CEP", _Cep);
                cmd.Parameters.AddWithValue("@TELEFONE_FIXO", _TelefoneFixo);
                cmd.Parameters.AddWithValue("@CELULAR", _Celular);
                cmd.Parameters.AddWithValue("@EMAIL", _Email);
                cmd.Parameters.AddWithValue("@CAMINHO_FOTO", _CaminhoFoto);
                cmd.Parameters.AddWithValue("@IDADE", _Idade);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _DataNascimento);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para Alterar idLogin do Funcionário (UPDATE) [string]

        public string SetIDLogin(int idLogin, string prontuario)
        {
            try
            {
                string sql = " UPDATE funcionarios" +
                             " SET ID_LOGIN = @ID_LOGIN " +
                             " WHERE PRONTUARIO = " + "'" + prontuario + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@ID_LOGIN", idLogin);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "OK!";
            }
            catch (Exception ex)
            {
                return "Erro ao atribuir o Login ao funcionário!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para retornar email do funcionário (SELECT) [string]

        public string GetEmail(string prontuario)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = " SELECT EMAIL FROM funcionarios" +
                             " WHERE PRONTUARIO = " + "'" + prontuario + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string email = dr["EMAIL"].ToString();

                bd.Desconecta(cmd.Connection);

                return email;
            }
            catch (Exception ex)
            {
                return "Erro ao consultar o email : \n" + ex.Message;
            }
        }

        #endregion

        #region Método para consultar nomes dos funcionários (SELECT) [DataTable]

        public DataTable NomeFuncionarios(string cargo)
        {
            try
            {
                DataSet dset = new DataSet();

                DataTable dt = new DataTable();

                string sql = " SELECT NOME FROM funcionarios" +
                             " WHERE CARGO = " + "'" + cargo + "'";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                MySqlDataAdapter da = new MySqlDataAdapter();

                da.SelectCommand = cmd;

                da.Fill(dset);

                dt = dset.Tables[0];
                
                if(dt.Rows.Count < 1)
                {
                    return null;
                }

                bd.Desconecta(cmd.Connection);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar os nomes dos servidores : \n" + ex.Message);

                return null;
            }
        }

        #endregion

        #region Método para consultar só funcionários que tem Login (SELECT) [DataTable]

        public DataTable ConsultaNomeLogin()
        {
            try
            {
                DataSet dset = new DataSet();

                DataTable dt = new DataTable();

                string sql = "SELECT NOME FROM funcionarios " +
                             "WHERE ID_LOGIN > 0";

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
                MessageBox.Show("Erro ao consultar dos funcionários com login : \n" + ex.Message);

                return null;
            }
        }

        #endregion
    }
}
