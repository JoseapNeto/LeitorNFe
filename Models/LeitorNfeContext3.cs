using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class LeitorNfeContext3 : DbContext
    {
        
    
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
