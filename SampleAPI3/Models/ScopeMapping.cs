using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ScopeMapping
    {
        public string ClientId { get; set; } = null!;
        public string RoleId { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;
    }
}
