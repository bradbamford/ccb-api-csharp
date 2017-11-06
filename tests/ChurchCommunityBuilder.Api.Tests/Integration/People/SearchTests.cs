using Shouldly;
using NUnit.Framework;

namespace ChurchCommunityBuilder.Api.Tests.Integration.People {
    [TestFixture]
    public class SearchTests : BaseTest {
        [Test]
        public void integration_people_search_first_and_last_include_inactive_false() {
            string firstName = "Dick";
            string lastName = "Wersch";

            var qo = new Api.People.QueryObject.IndividualQO {
                FirstName = firstName,
                LastName = lastName,
                IncludeInactive = false
            };

            var results = base.ApiClient.People.Individuals.Search(qo);
            results.Individuals.Count.ShouldBe(1);
        }
    }
}
