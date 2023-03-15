using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestForCD2.Models;
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
        private TeachersRepository repo = new();
        [TestMethod()]
        public void AddTest()
        {
            Teacher another = new() { Name = "Another" };
            repo.Add(another);
            Assert.AreEqual(3, repo.Get().Count());
            
            Teacher nameNull = new() { Name = null };
            Teacher nameEmpty = new() { Name = "" };

            Assert.ThrowsException<ArgumentNullException>(() => repo.Add(nameNull));
            Assert.ThrowsException<ArgumentException>(() => repo.Add(nameEmpty));
        }
    }
}