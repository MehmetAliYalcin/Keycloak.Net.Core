using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RealmDefaultGroup
    {
        public string RealmId { get; set; } = null!;
        public string GroupId { get; set; } = null!;

        public virtual Realm Realm { get; set; } = null!;
    }
}
