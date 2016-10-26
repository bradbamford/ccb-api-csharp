using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.People.Entity;
using ChurchCommunityBuilder.Api.People.QueryObject;
using ChurchCommunityBuilder.Api.Entity;

namespace ChurchCommunityBuilder.Api.People.Sets {
    public class Individuals : BaseApiSet<IndividualCollection> {
        public Individuals(string baseUrl, string username, string password) : base(baseUrl, username, password) {}

        public IndividualCollection Search(IndividualQO qo) {
            return this.Execute("individual_search", qo);
        }

        public Individual Get(int id, bool includeInactive) {
            var qo = new IndividualQO();
            qo.IndividualID = id;
            qo.IncludeInactive = includeInactive;
            var individuals = this.Execute("individual_profile_from_id", qo);

            if (individuals != null && individuals.Individuals.Count > 0) {
                return individuals.Individuals[0];
            }

            return null;
        }

        public Individual Update(Individual entity) {
            if (entity.ID <= 0) {
                throw new Exception("An ID is required when updating an individual");
            }

            var parameters = new Dictionary<string, string>();
            parameters.Add("individual_id", entity.ID.ToString());
            var individuals = base.Update("update_individual", entity.GetFormValues(), parameters);

            if (individuals != null && individuals.Individuals.Count > 0) {
                return individuals.Individuals[0];
            }

            return null;
        }

        public Individual Create(Individual entity) {
            var individuals = base.Create("create_individual", entity.GetFormValues());

            if (individuals != null && individuals.Individuals.Count > 0) {
                return individuals.Individuals[0];
            }

            return null;
        }

        public int Login(string username, string password) {
            int returnID = 0;
            var parameters = new Dictionary<string, string>();
            parameters.Add("login", username);
            parameters.Add("password", password);

            var result = this.Execute<Response>("individual_id_from_login_password", parameters);

            if (result.Items.Count > 0) {
                returnID = result.Items[0].ID.Value;
            }

            return returnID;
        }
    }
}
