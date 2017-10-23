using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.People.QueryObject {
    public class IndividualQO : ChurchCommunityBuilder.Api.QueryObject {
        [QO("individual_id")]
        public int? IndividualID { get; set; }

        [QO("first_name")]
        public string FirstName { get; set; }

        [QO("last_name")]
        public string LastName { get; set; }

        [QO("phone")]
        public string Phone { get; set; }

        [QO("email")]
        public string Email { get; set; }

        [QO("street_address")]
        public string StreetAddress { get; set; }

        [QO("city")]
        public string City { get; set; }

        [QO("state")]
        public string State { get; set; }

        [QO("zip")]
        public string ZipCode { get; set; }

        [QO("include_inactive")]
        public bool? IncludeInactive { get; set; }

        [QO("max_results")]
        public int? MaxResults { get; set; }

        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }


    }
}
