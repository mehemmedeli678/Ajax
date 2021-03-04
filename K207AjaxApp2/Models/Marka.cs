using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.Models
{
    public class Marka:BaseEntity
    {
        public virtual List<Model> Models { get; set; }
    }
}
