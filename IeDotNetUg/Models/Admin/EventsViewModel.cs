using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IeDotNetUg.Models.Admin
{
    public class EventsViewModel
    {
        public string Title { get; set; }
        public string EventDate { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public int EventTypeId { get; set; }
        public IEnumerable<SelectListItem> EventTypeChoices { get; set; }
        public int LocationId { get; set; }
        public IEnumerable<SelectListItem> LocationChoices { get; set; }
        public int SpeakerId { get; set; }
        public IEnumerable<SelectListItem> SpeakerChoices { get; set; }

    }

    public class EventTypeModel
    {
        public int  Id { get; set; }
        public string  Name { get; set; }
    }
}