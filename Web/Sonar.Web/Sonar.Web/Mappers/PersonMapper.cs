using Sonar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonar.Web.Mappers
{
    public class PersonMapper
    {
        public static PersonVM Map(Model.Person person)
        {
            return new PersonVM()
            {
                Username = person.Username,
                Email = person.Email,
                FirstName = person.FirstName,
                LastName = person.LastName,
                BirthDate = person.BirthDate,
                Rating = person.Rating,
                ImageUrl = person.ImageUrl
            };
        }
    }
}