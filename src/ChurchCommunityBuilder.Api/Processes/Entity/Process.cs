using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.Processes.Entity {
    [Serializable]
    [XmlRoot("process")]
    public class Process {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("owner")]
        public Lookup Owner { get; set; }

        [XmlElement("hhidden")]
        public bool IsHidden { get; set; }

        [XmlArrayItem("manager", typeof(Lookup))]
        [XmlArray("managers")]
        public List<Lookup> Managers { get; set; }

        [XmlArrayItem("queue", typeof(Lookup))]
        [XmlArray("queues")]
        public List<Lookup> Queues { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime? Created { get; set; }

        private string _createdString = string.Empty;
        public string CreatedString {
            get { return _createdString; }
            set { _createdString = value; }
        }

        [XmlIgnore]
        public DateTime? ModifiedDate {
            get {
                DateTime value = DateTime.MinValue;

                if (DateTime.TryParse(this.ModifiedString, out value)) {
                    return value;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.ModifiedString = value.Value.ToString();
                }
            }
        }

        private string _modifiedString = string.Empty;
        [XmlElement("modified")]
        public string ModifiedString {
            get { return _modifiedString; }
            set { _modifiedString = value; }
        }
    }
}
