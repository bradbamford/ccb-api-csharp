using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Util;
using System.Globalization;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.Financial.Entity {
    [Serializable]
    public class OnlineGift {     
        [XmlElement("gift_id")]
        public int GiftID { get; set; }        
        public int AccountID { get; set; }
        public int? IndividualID { get; set; }
        [XmlElement("amount")]
        public decimal GiftAmount { get; set; }

        [XmlElement("merchant_transaction_id")]
        public string MerchantTransactionID { get; set; }
        [XmlElement("merchant_authorization_code")]
        public string MerchantAuthorizationCode { get; set; }
        [XmlElement("merchant_notes")]
        public string MerchantNotes { get; set; }
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
        [XmlElement("merchant_process_date")]
        public DateTime? MerchantProcessDate { get; set; }  
        [XmlElement("first_name")]      
        public string FirstName { get; set; }
        [XmlElement("last_name")]
        public string LastName { get; set; }
        [XmlElement("street_address")]
        public string StreetAddress { get; set; }
        [XmlElement("city")]
        public string City { get; set; }
        [XmlElement("state")]
        public string State { get; set; }
        [XmlElement("zip")]
        public string Zip { get; set; }
        [XmlElement("email")]
        public string Email { get; set; }
        [XmlElement("phone_number")]
        public string Phone { get; set; }
        [XmlElement("campus_id")]
        public int? CampusID { get; set; }
        [XmlElement("payment_method")]
        public string PaymentMethodType { get; set; }
        [XmlElement("confirmation_code")]
        public string ConfirmationCode { get; set; }

        public string GetFormValues() {
            var formValues = CreateFormValues();
            return formValues.ToString();
        }

        public Dictionary<string, string> GetFormDictionary() {
            var formValues = CreateFormValues();
            return formValues.ToDictionary();
        }

        public FormValuesBuilder CreateFormValues() {
            var formValues = new FormValuesBuilder();

            formValues.Add("coa_category_id", this.AccountID.ToString())
                      .Add("individual_id", this.IndividualID.ToString())
                      .Add("amount", this.GiftAmount.ToString("#.00", CultureInfo.InvariantCulture));

            if (!string.IsNullOrEmpty(this.MerchantTransactionID)) {
                formValues.Add("merchant_transaction_id", this.MerchantTransactionID);
            }

            if (!string.IsNullOrEmpty(this.MerchantAuthorizationCode)) {
                formValues.Add("merchant_authorization_code", this.MerchantAuthorizationCode);
            }

            if (!string.IsNullOrEmpty(this.MerchantName)) {
                formValues.Add("merchant_name", this.MerchantName);
            }

            if (!string.IsNullOrEmpty(this.MerchantNotes)) {
                formValues.Add("merchant_notes", this.MerchantNotes);
            }

            if (this.MerchantProcessDate.HasValue) {
                formValues.Add("merchant_process_date", this.MerchantProcessDate.Value.ToString("yyyy-MM-dd"));
            }

            if (!string.IsNullOrEmpty(this.FirstName)) {
                formValues.Add("first_name", this.FirstName);
            }
            if (!string.IsNullOrEmpty(this.LastName)) {
                formValues.Add("last_name", this.LastName);
            }
            if (!string.IsNullOrEmpty(this.StreetAddress)) {
                formValues.Add("stret_address", this.StreetAddress);
            }
            if (!string.IsNullOrEmpty(this.City)) {
                formValues.Add("city", this.City);
            }
            if (!string.IsNullOrEmpty(this.State)) {
                formValues.Add("state", this.State);
            }
            if (!string.IsNullOrEmpty(this.Zip)) {
                formValues.Add("zip", this.Zip);
            }
            if (!string.IsNullOrEmpty(this.Email)) {
                formValues.Add("email", this.Email);
            }
            if (!string.IsNullOrEmpty(this.Phone)) {
                formValues.Add("phone", this.Phone);
            }
            if (this.CampusID.HasValue) {
                formValues.Add("campus_id", this.CampusID.Value);
            }
            if (!string.IsNullOrEmpty(this.PaymentMethodType)) {
                formValues.Add("payment_method_type", this.PaymentMethodType);
            }

            return formValues;
        }
    }
}