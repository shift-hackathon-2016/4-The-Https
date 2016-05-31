using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.ViewModels;
using Sonar.Web.Model;

namespace Sonar.Web.API
{
    public class EventsApiController : ApiController
    {
        private readonly hackathon_shift_2016_testEntities context;
        public EventsApiController()
        {
            context = new hackathon_shift_2016_testEntities();
        }

        [HttpGet]
        public IEnumerable<EventVM> GetAllEventsForUser()
        {
            return context.Event.Select(e => new EventVM()
            {
                Longitude = e.Longitude,
                Latitude = e.Latitude,
                Name = e.Name,
                Description = e.Description,
                AuthorName = e.Person.FirstName + " " + e.Person.LastName
            });
        }

        [HttpPost]
        public EventVM CreateEvent(EventVM eventVM)
        {
            var mappedEvent = new Event
            {
                Name = eventVM.Name,
                EventTypeID = (int) eventVM.EventType,
                Description = eventVM.Description,
                Longitude = eventVM.Longitude,
                Latitude = eventVM.Latitude,
                //TODO: hardcoded, fake and incorrect data
                AuthorID = 14,
                StartDate = DateTime.Now,
                TownID = 1,
                StateID = 1,
                EndDate = DateTime.Now
            };

            context.Event.Add(mappedEvent);
            context.SaveChanges();
            context.Dispose();

            return eventVM;
        }
    }
}
