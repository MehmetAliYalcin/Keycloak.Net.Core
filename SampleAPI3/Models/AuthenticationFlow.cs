using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class AuthenticationFlow
    {
        public AuthenticationFlow()
        {
            AuthenticationExecutions = new HashSet<AuthenticationExecution>();
        }

        public string Id { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Description { get; set; }
        public string? RealmId { get; set; }
        public string ProviderId { get; set; } = null!;
        public bool TopLevel { get; set; }
        public bool BuiltIn { get; set; }

        public virtual Realm? Realm { get; set; }
        public virtual ICollection<AuthenticationExecution> AuthenticationExecutions { get; set; }
    }
}
