using System.Configuration;
using IeDotNetUg.Data.Configuration;
using IeDotNetUg.Data.Models;
using System.Data.Entity;

namespace IeDotNetUg.Data
{
    public class DataContext : DbContext
    {
        // EF DataContext setup:
        // http://msdn.microsoft.com/en-us/data/jj592674

        // Once EF is set, to enable Migrations:
        // http://msdn.microsoft.com/en-us/data/jj193542


        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public static string ConnectionStringName
        {
            // Essentially allows us to store the name of the connection string we want to use in the
            // appSettings, and modify just that key if we want to push to Quality or Production
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }

                return "Default";
            }
        }


        public DataContext() : base(DataContext.ConnectionStringName) { }

        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new EventDetailConfiguration());

            //base.OnModelCreating(modelBuilder);
        }

    }
}
