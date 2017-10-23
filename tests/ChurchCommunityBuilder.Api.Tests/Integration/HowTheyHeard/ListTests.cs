using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.HowTheyHeard {
    [TestFixture]
    public class ListTests : BaseTest {
        [Test]
        public void integration_how_they_heard_list() {
            var results = base.ApiClient.People.HowTheyHeard.List();
            results.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}