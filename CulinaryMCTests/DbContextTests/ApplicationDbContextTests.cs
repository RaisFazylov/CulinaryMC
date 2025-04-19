using MasterClassManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CulinaryMCTests.DbTests
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void SimpleDbTest()
        {
            var testItem = new MasterClass
            {
                Name = "Test",
                Description = "Test",
                Category = "Test",
                Date = DateTime.Now
            };

            using (var db = new ApplicationDbContext())
            {
                db.MasterClasses.Add(testItem);
                db.SaveChanges();

                db.MasterClasses.Remove(testItem);
                db.SaveChanges();
            }

            Assert.IsTrue(true);
        }
    }
}