﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataApp.Models
{
    public enum Colors
    {
        Red,Green,Blue
    }
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
        public Colors Color { get; set; }
        public bool InStock { get; set; }

        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public IEnumerable<ProductShipmentJunction> ProductShipments { get; set; }
    }
}