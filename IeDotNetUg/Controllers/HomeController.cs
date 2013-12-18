using System.Data.Entity;
using System.Linq;
using IeDotNetUg.Data;
using IeDotNetUg.Models;
using System;
using System.Web.Mvc;

namespace IeDotNetUg.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // a lot cleaner
            //var eventDetails = db.EventDetails.FirstOrDefault(x => x.EventDate > DateTime.Now);
            var eventDetails = db.EventDetails.Include(x=>x.Speaker).Include(x=>x.Location).FirstOrDefault(x => x.EventDate > DateTime.Now);
            
            return View(eventDetails);

        }

    }
}
