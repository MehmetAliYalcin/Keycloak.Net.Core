using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class PolicyConfig
    {
        public string PolicyId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual ResourceServerPolicy Policy { get; set; } = null!;
    }
}
