using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sonar.Web.Controllers
{
    public class HomeAPIController : ApiController
    {
        [HttpGet]
        public IEnumerable<TownVM> dohvatiSveGradove()
        {
            var context = new Model.hackathon_shift_2016_testEntities();
            
            return context.Town.Select(town => new TownVM() {
                Name = town.Name,
                Id = town.Id
            });
        }

        [HttpGet]
        public List<object> dohvatiSveStringove()
        {
            //Model.hackathon_shift_2016_testEntities context = new Model.hackathon_shift_2016_testEntities();

            List<object> l = new List<object>();
            //var nesto = context.Town.Select(town => town);
            l.Add(new { prviField = "Nesto", drugiField = 2 });

            return l;
        }
    }

    public class TownVM {
        public string Name;
        public int Id;
    }
}
