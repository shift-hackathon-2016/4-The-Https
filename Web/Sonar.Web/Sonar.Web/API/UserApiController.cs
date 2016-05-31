using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sonar.Web.API
{
    public class UserApiController : ApiController
    {

        [HttpGet]
        public object dohvatiProfil(int id)
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            var viewModel = context.Person.First(person => person.Id == id);

            context.Dispose();

            return viewModel;
        }
    }
}
