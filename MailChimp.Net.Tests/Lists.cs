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
        public void GetOrCreate()
        {
            // get by name
            var list = Lists.GetByName("Test");
            Assert.IsNotNull(list);
            Assert.AreEqual("Test", list.Name);

            // get by id
            list = Lists.GetById(list.Id);
            Assert.IsNotNull(list);
            Assert.AreEqual("Test", list.Name);

        }
    }
}
