using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                  //Bibliotecas importadas para usar métodos
using MySql.Data.MySqlClient;     

namespace SGSP___Desktop
{
    class Encaminhamento
    {
        #region Leia-me

        /* A maioria das classes seguem um padrão de declaração de variáveis e uso de métodos
         * por isso vou declarar as explicações de códigos aqui, e quando tiver algum método 
         * diferente, irei especificar um comentário naquele método 
         * Exemplos :
         *
         * Variáveis-Encapsuladores...
         * private/protected = começam com underline _ + nome  = string _Exemplo;
         * public = começam com a letra maiúscula = string Exemplo;
         * 
         * Métodos... começam com letra maiúscula = private string Insere().. etc
         */

        // a instrução region-endregion é utilizada para criar blocos

        /* Não é mais necessário
        #region Enumerador usado para preencher um ComboBox da tela Consultas

        public enum Tabelas
        {
            ID_AGENDAMENTO,
            PRONTUARIO_FUNCIONARIO,
            PRONTUARIO_ALUNO,
            DEMANDA,
            //DATA
            //HORA
            AGENDAR_COM,
            NOME_FUNCIONARIO,
            DATA_CADASTRO,
            ID_LOGIN
        }

        #endregion
         */

        #endregion

        #region Variáveis (atributos)

        //padrão de variáveis globais private : começam com underline _ 
        /*o ponto de Interrogação '?' é utilizado para indicar uma variável que poderá aceitar
         um valor nulo*/
        string _Demanda, _AgendarCom, _ProntuarioFuncionario, _ProntuarioAluno, _NomeProfissional, _Dia, _Turno;

        DateTime? _DataCadastro;

        int _IdLogin;

        #endregion

        //Instanciando o banco
        Banco bd = new Banco();

        #region Método construtor

        //padrão para variáveis locais : mesmo nome da global só que com letra minúscula.
        public Encaminhamento(string demanda, string prontuarioFuncionario, string prontuarioAluno,
                              string agendarCom, string nomeProfissional, string dia, string turno, DateTime?   dataCadastro, int idLogin)
        {
            //aqui acontece a atribuição de uma variável local para outra global
            _Demanda = demanda;
            _Dia = dia;
            _Turno = turno;
            _ProntuarioFuncionario = prontuarioFuncionario;
            _ProntuarioAluno = prontuarioAluno;
            _AgendarCom = agendarCom;
            _NomeProfissional = nomeProfissional;
            _DataCadastro = dataCadastro;
            _IdLogin = idLogin;
        }

        #endregion

        #region Método para inserir dados (INSERT)

        public string Insere(string demanda, string prontuarioFuncionario, string prontuarioAluno,
                             string agendarCom, string nomeProfissional,  string dia, string turno, DateTime? dataCadastro, int idLogin)
        {
            //Tratamento de excessão
            try
            {
                /*string que carrega uma instrução para ser executada no banco de dados
                 * nesse caso, a instrução INSERT é usada para inserir dados no banco */

                string sql = "INSERT INTO agendamento (DEMANDA, PRONTUARIO_FUNCIONARIO, " +
                                                      "PRONTUARIO_ALUNO, AGENDAR_COM, NOME_PROFISSIONAL, " +
                                                      "DIA, TURNO, DATA_CADASTRO, ID_LOGIN)" +
                             "VALUES (@DEMANDA, @PRONTUARIO_FUNCIONARIO, @PRONTUARIO_ALUNO, " +
                                     "@AGENDAR_COM, @NOME_PROFISSIONAL, @DIA, @TURNO, @DATA_CADASTRO, @ID_LOGIN)";

                /*Instancia um comando SQL que irá usar a string de comando e a conexão do banco 
                 * como parâmetros*/

                MySqlCommand cmd = new MySqlCommand(sql, bd.Conecta());

                /* Utilizando esse "objeto de comando", será possível atribuir os valores 
                 das variáveis para as cada parâmetro da tabela desejada do banco
                 utilizando o método AddWithValue()*/

                cmd.Parameters.AddWithValue("@PRONTUARIO_FUNCIONARIO", prontuarioFuncionario);
                cmd.Parameters.AddWithValue("@PRONTUARIO_ALUNO", prontuarioAluno);
                cmd.Parameters.AddWithValue("@DEMANDA", demanda);
                cmd.Parameters.AddWithValue("@DIA", dia);
                cmd.Parameters.AddWithValue("@TURNO", turno);
                cmd.Parameters.AddWithValue("@AGENDAR_COM", agendarCom);
                cmd.Parameters.AddWithValue("@NOME_PROFISSIONAL", nomeProfissional);
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", dataCadastro);
                cmd.Parameters.AddWithValue("@ID_LOGIN", idLogin);

                /*Esse é um comando que executa o Insert, mas não executa a busca de informações
                no banco de dados */

                cmd.ExecuteNonQuery();

                //Desconecta do banco

                bd.Desconecta(cmd.Connection);

                //Retorna uma string

                return "Encaminhamento enviado!";
            }
            catch (Exception ex)
            {
                //Caso houver algum erro, será usado o 'catch' com o Exception para exibir esse erro

                return "Erro ao realizar encaminhamento!\n\n" + ex.Message;
            }
        }

        #endregion
    }
}
