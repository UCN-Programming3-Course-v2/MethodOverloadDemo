using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Tests
{
    [TestClass()]
    public class SearchTests
    {
        [TestMethod()]
        public void FindByIdTest()
        {
            Search s = new Search();

            Person result = s.Find(id: 1);

            Assert.AreEqual("Hans", result.Name);

        }

        [TestMethod()]
        public void FindByNameTest()
        {
            Search s = new Search();

            Person result = s.Find(name: "Hans");

            Assert.AreEqual(1, result.Id);
        }
    }
}