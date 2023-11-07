using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceServerResource
    {
        public ResourceServerResource()
        {
            ResourceAttributes = new HashSet<ResourceAttribute>();
            ResourceServerPermTickets = new HashSet<ResourceServerPermTicket>();
            ResourceUris = new HashSet<ResourceUri>();
            Policies = new HashSet<ResourceServerPolicy>();
            Scopes = new HashSet<ResourceServerScope>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
        public string? IconUri { get; set; }
        public string Owner { get; set; } = null!;
        public string ResourceServerId { get; set; } = null!;
        public bool OwnerManagedAccess { get; set; }
        public string? DisplayName { get; set; }

        public virtual ResourceServer ResourceServer { get; set; } = null!;
        public virtual ICollection<ResourceAttribute> ResourceAttributes { get; set; }
        public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; }
        public virtual ICollection<ResourceUri> ResourceUris { get; set; }

        public virtual ICollection<ResourceServerPolicy> Policies { get; set; }
        public virtual ICollection<ResourceServerScope> Scopes { get; set; }
    }
}
