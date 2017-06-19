using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetProject_API.DataAccess;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PetProject_API
{
    [Route("api/[controller]")]
    public class FeedController : Controller
    {
        private readonly PetDataContext _context;
        public FeedController(PetDataContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Feed>> Get()
        {
            //var ctx = new ApplicationDbContext(" ");
            //ctx.
            var data = _context.;

            return new Feed[] {
                new Feed() { message = "First Fedd", type = Feed.FeedType.POST },
                new Feed() { message = "Second Fedd", type = Feed.FeedType.POST },
                new Feed() { message = "Third Fedd", type = Feed.FeedType.POST },
                new Feed() { message = "Fourth Fedd", type = Feed.FeedType.POST },
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

        public class Feed
        {
            public enum FeedType
            {
                POST = 0
            };

            public string message { get; set; }
            public FeedType type { get; set; }
        }
    }
}
