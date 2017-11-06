using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Attributes;

namespace ChurchCommunityBuilder.Api.Groups.QueryObject {
    public class GroupParticipantQO : ChurchCommunityBuilder.Api.QueryObject
    {
        [QO("id")]
        public int? ID { get; set; }

        [QO("modified_since")]
        public DateTime? ModifiedSince { get; set; }

        [QO("include_inactive")]
        public bool? IncludeInactive { get; set; }
    }
}