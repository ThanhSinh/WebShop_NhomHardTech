using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop_NhomHardTech.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageFeature { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
}