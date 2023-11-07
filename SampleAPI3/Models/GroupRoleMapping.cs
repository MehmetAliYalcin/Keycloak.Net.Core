using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class GroupRoleMapping
    {
        public string RoleId { get; set; } = null!;
        public string GroupId { get; set; } = null!;

        public virtual KeycloakGroup Group { get; set; } = null!;
    }
}
