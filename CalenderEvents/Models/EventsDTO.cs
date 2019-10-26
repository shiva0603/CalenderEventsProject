using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalenderEvents.Models
{
    public class EventsDTO
    {
        //Declaring all the DTO objects for an Event
        public DateTime EventDateTime { get; set; }
        public string EventName { get; set; }

    }
}