using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Funcionario : Pessoas
    {

        public string NumeroCarteiraDeTrabalho { get; private set; }
        private string Login {  get;  set; }
        private string Senha { get; set; }
        public DateTime DataDataDeNascimento { get; private set; }
        public string Sexo { get; private set; }
        public string Cpf { get; private set; }

        public Funcionario(int id, string nome, string numeroCarteiraDeTrabalho, string login, string senha, DateTime dataDeNascimento, string cpf, string sexo)
        {
            Login = login;
            Id = id;
            Nome = nome;
            NumeroCarteiraDeTrabalho = numeroCarteiraDeTrabalho;
            Senha = senha;
            DataDataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Cpf = cpf;
        }

    }
}