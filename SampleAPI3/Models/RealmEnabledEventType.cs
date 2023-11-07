using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RealmEnabledEventType
    {
        public string RealmId { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual Realm Realm { get; set; } = null!;
    }
}
