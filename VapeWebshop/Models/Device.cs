using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VapeWebshop.Models
{
    public class Device
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Output { get; set; }
    }
}