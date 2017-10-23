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

namespace ChurchCommunityBuilder.Api.Tests.Integration.Financial.Accounts {
    [TestFixture]
    public class ListTests : BaseTest {
        [Test]
        public void integration_financial_transaction_groups_list() {
            var results = base.ApiClient.Financials.Accounts.List();
            results.TransactionDetailTypes.Count.ShouldBeGreaterThan(0);
        }
    }
}