using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [Serializable]
    [XmlRoot("user_defined_date_field")]
    public class UserDefinedDateField {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("label")]
        public string Label { get; set; }
        [XmlElement("date")]
        public DateTime? Date { get; set; }
        [XmlElement("admin_only")]
        public bool AdminOnly { get; set; }
    }
}
