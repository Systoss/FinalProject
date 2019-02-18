using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public static class EventService
    {
        public static List<Event> Get()
        {
            using(var context = new ProjectFinalEntities())
            {
                return context.Event.Include("Association").ToList();
            }
        }

        public static List<Participation> GetParticipant(int id)
        {
            using (var context = new ProjectFinalEntities())
            {
                return context.Participation.Include("Member").Where(p => p.EventId == id).ToList();
            }
        }
    }
}
