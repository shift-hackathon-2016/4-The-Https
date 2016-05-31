﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Sonar.Web.Model;

namespace Sonar.Web.Controllers
{
    public class FriendsApiController : ApiController
    {
        [HttpGet]
        public IEnumerable<Person> GetAllFriendsForUser()
        {
            var context = new hackathon_shift_2016_testEntities();
            return context.Person.ToList();
        }
    }
}
