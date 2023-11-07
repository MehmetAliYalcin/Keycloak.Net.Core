using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class FedUserAttribute
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public string? StorageProviderId { get; set; }
        public string? Value { get; set; }
    }
}
