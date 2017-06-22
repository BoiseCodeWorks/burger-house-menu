using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MenuApi.Models;

namespace MenuApi.SQLite
{

  public class BurgerHouseContext : DbContext
  {
    // public DbSet<Drink> Drinks { get; set; }
    // public DbSet<Entree> Entrees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=menu.db");
    }
  }

}