using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailChimp.Net.Tests
{
    [TestFixture]
    public class TestSusbcribe
    {
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void Subscribe()
        {
            // get by name
            var list = ListsApi.GetByName("Test");
            Assert.IsNotNull(list);

            var subscriber = new Subscriber("test@domain.com") { FirstName = "Test", LastName = "User" };
            subscriber.AddInterest("Group1", "Value1");
            //subscriber.AddInterest("Group1", "Value2");
            ListsApi.Subscribe(list.Id, subscriber);

            //var g = list.InterestGroups;
        }
    }
}
