using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ComponentConfig
    {
        public string Id { get; set; } = null!;
        public string ComponentId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual Component Component { get; set; } = null!;
    }
}
