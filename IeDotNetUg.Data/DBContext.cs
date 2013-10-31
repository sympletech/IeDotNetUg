using IeDotNetUg.Data.Models;
using System.Data.Entity;

namespace IeDotNetUg.Data
{
   public class DBContext : DbContext 
    {

       public DBContext()
       {

       }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
       }
       
       public DbSet<EventDetail> EventDetails { get; set; }
       public DbSet<Location> Locations { get; set; }
       public DbSet<Speaker> Speakers { get; set; }
    }
}
