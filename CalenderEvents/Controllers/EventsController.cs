using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalenderEvents.Models;

namespace CalenderEvents.Controllers
{
    public class EventsController : ApiController
    {
        EventsDTO[] eventsCollections = new EventsDTO[]
        {
           new EventsDTO{EventDateTime = DateTime.Parse("6/24/2019 7:30:00 am"),EventName = "TaskForToday" },
           new EventsDTO{EventDateTime = DateTime.Parse("8/15/2019 2:30:00 pm"),EventName = "TeamStatus" },
           new EventsDTO{EventDateTime = DateTime.Parse("9/10/2019 4:30:00 pm"),EventName = "ProductionUpdates" }
        };

        public IEnumerable<EventsDTO> GetAllEvents()
        {
            //Returns all the events 
            return eventsCollections;
        }

        public IHttpActionResult GetEventByName(string eventName)
        {
            //Returns the event based on the event name
            if(eventName != null)
            {
                var eventDetails = eventsCollections.Where(eachEvent => eachEvent.EventName.Equals(eventName));

                if (eventDetails.Count() == 0)
                {
                    
                    return Content(HttpStatusCode.BadRequest, "No Such event exists");
                }
                else
                {
                    return Ok(eventDetails);
                }
            }
            return Content(HttpStatusCode.BadRequest, "EventName is Null");

        }
    }
}
