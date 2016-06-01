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
        public PersonVM Get(int id = 14)
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            var viewModel = PersonMapper.Map(context.Person.Single(person => person.Id == id));

            context.Dispose();

            return viewModel;
        }

        [HttpGet]
        public PersonVM GetByUsername(string username)
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            var viewModel = PersonMapper.Map(context.Person.Single(person => person.Username == username));

            context.Dispose();

            return viewModel;
        }

        [HttpPost]
        public void Update(PersonVM personData)
        {
            //var personData = (PersonVM)person;

            var dataModel = PersonMapper.Map(personData);

            using (var context = new Model.hackathon_shift_2016_testEntities())
            {
                context.Person.Single(_person => _person.Id == dataModel.Id).Username = dataModel.Username;
                context.Person.Single(_person => _person.Id == dataModel.Id).FirstName = dataModel.FirstName;
                context.Person.Single(_person => _person.Id == dataModel.Id).LastName = dataModel.LastName;
                context.Person.Single(_person => _person.Id == dataModel.Id).Password = dataModel.Password;
                context.Person.Single(_person => _person.Id == dataModel.Id).BirthDate = dataModel.BirthDate;
                context.Person.Single(_person => _person.Id == dataModel.Id).Rating = dataModel.Rating;
                context.Person.Single(_person => _person.Id == dataModel.Id).Email = dataModel.Email;
                context.Person.Single(_person => _person.Id == dataModel.Id).ImageUrl = dataModel.ImageUrl;
                context.SaveChanges();
            }
        }
    }
}
