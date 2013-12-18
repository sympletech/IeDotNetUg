using System;

namespace IeDotNetUg.Data.Models
{
    public class EventDetail
    {
        public int EventDetailId { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public Speaker Speaker { get; set; }
        public EventType EventType { get; set; }

    }
}