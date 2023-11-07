using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserFederationConfig
    {
        public string UserFederationProviderId { get; set; } = null!;
        public string? Value { get; set; }
        public string Name { get; set; } = null!;

        public virtual UserFederationProvider UserFederationProvider { get; set; } = null!;
    }
}
