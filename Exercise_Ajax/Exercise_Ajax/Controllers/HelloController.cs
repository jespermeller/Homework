using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exercise_Ajax.Controllers
{
    [RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
        // GET api/values
        [HttpGet, Route("")]
        public IHttpActionResult Get()
        {
            string greet = "Fuck dig";
            var response = Request.CreateResponse(System.Net.HttpStatusCode.OK, greet);
            response.Headers.Add("Access-Control-Allow-Origin", "*");

            return ResponseMessage(response);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
