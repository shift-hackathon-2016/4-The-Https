using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.Web.Model;
using Sonar.ViewModels;
using System;

namespace Sonar.Web.Controllers
{
    public class FriendsApiController : ApiController
    {
        [HttpGet]
        public IEnumerable<PersonVM> GetAllFriendsForUser()
        {
            var context = new hackathon_shift_2016_testEntities();
            return context.Person.Select(e => new PersonVM()
            {
                Id = e.Id,
                FirstName = e.FirstName,
                ImageUrl = e.ImageUrl,
                LastName = e.LastName,
                BirthDate = e.BirthDate,
                Username = e.Username,
                Email = e.Email,
                Rating = e.Rating
            });
        }
    }
}
