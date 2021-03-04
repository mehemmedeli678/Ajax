using K207AjaxApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.VM
{
    public class ModelWidthProduct
    {
        public List<Marka> Marka { get; set; }
        public List<product> products { get; set; }
        public List<Model> model { get; set; }
        public int maxPro { get; set; }
    }
}
