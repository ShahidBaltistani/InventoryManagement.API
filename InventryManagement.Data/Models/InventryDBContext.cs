using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Data.Models
{
   public class InventryDBContext : DbContext
    {
        public InventryDBContext(DbContextOptions<InventryDBContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
