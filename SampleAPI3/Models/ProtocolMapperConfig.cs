using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ProtocolMapperConfig
    {
        public string ProtocolMapperId { get; set; } = null!;
        public string? Value { get; set; }
        public string Name { get; set; } = null!;

        public virtual ProtocolMapper ProtocolMapper { get; set; } = null!;
    }
}
