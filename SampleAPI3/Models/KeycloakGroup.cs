using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class KeycloakGroup
    {
        public KeycloakGroup()
        {
            GroupAttributes = new HashSet<GroupAttribute>();
            GroupRoleMappings = new HashSet<GroupRoleMapping>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string ParentGroup { get; set; } = null!;
        public string? RealmId { get; set; }

        public virtual ICollection<GroupAttribute> GroupAttributes { get; set; }
        public virtual ICollection<GroupRoleMapping> GroupRoleMappings { get; set; }
    }
}
