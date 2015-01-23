﻿using System;
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
    class UpdateIndividualTest {
        private ApiClient _apiClient;
        [TestFixtureSetUp]
        public void Setup() {
            _apiClient = new ApiClient("multisite", "chadmeyer", "Psalms46:10");
        }

        [Test]
        public void integration_individual_search_update_individual() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = _apiClient.People.Individuals.Search(qo);
            var updatedIndividual = _apiClient.People.Individuals.Update(results.Individuals[0]);

            updatedIndividual.ShouldNotBe(null);
        }

        [Test]
        public void integration_individual_search_update_individual_bad_email() {
            var qo = new IndividualQO();
            qo.FirstName = "chad";
            qo.LastName = "meyer";

            var results = _apiClient.People.Individuals.Search(qo);
            var indiviudal = results.Individuals[0];
            indiviudal.Email = "churchdatabase.com";
            var updatedIndividual = _apiClient.People.Individuals.Update(indiviudal);

            updatedIndividual.Email.ShouldNotStartWith("churchdatabase.com");
        }
    }
}
