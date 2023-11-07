using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class AuthenticatorConfig
    {
        public string Id { get; set; } = null!;
        public string? Alias { get; set; }
        public string? RealmId { get; set; }

        public virtual Realm? Realm { get; set; }
    }
}
