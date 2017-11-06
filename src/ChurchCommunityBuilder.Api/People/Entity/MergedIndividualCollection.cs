using System.Collections.Generic;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity
{

    public class MergedIndividualCollection : Response
    {

        public MergedIndividualCollection()
        {
            this.MergedIndividuals = new List<MergedIndividual>();
        }


        [XmlArrayItem("merged_individual", typeof(MergedIndividual))]
        [XmlArray("merged_individuals")]
        public List<MergedIndividual> MergedIndividuals { get; set; }

    }
}