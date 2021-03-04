using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.Models
{
    public class Model: BaseEntity
    {
        public int MarkaId { get; set; }
        public virtual Marka Marka { get; set; }
        public List<product> products { get; set; }

    }
}
