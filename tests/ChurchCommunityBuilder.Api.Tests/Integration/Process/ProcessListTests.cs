using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Processes.Entity;
using ChurchCommunityBuilder.Api.Processes.QueryObject;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Process {
    [TestFixture]
    public class MembershipTypesListTests : BaseTest { 
        [Test]
        public void integration_processes_list_no_parameters() {
            var results = base.ApiClient.Processes.Processes.List();
            results.Processes.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_processes_list_modified_parameter() {
            var results = base.ApiClient.Processes.Processes.List(modifiedSince: DateTime.UtcNow.AddMonths(-3));
            results.Processes.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_processes_list_modified_qo() {
            var results = base.ApiClient.Processes.Processes.List(new ProcessQO { ModifiedSince = DateTime.UtcNow.AddMonths(-3) });
            results.Processes.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_processes_list_campus_parameter() {
            var results = base.ApiClient.Processes.Processes.List(campusID: 1);
            results.Processes.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void integration_processes_list_campus_qo() {
            var results = base.ApiClient.Processes.Processes.List(new ProcessQO { CampusID = 1 });
            results.Processes.Count.ShouldBeGreaterThan(0);
        }
    }
}
