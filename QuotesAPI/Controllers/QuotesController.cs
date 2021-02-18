using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesAPI.Data;
using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {

        private QuotesDBContext _quotesDbContext;

        public QuotesController(QuotesDBContext quotesDBContext)
        {
            _quotesDbContext = quotesDBContext;
        }

        // GET: api/<Quotes>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_quotesDbContext.Quotes);
   
        }

        // GET api/<Quotes>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //built in method - find
           var quote = _quotesDbContext.Quotes.Find(id);
            return "value";
        }

        // POST api/<Quotes>
        [HttpPost]
        public void Post([FromBody] Quote quote)
        {
            _quotesDbContext.Quotes.Add(quote);
            //saves changes done in db
            _quotesDbContext.SaveChanges();
        }

        // PUT api/<Quotes>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Quotes>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
