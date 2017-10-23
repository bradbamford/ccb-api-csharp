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

namespace ChurchCommunityBuilder.Api.Tests.Integration.Family {
    [TestFixture]
    public class CampusListTests : BaseTest {
        [Test]
        public void integration_family_get_campus_list() {
            var campuses = base.ApiClient.People.Campuses.List();
            campuses.Campuses.Count.ShouldBeGreaterThan(0);
        }
    }
}
