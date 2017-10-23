using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Financial.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Financial.OnlineGifts {
    [TestFixture]
    public class CreateTests : BaseTest { 
        [Test]
        public void integration_financial_create_online_gift_test() {
            var rnd = new Random();

            var onlineGift = new OnlineGift();
            onlineGift.AccountID = 44; // Missions
            onlineGift.CampusID = 1; // Main Campus
            onlineGift.IndividualID = 4103; // Barney Rubble
            onlineGift.GiftAmount = rnd.Next(3, 176);
            onlineGift.MerchantAuthorizationCode = "2346356";
            onlineGift.MerchantTransactionID = "1235123465";
            onlineGift.MerchantName = "52projects";

            var returnGift = base.ApiClient.Financials.OnlineGifts.Create(onlineGift);
            returnGift.ShouldNotBe(null);
        }
    }
}
