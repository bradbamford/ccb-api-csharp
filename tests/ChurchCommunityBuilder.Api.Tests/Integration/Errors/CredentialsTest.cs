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

namespace ChurchCommunityBuilder.Api.Tests.Integration.Errors {
    [TestFixture]
    public class CredentialsTest {
        private ApiClient _apiClient;
        [OneTimeSetUp]
        public void Setup() {
            _apiClient = new ApiClient("multisites", "chadmeyer", "Psalms46:10");
        }

        [Test]
        public void integration_invalid_church_code() {
            var membershipTypes = _apiClient.People.MembershipTypes.List();
        }
    }
}