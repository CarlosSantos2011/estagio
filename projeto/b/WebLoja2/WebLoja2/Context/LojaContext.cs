
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Models;


namespace WebLoja2.Context
{
    public class LojaContext : DbContext
    {     
       
        public DbSet <Pessoa> Pessoas { get; set; }
        public DbSet <Clientes> Clientes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}