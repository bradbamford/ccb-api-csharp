using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class UserDefinedFieldCollection : Response {
        public UserDefinedFieldCollection() {
            this.Items = new List<UserDefinedField>();
        }

        [XmlArrayItem("item", typeof(UserDefinedField))]
        [XmlArray("iteams")]
        new public List<UserDefinedField> Items { get; set; }
    }
}
