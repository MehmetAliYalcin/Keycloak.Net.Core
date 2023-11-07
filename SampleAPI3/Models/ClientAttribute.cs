using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientAttribute
    {
        public string ClientId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
