using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserSessionNote
    {
        public string UserSession { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual UserSession UserSessionNavigation { get; set; } = null!;
    }
}
