using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {
        fruit[] MyFruit = new fruit[]
        {
            new fruit {Id = 1, Name = "香蕉", Price = 30, Weight=5.2},
            new fruit {Id = 2, Name = "鳳梨", Price=50, Weight=3.6},
            new fruit {Id = 3, Name = "蘋果", Price=40, Weight=4.2}
        };
        public IHttpActionResult Get(int id)
        {
            var X = MyFruit.FirstOrDefault((p) => p.Id == id);
            if (X == null) { return NotFound(); }
            else { return Ok(X); }
        }
        public IEnumerable<fruit> Get()
        {
            return (MyFruit);
        }
    }
}
