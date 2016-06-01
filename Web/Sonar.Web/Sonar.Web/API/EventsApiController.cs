using Sonar.ViewModels;
using Sonar.Web.Mappers;
using Sonar.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
            var response = context.Event.Select(e => new EventVM()
            {
                Longitude = e.Longitude,
                Latitude = e.Latitude,
                Name = e.Name,
                Description = e.Description,
                Person = e.Person.FirstName + " " + e.Person.LastName,
                Id = e.Id,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Town = e.Town.Name,
                TownId = e.TownID,
                EventState = e.EventState.Name,
                StateId = e.StateID,
                ImageUrl = e.ImageUrl,
                Contact= e.Contact,
                EventType = e.EventType.Name,
                EventTypeID = e.EventTypeID
            });
            return response;
        }
        [HttpPost]
        public void Update(EventVM eventData)
        {
            //var personData = (PersonVM)person;

            var dataModel = EventMapper.Map(eventData);

            using (var context = new Model.hackathon_shift_2016_testEntities())
            {
                context.Event.Single(_event => _event.Id == dataModel.Id).Id = dataModel.Id;
                context.Event.Single(_event => _event.Id == dataModel.Id).Name = dataModel.Name;
                context.Event.Single(_event => _event.Id == dataModel.Id).Description = dataModel.Description;
                context.Event.Single(_event => _event.Id == dataModel.Id).StartDate = dataModel.StartDate;
                context.Event.Single(_event => _event.Id == dataModel.Id).EndDate = dataModel.EndDate;
                context.Event.Single(_event => _event.Id == dataModel.Id).Longitude = dataModel.Longitude;
                context.Event.Single(_event => _event.Id == dataModel.Id).Latitude = dataModel.Latitude;
               context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<EventVM> GetEventsAroundUs()
        {
            var response = context.Event.Select(e => new EventVM()
            {
                Longitude = e.Longitude,
                Latitude = e.Latitude,
                Name = e.Name,
                Description = e.Description,
                Person = e.Person.FirstName + " " + e.Person.LastName,
                Id = e.Id,
                StartDate = e.StartDate,
                EndDate = e.EndDate,
                Town = e.Town.Name,
                TownId = e.TownID,
                EventState = e.EventState.Name,
                StateId = e.StateID,
                ImageUrl = e.ImageUrl,
                Contact = e.Contact,
                EventType = e.EventType.Name,
                EventTypeID = e.EventTypeID
            });
            return response;
        }

        [HttpPost]
        public EventVM CreateEvent(EventVM eventVM)
        {
            var mappedEvent = new Event
            {
                Name = eventVM.Name,
                EventTypeID = eventVM.EventTypeID,
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
