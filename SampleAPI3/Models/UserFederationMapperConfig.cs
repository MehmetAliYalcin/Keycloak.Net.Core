using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserFederationMapperConfig
    {
        public string UserFederationMapperId { get; set; } = null!;
        public string? Value { get; set; }
        public string Name { get; set; } = null!;

        public virtual UserFederationMapper UserFederationMapper { get; set; } = null!;
    }
}
