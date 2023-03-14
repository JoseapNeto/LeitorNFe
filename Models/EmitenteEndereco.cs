using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class EmitenteEndereco
    {
        [Key]
        public int id { get; set; }
        public string xLgr { get; set; }
        public string nro { get; set; }
        public string xBairro { get; set; }
        public string xMun { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}