using System.Linq;
using System.Web.Http;
using Sonar.Web.Model;

namespace Sonar.Web.API
{
    public class UserApiController : ApiController
    {
        [HttpGet]
        public Person dohvatiProfil(int id)
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            var viewModel = context.Person.First(person => person.Id == id);

            context.Dispose();

            return viewModel;
        }
    }
}
