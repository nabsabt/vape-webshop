using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VapeWebshop.Models
{
    public class Liquid
    {
        public int Id { get; set; }

        [Required]
        public string Flavour { get; set; }
        public byte Nicotine { get; set; }
    }
}