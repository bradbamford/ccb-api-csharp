using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    [Serializable]
    [XmlRoot("participant")]
    public class GroupParticipant {
        public GroupParticipant()
        {
            this.Carrier = new Lookup();
            this.Creator = new Lookup();
            this.Status = new Lookup();
            this.Modifier = new Lookup();
        }
      
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        [XmlElement("carrier")]
        public Lookup Carrier { get; set; }

        [XmlElement("status")]
        public Lookup Status { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }


        [XmlIgnore]
        public DateTime? CreatedDate
        {
            get
            {
                var createdDate = DateTime.MinValue;

                if (DateTime.TryParse(_createdDateString, out createdDate))
                    return createdDate;

                return null;
            }
            set {
                _createdDateString = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        private string _createdDateString = string.Empty;
        [XmlElement("created")]
        public string Created
        {
            get
            {
                if (!string.IsNullOrEmpty(_createdDateString))
                {
                    var dt = DateTime.Now;

                    if (DateTime.TryParse(_createdDateString, out dt))
                    {
                        _createdDateString = dt.ToString("s");
                    }
                }

                return _createdDateString;
            }
            set
            {
                if (value != null)
                {
                    _createdDateString = value;
                }
            }
        }


        /*
         <name>Larry Cucumber</name>
            <email>test@test.com</email>
            <mobile_phone></mobile_phone>
            <carrier id="0"></carrier>
            <receive_email_from_church>true</receive_email_from_church>
            <receive_email_from_group>true</receive_email_from_group>
            <receive_sms_from_group>false</receive_sms_from_group>
            <status id="2">Member</status>
            <date_joined>2012-09-20 08:51:01</date_joined>
            <active>true</active>
            <creator id="1">Larry Cucumber</creator>
            <modifier id="1">Larry Cucumber</modifier>
            <created>2012-09-20 08:51:01</created>
            <modified>2012-09-25 15:46:15</modified>
             */
    }

}
