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

namespace ChurchCommunityBuilder.Api.Tests.Integration {
    [TestFixture]
    public class CustomFieldListTests : BaseTest {
        [Test]
        public void integration_user_custom_field_list() {
            var results = base.ApiClient.People.CustomFields.List();

            results.CustomFields.Count.ShouldBeGreaterThan(0);
        }
    }
}