using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PetProject_API.Controllers
{
    [Route("api/[controller]")]
    public class RecommendController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Recommendation> Get()
        {
            return new Recommendation[] {
                new Recommendation() { message = "Redmond Kennel Services", type = Recommendation.RecommendationType.PRODUCT, linkId = "1234" },
                new Recommendation() { message = "Reliable Dog Trainer", type = Recommendation.RecommendationType.PRODUCT, linkId = "2234" },
                new Recommendation() { message = "Jump Start Dog Walker", type = Recommendation.RecommendationType.PRODUCT , linkId = "3234"},
                new Recommendation() { message = "Mayflower dog groomer", type = Recommendation.RecommendationType.PRODUCT , linkId = "4234"}
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class Recommendation
        {
            public enum RecommendationType
            {
                PRODUCT = 0,
                SERVICE,
            };

            public string message { get; set; }
            public RecommendationType type { get; set; }
            public string linkId { get; set; }
        }
    }
}
