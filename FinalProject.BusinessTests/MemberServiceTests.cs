using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business.Tests
{
    [TestClass()]
    public class MemberServiceTests
    {
        [TestMethod()]
        public void GetEtudiantSerieuxTest()
        {
            var expected = 1;
            var actual = MemberService.GetEtudiantSerieux().Count;
            Assert.AreEqual(expected, actual);



        }
    }
}