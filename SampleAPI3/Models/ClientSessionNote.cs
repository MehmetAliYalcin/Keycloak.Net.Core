using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientSessionNote
    {
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public string ClientSession { get; set; } = null!;

        public virtual ClientSession ClientSessionNavigation { get; set; } = null!;
    }
}
