using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class BrokerLink
    {
        public string IdentityProvider { get; set; } = null!;
        public string? StorageProviderId { get; set; }
        public string RealmId { get; set; } = null!;
        public string? BrokerUserId { get; set; }
        public string? BrokerUsername { get; set; }
        public string? Token { get; set; }
        public string UserId { get; set; } = null!;
    }
}
