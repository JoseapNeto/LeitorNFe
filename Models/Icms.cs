using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppLeitorNfe.Models
{
    public class Icms
    {
        [Key]
        public int id { get; set; }
        public string vNF { get; set; }
    }
}