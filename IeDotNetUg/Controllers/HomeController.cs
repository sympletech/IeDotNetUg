using IeDotNetUg.Models;
using System;
using System.Web.Mvc;

namespace IeDotNetUg.Controllers
{
    public class HomeController : Controller
    {
        //DBContext db = new DbContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new EventDetailModel
                {
                    Title = "Our Next Event",
                    EventDate = new DateTime(2013, 10, 8),
                    Time = "6:30 PM",
                    Location = new LocationModel
                        {
                            Venue = "Riverside.io",
                            StreetAddress = "3567 Main Street",
                            City = "Riverside",
                            State = "CA",
                            ZipCode = 92223
                        },
                    Speaker = new SpeakerModel
                        {
                            LastName = "Lewis",
                            FirstName = "Daniel",
                            BioPicImage = "http://fillmurray.com/200/200"
                        },
                    Description = "<p>Bacon ipsum dolor sit amet pork loin sirloin beef salami jowl. Pork chop jowl beef ribs tenderloin swine pork loin doner chicken pork. Pastrami tri-tip jowl, tongue kielbasa shoulder pork shankle leberkas bacon. Pork chop turducken turkey short ribs. T-bone sirloin turducken cow, ribeye hamburger bacon brisket short loin turkey pork belly. Doner capicola drumstick, shank ground round short ribs prosciutto jowl turducken pancetta bacon pastrami kevin flank. Turkey bresaola kevin spare ribs short ribs bacon boudin hamburger strip steak sirloin ribeye tail ground round.</p><p>Ground round cow meatloaf salami short ribs. Salami bresaola sausage frankfurter ribeye. Turkey fatback short loin frankfurter. Hamburger filet mignon t-bone pig, chuck flank ribeye chicken jowl ground round tenderloin. Tri-tip boudin biltong bacon short loin prosciutto drumstick frankfurter kielbasa shank salami fatback pork. Ham hock meatball tail pancetta short loin jerky, corned beef t-bone shank ham.</p>"
                };



            return View(model);
        }

    }
}
