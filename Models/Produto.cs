using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string cProd { get; set; }
        public string qCom { get; set; }
        public string vUnCom { get; set; }
        public string vProd { get; set; }


        [ForeignKey("Nfe")]
        public int? NfeId { get; set; }
        public virtual Nfe Nfe { get; set; }
    }
}