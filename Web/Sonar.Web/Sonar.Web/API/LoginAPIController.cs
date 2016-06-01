using Sonar.ViewModels;
using Sonar.Web.Model;
using System.Linq;
using System.Web.Http;

namespace Sonar.Web.API
{
    public class LoginAPIController : ApiController
    {
        private readonly hackathon_shift_2016_testEntities context;
        public LoginAPIController()
        {
            context = new hackathon_shift_2016_testEntities();
        }

        [HttpPost]
        public bool login(string usr, string pwd)
        {
            var useri = context.Event.Select(e => new PersonVM()
            {
                Username = e.Person.Username,
                Password = e.Person.Password
            }).ToList();

            return useri.Any(user => user.Username == usr && user.Password == pwd);
        }
    }
}
