using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RealmRequiredCredential
    {
        public string Type { get; set; } = null!;
        public string? FormLabel { get; set; }
        public bool Input { get; set; }
        public bool Secret { get; set; }
        public string RealmId { get; set; } = null!;

        public virtual Realm Realm { get; set; } = null!;
    }
}
