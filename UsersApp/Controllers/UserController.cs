using System.Collections.Generic;
using System.Web.Http;
using Persistence;

namespace UsersApp.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return null;
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
