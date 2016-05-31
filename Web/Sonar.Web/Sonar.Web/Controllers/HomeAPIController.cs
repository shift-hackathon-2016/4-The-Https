using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Sonar.Web.Controllers
{
    public class HomeAPIController : ApiController
    {
        [HttpGet]
        public List<Model.Town> dohvatiSveStringove()
        {
            var context = new Model.hackathon_shift_2016_testEntities();

            List<Model.Town> listaGradova = new List<Model.Town>();
            var nesto = context.Town.Select(town => town);
            listaGradova.AddRange(nesto.ToList());
            
            return listaGradova;
        }
    }
}
