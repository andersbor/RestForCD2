using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestForCD2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestForCD2.Repositories.Tests
{
    [TestClass()]
    public class StringsRepositoryTests
    {
        [TestMethod()]
        public void AddTest()
        {
            StringsRepository repo = new();
            repo.Add("Hello");
            Assert.AreEqual(3, repo.GetAll().Count());
            Assert.ThrowsException<ArgumentNullException>(() => repo.Add(null));
            Assert.ThrowsException<ArgumentException>(() => repo.Add(""));
        }
    }
}