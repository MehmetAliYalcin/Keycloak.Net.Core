using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserConsent
    {
        public UserConsent()
        {
            UserConsentClientScopes = new HashSet<UserConsentClientScope>();
        }

        public string Id { get; set; } = null!;
        public string? ClientId { get; set; }
        public string UserId { get; set; } = null!;
        public long? CreatedDate { get; set; }
        public long? LastUpdatedDate { get; set; }
        public string? ClientStorageProvider { get; set; }
        public string? ExternalClientId { get; set; }

        public virtual UserEntity User { get; set; } = null!;
        public virtual ICollection<UserConsentClientScope> UserConsentClientScopes { get; set; }
    }
}
