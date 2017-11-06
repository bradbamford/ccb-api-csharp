using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchCommunityBuilder.Api.Realms {
    public class PeopleRealm : BaseRealm {
        public PeopleRealm(string churchCode, string username, string password)
            : base(churchCode, username, password) {

        }

        private ChurchCommunityBuilder.Api.People.Sets.Individuals _individualSet;
        private ChurchCommunityBuilder.Api.People.Sets.Families _familySet;
        private ChurchCommunityBuilder.Api.People.Sets.MembershipTypes _membershipTypesSet;
        private ChurchCommunityBuilder.Api.People.Sets.Campuses _campusesSet;
        private ChurchCommunityBuilder.Api.People.Sets.HowTheyHeardSet _howTheyHeardSet;
        private ChurchCommunityBuilder.Api.People.Sets.Abilities _abilitySet;
        private ChurchCommunityBuilder.Api.People.Sets.MobileCarriers _mobileCarrierSet;
        private ChurchCommunityBuilder.Api.People.Sets.UserDefinedFields _userDefinedFieldSet;
        private ChurchCommunityBuilder.Api.People.Sets.CustomFields _customFields;
        private ChurchCommunityBuilder.Api.People.Sets.MergedIndividuals _mergedIndividualSet;

        #region Sets
        public ChurchCommunityBuilder.Api.People.Sets.Individuals Individuals {
            get {
                if (_individualSet == null) {
                    _individualSet = new People.Sets.Individuals(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _individualSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Families Families {
            get {
                if (_familySet == null) {
                    _familySet = new People.Sets.Families(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _familySet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.MembershipTypes MembershipTypes {
            get {
                if (_membershipTypesSet == null) {
                    _membershipTypesSet = new People.Sets.MembershipTypes(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _membershipTypesSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Campuses Campuses {
            get {
                if (_campusesSet == null) {
                    _campusesSet = new People.Sets.Campuses(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _campusesSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.HowTheyHeardSet HowTheyHeard {
            get {
                if (_howTheyHeardSet == null) {
                    _howTheyHeardSet = new People.Sets.HowTheyHeardSet(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _howTheyHeardSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.Abilities Abilities {
            get {
                if (_abilitySet == null) {
                    _abilitySet = new People.Sets.Abilities(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _abilitySet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.MobileCarriers MobileCarriers {
            get {
                if (_mobileCarrierSet == null) {
                    _mobileCarrierSet = new People.Sets.MobileCarriers(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _mobileCarrierSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.UserDefinedFields UserDefinedFields {
            get {
                if (_userDefinedFieldSet == null) {
                    _userDefinedFieldSet = new People.Sets.UserDefinedFields(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _userDefinedFieldSet;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.CustomFields CustomFields {
            get {
                if (_customFields == null) {
                    _customFields = new People.Sets.CustomFields(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _customFields;
            }
        }

        public ChurchCommunityBuilder.Api.People.Sets.MergedIndividuals MergedIndividuals
        {
            get
            {
                if (_mergedIndividualSet == null)
                {
                    _mergedIndividualSet = new People.Sets.MergedIndividuals(string.Format(API_URL, base.ChurchCode), base.UserName, base.Password);
                }

                return _mergedIndividualSet;
            }
        }

        #endregion Sets
    }
}
