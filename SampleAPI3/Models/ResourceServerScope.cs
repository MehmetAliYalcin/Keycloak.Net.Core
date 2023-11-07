using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceServerScope
    {
        public ResourceServerScope()
        {
            ResourceServerPermTickets = new HashSet<ResourceServerPermTicket>();
            Policies = new HashSet<ResourceServerPolicy>();
            Resources = new HashSet<ResourceServerResource>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? IconUri { get; set; }
        public string ResourceServerId { get; set; } = null!;
        public string? DisplayName { get; set; }

        public virtual ResourceServer ResourceServer { get; set; } = null!;
        public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; }

        public virtual ICollection<ResourceServerPolicy> Policies { get; set; }
        public virtual ICollection<ResourceServerResource> Resources { get; set; }
    }
}
