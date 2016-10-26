using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    public class CustomFieldCollection : Response {
        public CustomFieldCollection() {
            this.CustomFields = new List<CustomField>();
        }

        [XmlArrayItem("custom_field", typeof(CustomField))]
        [XmlArray("custom_fields")]
        public List<CustomField> CustomFields { get; set; }
    }
}
