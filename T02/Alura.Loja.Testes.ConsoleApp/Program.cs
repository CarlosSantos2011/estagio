using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {

                var produtos = contexto.Produtos.ToList();

                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.Entity.ToString() + " - " + e.State);
                }


                var novoProduto = new Produto()
                {
                    Nome = "Desinfetante",
                    Categoria = "limpeza",
                    Preco = 2.99
                };
                contexto.Produtos.Add(novoProduto);

                contexto.SaveChanges();           
                
                ExibeEntries(contexto);
            }
        } 
        
        private static void ExibeEntries(Func<IEnumerable<EntityEntry>> entries)
        {
            throw new NotImplementedException();
        }
        
        private static void ExibeEntries(LojaContext contexto)
        {
          void ExibeEntries(IEnumerable<EntityEntry> entries)

            {
                foreach (var e in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(e.Entity.ToString() + " - " + e.State);
                }
            }

        }
    }
}
