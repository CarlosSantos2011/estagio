using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Pessoas
    {
        public string nome;
        public int iD;
      

        public Pessoas(string Nome, int Id)
        {
            this.nome = Nome;
            this.iD = Id;
         
        }
    }
}