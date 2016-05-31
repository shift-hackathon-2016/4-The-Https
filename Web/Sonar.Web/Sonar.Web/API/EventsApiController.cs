using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.Web.Model;

namespace Sonar.Web.Controllers
{
    public class EventsApiController : ApiController
    {
        [HttpGet]
        public IEnumerable<EventVM> GetAllEventsForUser()
        {
            var context = new hackathon_shift_2016_testEntities();

            return context.Event.Select(e => new EventVM()
            {
                Longitude = e.Longitude,
                Latitude = e.Latitude,
                Name = e.Name,
                Description = e.Description,
                AuthorName = e.Person.FirstName + " " + e.Person.LastName
            });
        }
    }


}
