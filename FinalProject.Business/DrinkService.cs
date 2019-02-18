using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public static class DrinkService
    {
        public static int Create(Drink drink)
        {
            using(var context = new ProjectFinalEntities())
            {
                drink.Participation = context.Participation.FirstOrDefault(p => p.MemberId == drink.MemberId && p.EventId == drink.EventId);
                drink.DrinkType = context.DrinkType.FirstOrDefault(d => d.Id == drink.DrinkTypeId);
                context.Drink.Attach(drink);
                context.Drink.Add(drink);
                return context.SaveChanges();
            }
            
        }
    }
}
