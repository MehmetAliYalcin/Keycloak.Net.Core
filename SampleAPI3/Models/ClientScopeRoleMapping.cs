using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientScopeRoleMapping
    {
        public string ScopeId { get; set; } = null!;
        public string RoleId { get; set; } = null!;

        public virtual ClientScope Scope { get; set; } = null!;
    }
}
