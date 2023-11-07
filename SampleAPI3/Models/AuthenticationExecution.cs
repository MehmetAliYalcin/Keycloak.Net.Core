using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class AuthenticationExecution
    {
        public string Id { get; set; } = null!;
        public string? Alias { get; set; }
        public string? Authenticator { get; set; }
        public string? RealmId { get; set; }
        public string? FlowId { get; set; }
        public int? Requirement { get; set; }
        public int? Priority { get; set; }
        public bool AuthenticatorFlow { get; set; }
        public string? AuthFlowId { get; set; }
        public string? AuthConfig { get; set; }

        public virtual AuthenticationFlow? Flow { get; set; }
        public virtual Realm? Realm { get; set; }
    }
}
