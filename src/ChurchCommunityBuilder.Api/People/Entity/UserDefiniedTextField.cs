using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [Serializable]
    [XmlRoot("user_defined_text_field")]
    public class UserDefiniedTextField {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("label")]
        public string Label { get; set; }
        [XmlElement("text")]
        public string Text { get; set; }
        [XmlElement("admin_only")]
        public bool AdminOnly { get; set; }
    }
}
