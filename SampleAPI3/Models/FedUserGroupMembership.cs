using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class FedUserGroupMembership
    {
        public string GroupId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public string? StorageProviderId { get; set; }
    }
}
