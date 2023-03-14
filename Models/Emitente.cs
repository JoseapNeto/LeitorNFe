using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class Emitente
    {
        [Key]
        public int id { get; set; }
        public int xNome { get; set; }
        public int CNPJ { get; set; }


        [ForeignKey("EmitEnd")]
        public int? EmitEndId { get; set; }
        public virtual EmitenteEndereco EmitEnd { get; set; }
    }
}