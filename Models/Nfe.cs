using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class Nfe
    {
       [Key]
        public int id { get; set; }
        public int nNF { get; set; }
        public int chNFe { get; set; }
        public string dhEmi { get; set; }

        [ForeignKey("Emitente")]
        public int? EmitenteId { get; set; }
        public virtual Emitente Emitente { get; set; }

        
        [ForeignKey("Destinatario")]
        public int? DestinatarioId { get; set; }
        public virtual Destinatario Destinatario { get; set; }

        public List<Produto> produtos { get; set; }

        [ForeignKey("Icms")]
        public int? IcmsId { get; set; }
        public virtual Icms Icms { get; set; }


    }
}