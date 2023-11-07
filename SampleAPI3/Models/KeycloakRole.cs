using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class KeycloakRole
    {
        public KeycloakRole()
        {
            RoleAttributes = new HashSet<RoleAttribute>();
            ChildRoles = new HashSet<KeycloakRole>();
            Composites = new HashSet<KeycloakRole>();
        }

        public string Id { get; set; } = null!;
        public string? ClientRealmConstraint { get; set; }
        public bool ClientRole { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? RealmId { get; set; }
        public string? Client { get; set; }
        public string? Realm { get; set; }

        public virtual Realm? RealmNavigation { get; set; }
        public virtual ICollection<RoleAttribute> RoleAttributes { get; set; }

        public virtual ICollection<KeycloakRole> ChildRoles { get; set; }
        public virtual ICollection<KeycloakRole> Composites { get; set; }
    }
}
