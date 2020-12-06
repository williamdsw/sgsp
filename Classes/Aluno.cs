using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---
using System.Data;                  
using MySql.Data.MySqlClient;       

namespace SGSP___Desktop
{
    //classe derivada que herda de "Pessoa"
    class Aluno : Pessoa
    {
        #region Atributos/Variáveis

        //apenas dessa classe "Aluno"
        string _NomeMae, _NomePai, _Curso, _Turma;

        int? _IdTurma;

        bool _Pae, _Repetente;

        #endregion

        //instância do banco
        Banco bd = new Banco();

        #region Método construtor

        public Aluno(string nome, string rg, string cpf, string naturalidade, string uf, 
                     string estadoCivil, string sexo, string nomeMae, string nomePai, 
                     string endereco, string bairro, string cep, string telefoneFixo, 
                     string celular, string email, string curso, string turma, string caminhoFoto, 
                     string prontuario, int? idade, int? idTurma, DateTime? dataNascimento, 
                     DateTime? dataCadastro, bool pae, bool repetente)
        {
            _Nome = nome;
            _Rg = rg;
            _Cpf = cpf;
            _Naturalidade = naturalidade;
            _Uf = uf;
            _EstadoCivil = estadoCivil;
            _Sexo = sexo;
            _NomeMae = nomeMae;
            _NomePai = nomePai;
            _Endereco = endereco;
            _Bairro = bairro;
            _Cep = cep;
            _TelefoneFixo = telefoneFixo;
            _Celular = celular;
            _Email = email;
            _Curso = curso;
            _Turma = turma;
            _CaminhoFoto = caminhoFoto;
            _Idade = idade;
            _IdTurma = idTurma;
            _Prontuario = prontuario;
            _DataNascimento = dataNascimento;
            _DataCadastro = dataCadastro;
            _Pae = pae;
            _Repetente = repetente;
        }

        #endregion

        //Sobrecarga do método construtor
        public Aluno()
        { }
    
        #region Método para inserir dados (INSERT)

        public override string Insere()
        {
            try
            {
                string sql = "INSERT INTO aluno (NOME, RG, CPF, NATURALIDADE, UF, ESTADO_CIVIL, SEXO, " +
                                                "NOME_MAE, NOME_PAI, ENDERECO, BAIRRO, CEP, " +
                                                "TELEFONE_FIXO, CELULAR, EMAIL, CURSO, TURMA, " +
                                                "CAMINHO_FOTO, IDADE, PRONTUARIO, DATA_NASCIMENTO, " +
                                                "DATA_CADASTRO, PAE, REPETENTE, ID_TURMA) " +
                             "VALUES (@NOME, @RG, @CPF, @NATURALIDADE, @UF, @ESTADO_CIVIL, @SEXO, " +
                                     "@NOME_MAE, @NOME_PAI, @ENDERECO, @BAIRRO, @CEP, @TELEFONE_FIXO, " +
                                     "@CELULAR, @EMAIL, @CURSO, @TURMA, @CAMINHO_FOTO, @IDADE, " +
                                     "@PRONTUARIO, @DATA_NASCIMENTO, @DATA_CADASTRO, @PAE, @REPETENTE, " +
                                     "@ID_TURMA)";

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", _Nome);
                cmd.Parameters.AddWithValue("@RG", _Rg);
                cmd.Parameters.AddWithValue("@CPF", _Cpf);
                cmd.Parameters.AddWithValue("@NATURALIDADE", _Naturalidade);
                cmd.Parameters.AddWithValue("@UF", _Uf);
                cmd.Parameters.AddWithValue("@ESTADO_CIVIL", _EstadoCivil);
                cmd.Parameters.AddWithValue("@SEXO", _Sexo);
                cmd.Parameters.AddWithValue("@NOME_MAE", _NomeMae);
                cmd.Parameters.AddWithValue("@NOME_PAI", _NomePai);
                cmd.Parameters.AddWithValue("@ENDERECO", _Endereco);
                cmd.Parameters.AddWithValue("@BAIRRO", _Bairro);
                cmd.Parameters.AddWithValue("@CEP", _Cep);
                cmd.Parameters.AddWithValue("@TELEFONE_FIXO", _TelefoneFixo);
                cmd.Parameters.AddWithValue("@CELULAR", _Celular);
                cmd.Parameters.AddWithValue("@EMAIL", _Email);
                cmd.Parameters.AddWithValue("@CURSO", _Curso);
                cmd.Parameters.AddWithValue("@TURMA", _Turma);
                cmd.Parameters.AddWithValue("@CAMINHO_FOTO", _CaminhoFoto);
                cmd.Parameters.AddWithValue("@IDADE", _Idade);
                cmd.Parameters.AddWithValue("@PRONTUARIO", _Prontuario);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _DataNascimento);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", _DataCadastro);
                cmd.Parameters.AddWithValue("@PAE", _Pae);
                cmd.Parameters.AddWithValue("@REPETENTE", _Repetente);
                cmd.Parameters.AddWithValue("@ID_TURMA", _IdTurma);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Aluno cadastrado!";
            }
            catch (Exception ex)
            {
                return "Erro ao cadastrar aluno!\n\n" + ex.Message;
            }
        }

