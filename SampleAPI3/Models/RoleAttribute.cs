using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RoleAttribute
    {
        public string Id { get; set; } = null!;
        public string RoleId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }

        public virtual KeycloakRole Role { get; set; } = null!;
    }
}
