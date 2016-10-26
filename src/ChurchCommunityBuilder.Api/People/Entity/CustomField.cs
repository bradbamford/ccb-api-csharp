using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [Serializable]
    [XmlRoot("custom_field")]
    public class CustomField {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("label")]
        public string Label { get; set; }

        [XmlElement("admin_only")]
        public bool AdminOnly { get; set; }
    }
}
