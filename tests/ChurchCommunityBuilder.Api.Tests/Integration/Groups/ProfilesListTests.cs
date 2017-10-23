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
    public class ProfileListsTests : BaseTest {
        [Test]
        public void integration_groups_list_groups() {
            var groups = new List<Group>();

            for (int i = 1; i < 100; i++) {
                var qo = new GroupProfileQO { IncludeParticipants = false, RecordsPerPage = 5, PageNumber = 65 };
                var results = base.ApiClient.Groups.GroupProfiles.List(qo);
                groups.AddRange(results.Groups);
                results.Groups.Count.ShouldBeGreaterThan(0);
            }
        }
    }
}
