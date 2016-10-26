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
    public class IndividualSearchTests : BaseTest { 
        [Test]
        public void integration_individual_search_search_by_name() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = base.ApiClient.People.Individuals.Search(qo);

            results.Individuals.Count.ShouldBeGreaterThan(0);
            var individual = results.Individuals[0];
            
            individual.FamilyMembers.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_individual_search_search_by_street_address() {
            var qo = new IndividualQO();
            qo.ZipCode = "76262";
            qo.State = "TX";

            var results = base.ApiClient.People.Individuals.Search(qo);

            results.Individuals.Count.ShouldBeGreaterThan(1);
        }

        [Test]
        public void integration_individual_search_search_by_name_first_three_letters() {
            var qo = new IndividualQO();
            qo.FirstName = "cha";
            qo.LastName = "mey";

            var results = base.ApiClient.People.Individuals.Search(qo);

            results.Individuals.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_individual_search_search_by_name_first_three_letters_first_name() {
            var qo = new IndividualQO();
            qo.FirstName = "cha";

            var results = base.ApiClient.People.Individuals.Search(qo);

            results.Individuals.Count.ShouldBeGreaterThan(0);
        }
    }
}
