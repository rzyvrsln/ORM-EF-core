using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-LKEG3NN\\SQLEXPRESS;Database=PizzaMizza;Trusted_Connection=True;Encrypt=False;Integrated Security=True");
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Size> Sizes { get; set; }
    }
}
