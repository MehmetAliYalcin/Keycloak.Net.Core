using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class IdentityProviderMapper
    {
        public IdentityProviderMapper()
        {
            IdpMapperConfigs = new HashSet<IdpMapperConfig>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string IdpAlias { get; set; } = null!;
        public string IdpMapperName { get; set; } = null!;
        public string RealmId { get; set; } = null!;

        public virtual Realm Realm { get; set; } = null!;
        public virtual ICollection<IdpMapperConfig> IdpMapperConfigs { get; set; }
    }
}
