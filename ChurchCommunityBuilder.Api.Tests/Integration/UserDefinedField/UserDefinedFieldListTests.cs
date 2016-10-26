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
    public class UserDefinedFieldListTests : BaseTest {
        [Test]
        public void integration_user_defined_field_list_group_1() {
            var results = base.ApiClient.People.UserDefinedFields.ListGroup1();

            results.Items.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_user_defined_field_list_ind_1() {
            var results = base.ApiClient.People.UserDefinedFields.ListIndividual("udf_ind_pulldown_1");

            results.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
