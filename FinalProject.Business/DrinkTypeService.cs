using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public static class DrinkTypeService
    {
        public static List<DrinkType> Get()
        {
            using (var context = new ProjectFinalEntities())
            {
                return context.DrinkType.ToList();
            }
        }
    }
}
