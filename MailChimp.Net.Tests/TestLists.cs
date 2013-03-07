using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailChimp.Net.Tests
{
    [TestFixture]
    public class TestLists
    {
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void Get()
        {
            // get by name
            var list = ListsApi.GetByName("Test");
            Assert.IsNotNull(list);
            Assert.AreEqual("Test", list.Name);

            // get by id
            list = ListsApi.GetById(list.Id);
            Assert.IsNotNull(list);
            Assert.AreEqual("Test", list.Name);

        }
    }
}
