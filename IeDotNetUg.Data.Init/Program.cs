using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IeDotNetUg.Data.Init
{
    class Program
    {
        static void Main(string[] args)
        {
            DBContext db = new DBContext();
            System.Data.Entity.Database.SetInitializer<DBContext>(new DbInit());

            try
            {
                Console.Write(db.EventDetails.Count());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
