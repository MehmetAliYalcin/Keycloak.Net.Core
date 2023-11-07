using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserFederationMapper
    {
        public UserFederationMapper()
        {
            UserFederationMapperConfigs = new HashSet<UserFederationMapperConfig>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string FederationProviderId { get; set; } = null!;
        public string FederationMapperType { get; set; } = null!;
        public string RealmId { get; set; } = null!;

        public virtual UserFederationProvider FederationProvider { get; set; } = null!;
        public virtual Realm Realm { get; set; } = null!;
        public virtual ICollection<UserFederationMapperConfig> UserFederationMapperConfigs { get; set; }
    }
}
