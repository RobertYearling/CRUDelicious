using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;

namespace CRUDelicious.Context
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes {get;set;}
        // add a emmet for get {get;set;}
    }
}