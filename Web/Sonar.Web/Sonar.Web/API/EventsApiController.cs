﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.ViewModels;
using Sonar.Web.Model;

namespace Sonar.Web.Controllers
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
                AuthorName = e.Person.FirstName + " " + e.Person.LastName,
                Id = e.Id,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Town = e.Town.Name,
                TownId = e.TownID,
                State = e.EventState.Name,
                StateId = e.StateID,
                UrlSlike = e.ImageUrl,
                ContactNumber = e.Contact,
                EventType = e.EventType.Name,
                EventTypeID = e.EventTypeID
            });
        }

        public EventVM CreateEvent(EventVM eventVM)
        {
            var mappedEvent = new Event()
            {
                Name = eventVM.Name,
                Description = eventVM.Description,
                Longitude = eventVM.Longitude,
                Latitude = eventVM.Latitude,
                //TODO: mocked data, fix with real user data
                AuthorID = 1
            };

            context.Event.Add(mappedEvent);
            context.SaveChanges();
            context.Dispose();

            return eventVM;
        }
    }

    public class EventDto
    {
        public float? Longitude;
        public float? Latitude;
        public string Name;
        public string Description;
        public string AuthorName;
    }
}
