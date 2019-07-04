using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Fornecedor : Pessoas
    {
        private string cnpj;
        private string razaoSocial;

        public Fornecedor(string Nome, int Id, string cnpj, string razaoSocial) : base(Nome, Id)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
          

        }

        public void ForneceProduto (Produto produto)
        {
           
        }
    }
  
    
   
}