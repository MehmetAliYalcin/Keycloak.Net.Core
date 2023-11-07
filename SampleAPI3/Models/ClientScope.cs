using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientScope
    {
        public ClientScope()
        {
            ClientScopeAttributes = new HashSet<ClientScopeAttribute>();
            ClientScopeRoleMappings = new HashSet<ClientScopeRoleMapping>();
            ProtocolMappers = new HashSet<ProtocolMapper>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? RealmId { get; set; }
        public string? Description { get; set; }
        public string? Protocol { get; set; }

        public virtual ICollection<ClientScopeAttribute> ClientScopeAttributes { get; set; }
        public virtual ICollection<ClientScopeRoleMapping> ClientScopeRoleMappings { get; set; }
        public virtual ICollection<ProtocolMapper> ProtocolMappers { get; set; }
    }
}
