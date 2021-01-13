using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVC.Models
{
    public class contexto : DbContext
    {
         public DbSet<Pessoa> pessoas { get; set; }
        

    }
}