        #endregion

        #region Método para alterar dados (UPDATE)

        public override string Altera()
        {
            try
            {
                string sql = "UPDATE aluno " +
                             "SET NOME = @NOME, " +
                             "RG = @RG, " +
                             "CPF = @CPF, " +
                             "NATURALIDADE = @NATURALIDADE, " +
                             "UF = @UF, " +
                             "ESTADO_CIVIL = @ESTADO_CIVIL, " +
                             "SEXO = @SEXO, " +
                             "NOME_MAE = @NOME_MAE, " +
                             "NOME_PAI = @NOME_PAI, " +
                             "ENDERECO = @ENDERECO, " +
                             "BAIRRO = @BAIRRO, " +
                             "CEP = @CEP, " +
                             "TELEFONE_FIXO = @TELEFONE_FIXO, " +
                             "CELULAR = @CELULAR, " +
                             "EMAIL = @EMAIL, " +
                             "CURSO = @CURSO, " +
                             "TURMA = @TURMA, " +
                             "CAMINHO_FOTO = @CAMINHO_FOTO, " +
                             "IDADE = @IDADE, " +
                             "IDADE = @IDADE, " +
                             "DATA_NASCIMENTO = @DATA_NASCIMENTO, " +
                             "ID_TURMA = @ID_TURMA, " +
                             "REPETENTE = @REPETENTE " +
                             "WHERE PRONTUARIO = " + _Prontuario;                //parâmetro do código do aluno

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                cmd.Parameters.AddWithValue("@NOME", _Nome);
                cmd.Parameters.AddWithValue("@RG", _Rg);
                cmd.Parameters.AddWithValue("@CPF", _Cpf);
                cmd.Parameters.AddWithValue("@NATURALIDADE", _Naturalidade);
                cmd.Parameters.AddWithValue("@UF", _Uf);
                cmd.Parameters.AddWithValue("@ESTADO_CIVIL", _EstadoCivil);
                cmd.Parameters.AddWithValue("@SEXO", _Sexo);
                cmd.Parameters.AddWithValue("@NOME_MAE", _NomeMae);
                cmd.Parameters.AddWithValue("@NOME_PAI", _NomePai);
                cmd.Parameters.AddWithValue("@ENDERECO", _Endereco);
                cmd.Parameters.AddWithValue("@BAIRRO", _Bairro);
                cmd.Parameters.AddWithValue("@CEP", _Cep);
                cmd.Parameters.AddWithValue("@TELEFONE_FIXO", _TelefoneFixo);
                cmd.Parameters.AddWithValue("@CELULAR", _Celular);
                cmd.Parameters.AddWithValue("@EMAIL", _Email);
                cmd.Parameters.AddWithValue("@CURSO", _Curso);
                cmd.Parameters.AddWithValue("@TURMA", _Turma);
                cmd.Parameters.AddWithValue("@CAMINHO_FOTO", _CaminhoFoto);
                cmd.Parameters.AddWithValue("@IDADE", _Idade);
                cmd.Parameters.AddWithValue("@ID_TURMA", _IdTurma);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _DataNascimento);
                cmd.Parameters.AddWithValue("@PAE", _Pae);
                cmd.Parameters.AddWithValue("@REPETENTE", _Repetente);

                cmd.ExecuteNonQuery();

                bd.Desconecta(cmd.Connection);

                return "Dados alterados!";
            }
            catch (Exception ex)
            {
                return "Erro ao alterar dados do aluno!\n\n" + ex.Message;
            }
        }

        #endregion
    }
}
