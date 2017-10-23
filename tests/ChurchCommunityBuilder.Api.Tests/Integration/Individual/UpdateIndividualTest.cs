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
    class UpdateIndividualTest : BaseTest { 
        [Test]
        public void integration_individual_search_update_individual() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = base.ApiClient.People.Individuals.Search(qo);
            var updatedIndividual = base.ApiClient.People.Individuals.Update(results.Individuals[0]);

            updatedIndividual.ShouldNotBe(null);
        }

        [Test]
        public void integration_individual_search_update_individual_bad_email() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = base.ApiClient.People.Individuals.Search(qo);
            var indiviudal = results.Individuals[0];
            indiviudal.Email = "churchdatabase.com";
            var updatedIndividual = base.ApiClient.People.Individuals.Update(indiviudal);

            updatedIndividual.Email.ShouldNotStartWith("churchdatabase.com");
        }
    }
}
