using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Groups.Entity {
    public class GroupParticipantCollection : Response {
        public GroupParticipantCollection() {
            this.Groups = new List<GroupParticipantGroup>();
        }


        [XmlArrayItem("group", typeof(GroupParticipantGroup))]
        [XmlArray("groups")]
        public List<GroupParticipantGroup> Groups { get; set; }

    }
}

/*
  <groups count="1">
      <group id="23" name="**Ninja Turtle Club**">
        <participants count="10">
          <participant id="1">
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
          </participant>
          â€¦
          <participant id="61">
            <name>Bob Tom</name>
            <email></email>
            <mobile_phone></mobile_phone>
            <carrier id="0"></carrier>
            <receive_email_from_church>true</receive_email_from_church>
            <receive_email_from_group>true</receive_email_from_group>
            <receive_sms_from_group>false</receive_sms_from_group>
            <status id="2">Member</status>
            <date_joined>2013-04-08 06:51:45</date_joined>
            <active>true</active>
            <creator id="1">Larry Cucumber</creator>
            <modifier id="1">Larry Cucumber</modifier>
            <created>2013-04-08 06:51:45</created>
            <modified>2013-04-08 06:51:45</modified>
          </participant>
        </participants>
      </group>
    </groups>
     */
