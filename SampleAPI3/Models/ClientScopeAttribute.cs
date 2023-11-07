using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientScopeAttribute
    {
        public string ScopeId { get; set; } = null!;
        public string? Value { get; set; }
        public string Name { get; set; } = null!;

        public virtual ClientScope Scope { get; set; } = null!;
    }
}
