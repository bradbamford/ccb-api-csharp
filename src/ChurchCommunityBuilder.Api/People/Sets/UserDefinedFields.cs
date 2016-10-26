using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class UserDefinedFields : BaseApiSet<UserDefinedFieldCollection> {
        public UserDefinedFields(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public UserDefinedFieldCollection ListGroup1() {
            return this.Execute("udf_grp_pulldown_1_list");
        }

        public UserDefinedFieldCollection ListIndividual(string label) {
            return this.Execute(label + "_list");
        }
    }
}
