using ConsoleApp1.DAL;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class SizeService
    {
        public void CreatSize(string name,int pizzaId)
        {
            Size size = new Size();
            size.Name = name;
            size.PizzaId = pizzaId;
            using (AppDbContext context = new AppDbContext())
            {
                context.Sizes.Add(size);
                context.SaveChanges();
            }
        }

        public Size GetById(int id)
        {
            Size size;
            using (AppDbContext ctx = new AppDbContext())
            {
                size = ctx.Sizes.FirstOrDefault(s=>s.Id==id);
            }
            return size;
        }

        public List<Size> GetAll()
        {
            List<Size> sizes;
            using (AppDbContext context = new AppDbContext())
            {
                sizes = context.Sizes.ToList();
            }
            return sizes;
        }

        public void Remove(int id)
        {
            Size existed;
            using (AppDbContext context = new AppDbContext())
            {
                existed = context.Sizes.FirstOrDefault(s=>s.Id==id);
                context.Sizes.Remove(existed);
                context.SaveChanges();
            }
        }
    }
}
