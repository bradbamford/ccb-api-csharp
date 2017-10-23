using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    [XmlRoot("queue")]
    public class Queue {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("manager")]
        public Lookup Manager { get; set; }

        [XmlElement("status")]
        public Lookup Status { get; set; }

        [XmlElement("entered")]
        public DateTime? Entered { get; set; }

        [XmlElement("entered")]
        public DateTime? Due { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime? Created { get; set; }

        [XmlElement("completed")]
        public DateTime? Completed { get; set; }
    }
}
