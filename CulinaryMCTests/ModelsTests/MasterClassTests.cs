using MasterClassManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CulinaryMCTests.ModelsTests
{
    [TestClass]
    public class MasterClassTests
    {
        [TestMethod]
        public void TestId()
        {
            var mc = new MasterClass();
            mc.Id = 1;
            Assert.AreEqual(1, mc.Id);
        }

        [TestMethod]
        public void TestName()
        {
            var mc = new MasterClass();
            mc.Name = "Test";
            Assert.AreEqual("Test", mc.Name);
            mc.Name = null;
            Assert.IsNull(mc.Name);
        }

        [TestMethod]
        public void TestDate()
        {
            var mc = new MasterClass();
            var date = DateTime.Now;
            mc.Date = date;
            Assert.AreEqual(date, mc.Date);
        }
    }
}