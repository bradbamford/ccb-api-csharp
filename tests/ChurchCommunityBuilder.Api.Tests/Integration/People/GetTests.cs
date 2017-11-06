using Shouldly;
using NUnit.Framework;

namespace ChurchCommunityBuilder.Api.Tests.Integration.People {
    [TestFixture]
    public class GetTests : BaseTest {
        [Test]
        public void integration_people_get_include_inactive_false() {
            var id = 776;
            var individual = base.ApiClient.People.Individuals.Get(id, false);
            individual.ShouldNotBeNull();
        }

        [Test]
        public void integration_people_get_include_inactive_true() {
            var id = 776;
            var individual = base.ApiClient.People.Individuals.Get(id, true);
            individual.ShouldNotBeNull();
        }
    }
}
