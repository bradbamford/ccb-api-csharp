/*######### NOTE: reason for DateMergedString ############
CCB is known to sometimes return the following:
   <date_merged>0000-00-00 00:00:00</date_merged>
A valid mySQL date but not in .NET; outright fails serialization.
####################################################### */

using System;
using System.Xml;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity
{
    [XmlRoot("merged_individual")]
    public class MergedIndividual
    {

        public MergedIndividual()
        {
            this.Creator = new Lookup();
            this.Modifier = new Lookup();
        }


        [XmlElement("winner_id")]
        public int WinnerID { get; set; }

        [XmlElement("loser_id")]
        public int LoserID { get; set; }

        private DateTime? _dateMerged;

        [XmlIgnore]
        public DateTime? DateMerged
        {
            get { return _dateMerged; }
            set { _dateMerged = value; }
        }

        [XmlElement("date_merged")]
        public string DateMergedString
        {
            get
            {
                return _dateMerged.HasValue ? XmlConvert.ToString(_dateMerged.Value, XmlDateTimeSerializationMode.Unspecified): string.Empty;
            }
            set
            {
                _dateMerged = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.Unspecified): (DateTime?)null;
            }
        }

        [XmlElement("creator")]
        public Lookup Creator { get; set; }

        [XmlElement("modifier")]
        public Lookup Modifier { get; set; }

        [XmlElement("created")]
        public DateTime? Created { get; set; }

        [XmlElement("modified")]
        public DateTime? Modified { get; set; }

    }
}
