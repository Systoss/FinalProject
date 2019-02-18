using FinalProject.Business;
using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.API.Controllers
{
    public class DrinksController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post([FromBody]Drink drink)
        {
            var d = DrinkService.Create(drink);
            if (d > 0)
            {
                return Created("", drink);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
