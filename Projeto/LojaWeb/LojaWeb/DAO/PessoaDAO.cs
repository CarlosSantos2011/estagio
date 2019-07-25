using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    //public class PessoaDAO 
    //{
    //    public void Adiciona(Pessoa pessoa)
    //    {
    //        using (var context = new EstoqueContext())
    //        {
    //            context.Pessoa.Add(pessoa);
    //            context.SaveChanges();
    //        }
    //    }

    //    public IList<Pessoa> Lista()
    //    {
    //        using (var contexto = new EstoqueContext())
    //        {
    //            return null;
    //        }
    //    }

        //public Pessoa BuscaPorId(int id)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        return contexto.Pessoa.Include("Categoria")
        //            .Where(p => p.Id == id)
        //            .FirstOrDefault();
        //    }
        //}

        //public void Atualiza(Pessoa produto)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}
    //}

}