using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.Models
{
    public class product:BaseEntity
    {
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public int ModelId { get; set; }
        public virtual  Model Model { get; set; }
    }
}
