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


namespace ChurchCommunityBuilder.Api.Tests.Integration.Events {
    [TestFixture]
    public class EventTests : BaseTest {
        [Test]
        public void integration_events_get_event() {
            var profile = base.ApiClient.Events.Profiles.Get(1627);
            profile.ShouldNotBe(null);
        }
    }
}
