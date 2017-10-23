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

namespace ChurchCommunityBuilder.Api.Tests.Integration.Individual {
    [TestFixture]
    public class LoginTests : BaseTest {
        [Test]
        public void integration_indivdiual_login_with_success() {
            var result = base.ApiClient.People.Individuals.Login("52projects", "Psalms46:10");
            result.ShouldBeGreaterThan(0);
        }
    }
}