using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Groups.Entity;
using ChurchCommunityBuilder.Api.Groups.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Groups {
    [TestFixture]
    public class ProfileGetTests : BaseTest {
        [Test]
        public void integration_groups_get_group() {
            var result = base.ApiClient.Groups.GroupProfiles.Get(17);
            result.ShouldNotBe(null);
        }
    }
}
