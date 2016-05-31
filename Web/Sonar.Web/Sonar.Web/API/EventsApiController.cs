using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.Web.Model;

namespace Sonar.Web.Controllers
{
    public class EventsApiController : ApiController
    {
        [HttpGet]
        public IEnumerable<Event> GetAllEventsForUser()
        {
            var context = new hackathon_shift_2016_testEntities();

            return context.Event.ToList();
        }
    }
}
