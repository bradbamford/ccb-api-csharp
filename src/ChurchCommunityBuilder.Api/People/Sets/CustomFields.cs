using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class CustomFields : BaseApiSet<CustomFieldCollection> {
        public CustomFields(string baseUrl, string username, string password) : base(baseUrl, username, password) { }

        public CustomFieldCollection List() {
            return this.Execute("custom_field_labels");
        }
    }
}


