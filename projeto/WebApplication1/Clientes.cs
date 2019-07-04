using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Clientes : Pessoas
    {
        private string cpf;
        public Clientes(string Nome, int Id, string Cpf) : base (Nome, Id)
        {
            this.nome = Nome;
            this.iD = Id;
            this.cpf = Cpf;
            
        }
        
    }
}