using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceAttribute
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public string ResourceId { get; set; } = null!;

        public virtual ResourceServerResource Resource { get; set; } = null!;
    }
}
