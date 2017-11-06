using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Events.Entity;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Util;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    [Serializable]
    [XmlRoot("group")]
    public class GroupParticipantGroup
    {
        public GroupParticipantGroup() {
            this.Participants = new List<GroupParticipant>();
        }
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        
        [XmlArrayItem("participants", typeof(GroupParticipant))]
        [XmlArray("participant")]
        public List<GroupParticipant> Participants { get; set; }
     
    }
}
