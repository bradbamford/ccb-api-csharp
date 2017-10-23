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
    public class FamilyListTest : BaseTest {
        [Test]
        public void integration_family_get_family_get() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = base.ApiClient.People.Individuals.Search(qo);

            var family = base.ApiClient.People.Families.Get(results.Individuals[0].Family.ID.Value);

            family.ShouldNotBe(null);
        }

        [Test]
        public void integration_family_get_family_list() {
            var families = base.ApiClient.People.Families.List(DateTime.UtcNow.AddMonths(-3));
            families.Families.Count.ShouldBeGreaterThan(0);
        }
    }
}
