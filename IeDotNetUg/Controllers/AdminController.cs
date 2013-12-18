using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using IeDotNetUg.Data;
using IeDotNetUg.Models.Admin;

namespace IeDotNetUg.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Events()
        {
            var SpeakerChoices = db.Speakers
                .OrderBy(x => x.LastName)
                .ToList()
                .Select(x => new SelectListItem
                {
                    Text = string.Format("{0},{1}", x.LastName, x.FirstName),
                    Value = x.SpeakerId.ToString()
                });

            var LocationChoices = db.Locations
                .OrderBy(x => x.Venue)
                .ToList()
                .Select(x => new SelectListItem
                {
                    Text = string.Format("{0} - {1}", x.Venue, x.City),
                    Value = x.LocationId.ToString()
                });



            EventsViewModel vModel = new EventsViewModel
            {
                EventTypeChoices = new List<SelectListItem>(),
                LocationChoices = LocationChoices,
                SpeakerChoices = SpeakerChoices,


            };
            return View(vModel);
            
        }

    }
}
