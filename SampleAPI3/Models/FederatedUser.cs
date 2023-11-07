using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class FederatedUser
    {
        public string Id { get; set; } = null!;
        public string? StorageProviderId { get; set; }
        public string RealmId { get; set; } = null!;
    }
}
