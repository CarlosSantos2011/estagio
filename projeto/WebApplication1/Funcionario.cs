using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Funcionario : Pessoas
    {
        public DateTime dataDeNascimento { get; private set; }
        public string sexo;
        public string cpf;
        public string numeroCarteiraDeTrabalho;
        public string login;
        public string senha;

        public Funcionario(string Nome, int Id, DateTime DataDeNascimento, string Sexo, string Cpf, string NumeroCarteiraDeTrabalho, string Login, string Senha) : base(Nome, Id)
        {
            this.nome = Nome;
            this.iD = Id;
            this.dataDeNascimento = DataDeNascimento;
            this.sexo = Sexo;
            this.cpf = Cpf;
            this.numeroCarteiraDeTrabalho = NumeroCarteiraDeTrabalho;
            this.login = Login;
            this.senha = Senha;
        }
    }
}