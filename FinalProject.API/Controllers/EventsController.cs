using FinalProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.API.Controllers
{
    public class EventsController : ApiController
    {
        public IHttpActionResult Get()
        {
            var ev = EventService.Get().Select(d =>
            new
            {
                Id = d.Id,
                NomAssociation = d.Association.Name
            }).ToList();
            if (ev != null)
            {
                return Ok(ev);
            }
            else
            {
                return NotFound();
            }
        }
        [Route("api/Events/{id}/Participants")]
        public IHttpActionResult GetParticipant(int id)
        {
            var members = EventService.GetParticipant(id).Select(m =>
            new
            {
                MemberId = m.MemberId,
                FirstName = m.Member.FirstName,
                LastName = m.Member.LastName,
                Credit = m.Credit
            }).ToList();
            if (members != null)
            {
                return Ok(members);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
