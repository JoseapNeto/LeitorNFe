using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class Destinatario
    {
        [Key]
        public int id { get; set; }
        public string xNome { get; set; }
        public string CNPJ { get; set; }

        [ForeignKey("DestEnd")]
        public int? DestEndId { get; set; }
        public virtual DestinatarioEnderecocs DestEnd { get; set; }

    }
}