using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){Id=0,Author="Emily",Description="The brain is wider than the sky",Title="Inspirational"},
            new Quote(){Id=1, Author="Chetan Bhagath",Description="Revolution",Title="Fiction"},
            new Quote(){Id=2,Author="Richard Bach",Description="True Love stories never have endings",Title="Love stories"}
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        [HttpPost]
        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }

    }
}
