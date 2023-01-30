using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetEcommerce.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser, AppUserRole, int>
    {
        //ctor

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=FATIH\\SQLEXPRESS;database=NetCoreEcommerce;uid=sa;pwd=123;");
            }



            base.OnConfiguring(optionsBuilder);
        }

        //FakeData
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser




            //Product
            Product product = new Product
            {
                Id = 1,
                ProductName = "Chai",
                UnitPrice = 18,
                UnitsInStock = 500,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ornare ex non erat dapibus congue. Curabitur ullamcorper vitae tortor vitae pharetra.",
                ImagePath = "https://www.slntechnologies.com/wp-content/uploads/2017/08/ef3-placeholder-image.jpg"
            };

            builder.Entity<Product>().HasData(product);



            base.OnModelCreating(builder);
        }

    }
}
