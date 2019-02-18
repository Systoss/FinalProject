using FinalProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.API.Controllers
{
    public class DrinkTypesController : ApiController
    {
        public IHttpActionResult Get()
        {
            var drinkType = DrinkTypeService.Get().Select(d => 
            new 
            {
                Id = d.Id,
                Description = d.Description,
                AlcoholContent = d.AlcoholContent ?? 0
            }).ToList();
            if (drinkType != null)
            {
                return Ok(drinkType);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
