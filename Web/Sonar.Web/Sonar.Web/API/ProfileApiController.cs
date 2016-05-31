using Sonar.ViewModels;
using Sonar.Web.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sonar.Web.API
{
    public class ProfileApiController : ApiController
    {
        [HttpGet]
        public PersonVM GetPerson(int id = 14)
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            var viewModel = PersonMapper.Map(context.Person.Single(person => person.Id == id));

            context.Dispose();

            return viewModel;
        }
    }
}
