using System;

namespace IeDotNetUg.Models
{
    public class EventDetailModel
    {
        public string Title { get; set; }
        public string EventDate { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public LocationModel Location { get; set; }
        public SpeakerModel Speaker { get; set; }

    }
}