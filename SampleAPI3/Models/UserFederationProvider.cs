using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserFederationProvider
    {
        public UserFederationProvider()
        {
            UserFederationConfigs = new HashSet<UserFederationConfig>();
            UserFederationMappers = new HashSet<UserFederationMapper>();
        }

        public string Id { get; set; } = null!;
        public int? ChangedSyncPeriod { get; set; }
        public string? DisplayName { get; set; }
        public int? FullSyncPeriod { get; set; }
        public int? LastSync { get; set; }
        public int? Priority { get; set; }
        public string? ProviderName { get; set; }
        public string? RealmId { get; set; }

        public virtual Realm? Realm { get; set; }
        public virtual ICollection<UserFederationConfig> UserFederationConfigs { get; set; }
        public virtual ICollection<UserFederationMapper> UserFederationMappers { get; set; }
    }
}
