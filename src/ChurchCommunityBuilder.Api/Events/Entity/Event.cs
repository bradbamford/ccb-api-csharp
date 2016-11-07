using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.Entity;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.Util;

namespace ChurchCommunityBuilder.Api.Events.Entity {
    [Serializable]
    [XmlRoot("event")]
    public class Event {
        public Event() {
            this.Exceptions = new List<Exception>();
            this.ApprovalStatus = new Lookup();
            this.Group = new Lookup();
            this.Organizer = new Lookup();
            this.Phone = new Phone();
            this.Location = new Location();
            this.Registration = new Registration();
            this.GuestList = new List<Guest>();
            this.Setup = new Setup();
            this.EventGrouping = new Lookup();
            this.Creator = new Lookup();
            this.Modifier = new Lookup();
        }

        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("leader_notes")]
        public string LeaderNotes { get; set; }

        [XmlElement("start_datetime")]
        public DateTime? StartDateTime { get; set; }

        [XmlElement("end_datetime")]
        public DateTime? EndDateTime { get; set; }

        [XmlElement("timezone")]
        public string TimeZone { get; set; }

        [XmlElement("recurrence_description")]
        public string RecurrenceDescription { get; set; }

        [XmlArrayItem("exceptions", typeof(Exception))]
        [XmlArray("exception")]
        public List<Exception> Exceptions { get; set; }

        [XmlElement("approval_status")]
        public Lookup ApprovalStatus { get; set; }

        [XmlElement("group")]
        public Lookup Group { get; set; }

        [XmlElement("organizer")]
        public Lookup Organizer { get; set; }

        [XmlElement("phone")]
        public Phone Phone { get; set; }

        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("registration")]
        public Registration Registration { get; set; }

        [XmlArrayItem("guest_list", typeof(Guest))]
        [XmlArray("guest")]
        public List<Guest> GuestList { get; set; }

        //TODO :: understand resources
        // Resources are not returned, maybe reach out to CCB

        [XmlElement("setup")]
        public Setup Setup { get; set; }

        [XmlElement("event_grouping")]
        public Lookup EventGrouping { get; set; }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }
        
        [XmlElement("listed")]
        public bool Listed { get; set; }

        [XmlElement("public_calendar_listed")]
        public bool PublicCalendarListed { get; set; }
        
        [XmlElement("created")]
        public DateTime Created { get; set; }

        [XmlElement("modified")]
        public DateTime Modified { get; set; }

        public string GetFormValues() {
            var formValues = new FormValuesBuilder();

            if (!string.IsNullOrEmpty(this.Name)) {
                formValues.Add("name", this.Name.Length > 50 ? this.Name.Substring(0, 50) : this.Name);
            }
            formValues.Add("group_id", this.Group.CCBID.ToString())
                      .Add("start_date", this.StartDateTime.HasValue ? this.StartDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "")
                      .Add("end_date", this.EndDateTime.HasValue ? this.EndDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "")
                      .Add("description", this.Description)
                      .Add("leader_notes", this.LeaderNotes)
                      .Add("setup_notes", this.Setup.Notes);

            if (this.Organizer.CCBID.HasValue) {
                formValues.Add("organizer_id", this.Organizer.CCBID.ToString());
            }

            if (!string.IsNullOrEmpty(this.Phone.Value)) {
                formValues.Add("contact_phone", this.Phone.Value);
            }

            if (!string.IsNullOrEmpty(this.Location.Name)){
                formValues.Add("location_name", this.Location.Name);
            }

            if (!string.IsNullOrEmpty(this.Location.Line1)) {
                formValues.Add("location_street_address", this.Location.Line1);
            }

            if (!string.IsNullOrEmpty(this.Location.City)) {
                formValues.Add("location_city", this.Location.City);
            }

            if (!string.IsNullOrEmpty(this.Location.State)) {
                formValues.Add("location_state", this.Location.State);
            }

            if (!string.IsNullOrEmpty(this.Location.Zip)) {
                formValues.Add("location_zip", this.Location.Zip);
            }
            
            return formValues.ToString();
        }
    }
}
