using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class IdentityProvider
    {
        public IdentityProvider()
        {
            IdentityProviderConfigs = new HashSet<IdentityProviderConfig>();
        }

        public string InternalId { get; set; } = null!;
        public bool Enabled { get; set; }
        public string? ProviderAlias { get; set; }
        public string? ProviderId { get; set; }
        public bool StoreToken { get; set; }
        public bool AuthenticateByDefault { get; set; }
        public string? RealmId { get; set; }
        public bool? AddTokenRole { get; set; }
        public bool TrustEmail { get; set; }
        public string? FirstBrokerLoginFlowId { get; set; }
        public string? PostBrokerLoginFlowId { get; set; }
        public string? ProviderDisplayName { get; set; }
        public bool LinkOnly { get; set; }

        public virtual Realm? Realm { get; set; }
        public virtual ICollection<IdentityProviderConfig> IdentityProviderConfigs { get; set; }
    }
}
