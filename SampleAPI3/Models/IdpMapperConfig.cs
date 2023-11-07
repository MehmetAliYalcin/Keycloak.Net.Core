using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class IdpMapperConfig
    {
        public string IdpMapperId { get; set; } = null!;
        public string? Value { get; set; }
        public string Name { get; set; } = null!;

        public virtual IdentityProviderMapper IdpMapper { get; set; } = null!;
    }
}
