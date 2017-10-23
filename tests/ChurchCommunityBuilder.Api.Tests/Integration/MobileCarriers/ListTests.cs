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

namespace ChurchCommunityBuilder.Api.Tests.Integration.MobileCarriers {
    [TestFixture]
    public class ListTests : BaseTest {
        [Test]
        public void integration_mobile_carriers_list() {
            var results = base.ApiClient.People.MobileCarriers.List();
            results.MobileCarriers.Count.ShouldBeGreaterThan(0);
        }
    }
}
