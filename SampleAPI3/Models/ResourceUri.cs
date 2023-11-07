using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceUri
    {
        public string ResourceId { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual ResourceServerResource Resource { get; set; } = null!;
    }
}
