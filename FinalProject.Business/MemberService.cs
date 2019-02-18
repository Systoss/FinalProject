using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public static class MemberService
    {
        public static List<Member> GetEtudiantSerieux()
        {
            using (var context = new ProjectFinalEntities())
            {
                return context.Member.Where(m => m.Participation.Count() == 0).ToList();
            }
        }

        public static List<Member> GetEtudiantNoDepense()
        {
            using (var context = new ProjectFinalEntities())
            {
                return context.Member.Where(m => m.Participation.Any(p => p.Drink.Count() == 0)).ToList();
            }
        }

        public static List<Member> GetEtudiantAlcool()
        {
            using (var context = new ProjectFinalEntities())
            {
                return context.Member.Where(m => m.Participation.Any(p => p.Drink.Any(d => d.DrinkType.AlcoholContent > 0))).ToList();
            }
        }
    }
}
