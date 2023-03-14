using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class LeitorNfeContext3 : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public LeitorNfeContext3() : base("name=LeitorNfeContext3")
        {
        }

        public System.Data.Entity.DbSet<AppLeitorNfe.Models.Nfe> Nfes { get; set; }

        public System.Data.Entity.DbSet<AppLeitorNfe.Models.Destinatario> Destinatarios { get; set; }

        public System.Data.Entity.DbSet<AppLeitorNfe.Models.Emitente> Emitentes { get; set; }

        public System.Data.Entity.DbSet<AppLeitorNfe.Models.Icms> Icms { get; set; }

        public System.Data.Entity.DbSet<AppLeitorNfe.Models.Produto> Produtos { get; set; }
    }
}
