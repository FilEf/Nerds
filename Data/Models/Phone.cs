using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nerds.Data.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public bool IsFavorite { get; set; }
        public bool Available { get; set; }
        public string Display { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
