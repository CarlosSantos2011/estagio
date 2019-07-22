using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    public class EstoqueContext : DbContext
    {
       

        

        public DbSet<Pessoa> Pessoa { get; set; }


    }
}