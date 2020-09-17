using Microsoft.EntityFrameworkCore;
using ProductosCRUD.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosCRUD.Models
{
    public class ProductosContext: DbContext
    {   

        public DbSet<Product> Products { get; set; }

        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

    }
}
