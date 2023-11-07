using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class FederatedIdentity
    {
        public string IdentityProvider { get; set; } = null!;
        public string? RealmId { get; set; }
        public string? FederatedUserId { get; set; }
        public string? FederatedUsername { get; set; }
        public string? Token { get; set; }
        public string UserId { get; set; } = null!;

        public virtual UserEntity User { get; set; } = null!;
    }
}
