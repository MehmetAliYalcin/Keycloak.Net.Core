using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientInitialAccess
    {
        public string Id { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public int? Timestamp { get; set; }
        public int? Expiration { get; set; }
        public int? Count { get; set; }
        public int? RemainingCount { get; set; }

        public virtual Realm Realm { get; set; } = null!;
    }
}
