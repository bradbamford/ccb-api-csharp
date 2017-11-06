using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Groups.QueryObject;
using ChurchCommunityBuilder.Api.Groups.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Sets {
    public class GroupParticipants : BaseApiSet<GroupParticipantCollection> {
        public GroupParticipants(string baseUrl, string username, string password) : base(baseUrl, username, password) { }
        
        public GroupParticipantCollection List(GroupParticipantQO qo) {
            return this.Execute("group_participants", qo);
        }

        public GroupParticipantCollection Get(int id, bool includeInactive = false, DateTime? startDate = null)
        {
            var parameters = new Dictionary<string, string>
            {
                {"id", id.ToString()},
               // {"include_inactive",  includeInactive ? "1" : "0"},
               // {"modified_since",  startDate == null ? DateTime.MinValue.ToString("yyyy-MM-dd")  : startDate.Value.ToString("yyyy-MM-dd")}
            };
            return this.Execute<GroupParticipantCollection>("group_participants", parameters);
        }

    }
}
