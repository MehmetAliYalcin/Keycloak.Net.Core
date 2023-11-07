using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RealmAttribute
    {
        public string Name { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public string? Value { get; set; }

        public virtual Realm Realm { get; set; } = null!;
    }
}
