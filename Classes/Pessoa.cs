using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGSP___Desktop
{
    //classe base que terá os elementos herdados pelas classes Aluno e Funcionário
    abstract class Pessoa
    {
        //variáveis
        protected string _Nome, _Rg, _Cpf, _Naturalidade, _Uf, _EstadoCivil, _Sexo, 
               _Endereco, _Bairro, _Cep, _TelefoneFixo, _Celular, _Email, 
               _CaminhoFoto, _Prontuario;

        protected int? _Idade;

        protected DateTime? _DataNascimento, _DataCadastro;

        //método abstract para Inserir no banco
        public abstract string Insere();

        //método abstract para Alterar no banco
        public abstract string Altera();                  
    }
}
