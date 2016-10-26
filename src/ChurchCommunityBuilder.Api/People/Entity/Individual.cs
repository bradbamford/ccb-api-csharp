using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;
using ChurchCommunityBuilder.Api.People.Enum;
using System.Web;
using ChurchCommunityBuilder.Api.Util;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot("individual")]
    public class Individual {
        public Individual() {
            this.Campus = new Lookup();
            this.Family = new Lookup();
            this.FamilyMembers = new List<FamilyMember>();
            this.Addresses = new List<Address>();
            this.Phones = new List<Phone>();
            this.MembershipType = new Lookup();
            this.UserDefinedDateFields = new List<UserDefinedDateField>();
            this.UserDefinedPulldownFields = new List<UserDefinedPulldownField>();
            this.UserDefinedTextFields = new List<UserDefiniedTextField>();
        }
        [XmlAttribute("id")]
        public int? ID { get; set; }

        [XmlElement("sync_id")]
        public string SyncID { get; set; }

        [XmlElement("other_id")]
        public string OtherID { get; set; }

        [XmlElement("giving_number")]
        public string GivingNumber { get; set; }

        [XmlElement("campus")]
        public Lookup Campus { get; set; }

        [XmlElement("family")]
        public Lookup Family { get; set; }

        [XmlElement("family_image")]
        public string FamilyImage { get; set; }

        [XmlIgnore]
        public FamilyPosition? FamilyPosition {
            get {
                if (!string.IsNullOrEmpty(this.FamilyPositionString)) {
                    switch (this.FamilyPositionString.ToLower()) {
                        case "primary contact":
                            return Enum.FamilyPosition.PrimaryContact;
                        case "head of household":
                            return Enum.FamilyPosition.HeadOfHousehold;
                        case "spouse":
                            return Enum.FamilyPosition.Spouse;
                        case "child":
                            return Enum.FamilyPosition.Child;
                        case "other":
                            return Enum.FamilyPosition.Other;
                            
                    }
                }
                return null;
            }
            set {
                switch (value) {
                    case Enum.FamilyPosition.PrimaryContact:
                        this.FamilyPositionString = "Primary Contact";
                        break;
                    case Enum.FamilyPosition.HeadOfHousehold:
                        this.FamilyPositionString = "Head of Household";
                        break;
                    case Enum.FamilyPosition.Spouse:
                        this.FamilyPositionString = "Spouse";
                        break;
                    case Enum.FamilyPosition.Child:
                        this.FamilyPositionString = "Child";
                        break;
                    case Enum.FamilyPosition.Other:
                        this.FamilyPositionString = "Other";
                        break;

                }
            }
        }

        [XmlElement("family_position")]
        public string FamilyPositionString { get; set; }

        [XmlElement("family_member")]
        public List<FamilyMember> FamilyMembers { get; set; }

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("middle_name")]
        public string MiddleName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("legal_first_name")]
        public string LegalFirstName { get; set; }

        [XmlElement("full_name")]
        public string FullName { get; set; }

        [XmlElement("salutation")]
        public string Salutation { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }

        [XmlElement("image")]
        public string Image { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("allergies")]
        public string Allergies { get; set; }

        [XmlElement("addresses")]
        public List<Address> Addresses { get; set; }

        [XmlArrayItem("phone", typeof(Phone))]
        [XmlArray("phones")]
        public List<Phone> Phones { get; set; }

        [XmlElement("gender")]
        public string Gender { get; set; }

        [XmlElement("marital_status")]
        public string MaritalStatus { get; set; }

        [XmlElement("birthday")]
        public DateTime? Birthday { get; set; }

        [XmlElement("anniversary")]
        public DateTime? Anniversary { get; set; }

        [XmlElement("deceased")]
        public DateTime? Deceased { get; set; }

        [XmlElement("membership_date")]
        public DateTime? MembershipDate { get; set; }

        [XmlElement("membership_end")]
        public DateTime? MembershipEnd { get; set; }

        [XmlElement("membership_type")]
        public Lookup MembershipType { get; set; }

        [XmlArrayItem("user_defined_text_field", typeof(UserDefiniedTextField))]
        [XmlArray("user_defined_text_fields")]
        public List<UserDefiniedTextField> UserDefinedTextFields { get; set; }

        [XmlArrayItem("user_defined_date_field", typeof(UserDefinedDateField))]
        [XmlArray("user_defined_date_fields")]
        public List<UserDefinedDateField> UserDefinedDateFields { get; set; }

        [XmlArrayItem("user_defined_pulldown_field", typeof(UserDefinedPulldownField))]
        [XmlArray("user_defined_pulldown_fields")]
        public List<UserDefinedPulldownField> UserDefinedPulldownFields { get; set; }

        public string GetFormValues() {
            var formValues = new FormValuesBuilder();

            if (!string.IsNullOrEmpty(this.FirstName)) {
                formValues.Add("first_name", this.FirstName);
            }

            if (!string.IsNullOrEmpty(this.LastName)) {
                formValues.Add("last_name", this.LastName);
            }

            formValues.Add("middle_name", this.MiddleName)
                .Add("legal_first_name", this.LegalFirstName)
                .Add("sync_id", this.SyncID)
                .Add("other_id", this.OtherID)
                .Add("salutation", this.Salutation)
                .Add("suffix", this.Suffix);

            if (Campus != null && Campus.ID > 0) {
                formValues.Add("campus_id", this.Campus.ID.ToString());
            }

            if (this.Family != null && this.Family.ID > 0) {
                formValues.Add("family_id", this.Family.ID);
            }

            if (!string.IsNullOrEmpty(this.FamilyPositionString)) {
                if (this.FamilyPositionString.ToLower() == "head of household" || this.FamilyPositionString.ToLower() == "primary contact") {
                    formValues.Add("family_position", "h");
                }
                else if (this.FamilyPositionString.ToLower() == "spouse") {
                    formValues.Add("family_position", "s");
                }
                else if (this.FamilyPositionString.ToLower() == "other") {
                    formValues.Add("family_position", "o");
                }
                else if (this.FamilyPositionString.ToLower() == "child") {
                    formValues.Add("family_position", "c");
                }
            }

            formValues.Add("gender", this.Gender)
                .Add("birthday", this.Birthday.HasValue ? this.Birthday.Value.ToString("yyyy-MM-dd") : "")
                .Add("anniversary", this.Anniversary.HasValue ? this.Anniversary.Value.ToString("yyyy-MM-dd") : "")
                .Add("deceased", this.Deceased.HasValue ? this.Deceased.Value.ToString("yyyy-MM-dd") : "")
                .Add("membership_date", this.MembershipDate.HasValue ? this.MembershipDate.Value.ToString("yyyy-MM-dd") : "")
                .Add("membership_end", this.MembershipEnd.HasValue ? this.MembershipEnd.Value.ToString("yyyy-MM-dd") : "")
                .Add("membership_type_id", this.MembershipType != null && this.MembershipType.ID > 0 ? this.MembershipType.ID.ToString() : "")
                .Add("giving_number", this.GivingNumber)
                .Add("allergies", this.Allergies)
                .Add("marital_status", this.MaritalStatus);

            if (!string.IsNullOrEmpty(Email) && Email.Contains('@') && Email.Contains('.')) {
                formValues.Add("email", this.Email);
            }
            else {
                formValues.Add("email", string.Empty);
            }

            if (this.Addresses != null && this.Addresses.Count > 0) {
                foreach (var current in Addresses) {
                    var addressType = current.Type;
                    var addressLine = current.Line1;

                    if (!string.IsNullOrEmpty(current.Line2) && !current.Line2.StartsWith(current.City)) {
                        addressLine += " " + current.Line2;
                    }

                    formValues.Add(string.Format("{0}_street_address", current.Type), addressLine);
                    formValues.Add(string.Format("{0}_city", current.Type), current.City);
                    if (!string.IsNullOrEmpty(current.State)) {
                        formValues.Add(string.Format("{0}_state", current.Type), current.State.ToUpper());
                    }
                    formValues.Add(string.Format("{0}_zip", current.Type), current.Zip);

                    if (current.Country != null) {
                        formValues.Add(string.Format("{0}_country", current.Type), current.Country.Code.ToUpper());
                    }
                }
            }

            if (this.Phones != null && this.Phones.Count > 0) {
                foreach (var current in this.Phones) {
                    formValues.Add(string.Format("{0}_phone", current.Type), current.Value);
                }
            }

            if (this.UserDefinedTextFields != null && this.UserDefinedTextFields.Count > 0) {
                foreach (var field in this.UserDefinedTextFields) {
                    formValues.Add(field.Name, field.Text);
                }
            }

            if (this.UserDefinedDateFields != null && this.UserDefinedDateFields.Count > 0) {
                foreach(var field in this.UserDefinedDateFields) {
                    if (field.Date.HasValue) {
                        formValues.Add(field.Name, field.Date.Value.ToString("yyyy-MM-dd"));
                    }
                    else {
                        formValues.Add(field.Name, "");
                    }
                }
            }

            if (this.UserDefinedPulldownFields != null && this.UserDefinedPulldownFields.Count > 0) {
                foreach (var field in this.UserDefinedPulldownFields) {
                    formValues.Add(field.Name, field.Selection.ID.ToString());
                }
            }

            return formValues.ToString();
        }
    }
}
