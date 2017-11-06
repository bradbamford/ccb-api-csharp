using System;
using System.Collections.Generic;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {

    public class MergedIndividuals : BaseApiSet<MergedIndividualCollection> {
        public MergedIndividuals(string baseUrl, string username, string password) : base(baseUrl, username, password) {}

        public MergedIndividualCollection List()
        {
            return this.Execute("merged_individuals");
        }

        public MergedIndividualCollection List(DateTime modifiedSince)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("modified_since", modifiedSince.ToString("yyyy-MM-dd"));
            return this.Execute("merged_individuals", parameters);
        }

    }
}
