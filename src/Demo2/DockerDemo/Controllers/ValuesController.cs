using System.Collections.Generic;
using DockerDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly RedisService _redis;

        public ValuesController(RedisService redis)
        {
            _redis = redis;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{key}")]
        public string Get(string key)
        {
            return _redis.Get(key);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _redis.Set("val", value);
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
    }
}
