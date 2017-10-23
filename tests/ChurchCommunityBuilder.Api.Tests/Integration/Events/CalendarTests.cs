using System;
using NUnit.Framework;
using Shouldly;


namespace ChurchCommunityBuilder.Api.Tests.Integration.Events {
    [TestFixture]
    public class CalendarTests : BaseTest {
        [Test]
        public void integration_calendars_get_calendar() {
            var qo = new Api.Events.QueryObject.CalendarQO { DateStart = new DateTime(2015, 10, 20), DateEnd = new DateTime(2015, 11, 1) };
            var events = base.ApiClient.Events.Calendar.List(qo);
            events.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
