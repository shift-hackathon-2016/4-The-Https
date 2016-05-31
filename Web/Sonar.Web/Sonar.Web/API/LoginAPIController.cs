using Sonar.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sonar.Web.API
{
    public class LoginAPIController : ApiController
    {
        [HttpPost]
        public bool login(string usr, string pwd)
        {
            //var context = new hackathon_shift_2016_testEntities();

            //return context.Event.Select(e => new EventVM()
            //{
            //    Longitude = e.Longitude,
            //    Latitude = e.Latitude,
            //    Name = e.Name,
            //    Description = e.Description,
            //    AuthorName = e.Person.FirstName + " " + e.Person.LastName
            //});
            return false;
        }
    }
}
