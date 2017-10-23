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
    public class EventListTests : BaseTest {
        [Test]
        public void integration_events_get_events() {
            var qo = new Api.Events.QueryObject.ProfileQO { PageNumber = 1, RecordsPerPage = 20, IncludeGuestList = true, ModifiedSince = new DateTime(2015, 10, 29) };
            var events = base.ApiClient.Events.Profiles.List(qo);
            events.Events.Count.ShouldBeGreaterThan(0);
        }
    }
}
