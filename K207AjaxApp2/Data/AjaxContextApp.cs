using K207AjaxApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.Data
{
    public class AjaxContextApp:DbContext
    {
        public AjaxContextApp(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Model> Models { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<product> Products { get; set; }
    }
}
