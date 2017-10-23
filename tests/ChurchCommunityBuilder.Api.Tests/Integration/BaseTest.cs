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
    public class BaseTest {
        public ApiClient ApiClient;
        [OneTimeSetUp]
        public virtual void Setup() {
            ApiClient = new ApiClient("multisite", "focusmissions", "Psalms46:10");
        }
    }
}
