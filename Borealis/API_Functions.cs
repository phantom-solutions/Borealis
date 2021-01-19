using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//
namespace Borealis.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        //public void API_Console_Update(string action, string details)
        //{
        //    Console.WriteLine("{0} | Request: {1} was made by {2}", DateTime.Now, action, details);
        //}

        //http://localhost:5000/api/server/query
        [HttpGet("query")]
        public Shared_Classes.ControlPanel Query()
        {
            return new Shared_Classes.ControlPanel
            {
                IP = (Dns.GetHostAddresses(Dns.GetHostName())[1].ToString()),
                HOSTNAME = Dns.GetHostName(),
                GUID = "PlaceholderGUID"
            };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            int WebHook = id*5;
        //    API_Console_Update("Get / Value", "localhost");
            return WebHook.ToString();
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
