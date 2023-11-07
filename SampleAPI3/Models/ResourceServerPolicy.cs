using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceServerPolicy
    {
        public ResourceServerPolicy()
        {
            PolicyConfigs = new HashSet<PolicyConfig>();
            ResourceServerPermTickets = new HashSet<ResourceServerPermTicket>();
            AssociatedPolicies = new HashSet<ResourceServerPolicy>();
            Policies = new HashSet<ResourceServerPolicy>();
            Resources = new HashSet<ResourceServerResource>();
            Scopes = new HashSet<ResourceServerScope>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Type { get; set; } = null!;
        public short? DecisionStrategy { get; set; }
        public short? Logic { get; set; }
        public string ResourceServerId { get; set; } = null!;
        public string? Owner { get; set; }

        public virtual ResourceServer ResourceServer { get; set; } = null!;
        public virtual ICollection<PolicyConfig> PolicyConfigs { get; set; }
        public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; }

        public virtual ICollection<ResourceServerPolicy> AssociatedPolicies { get; set; }
        public virtual ICollection<ResourceServerPolicy> Policies { get; set; }
        public virtual ICollection<ResourceServerResource> Resources { get; set; }
        public virtual ICollection<ResourceServerScope> Scopes { get; set; }
    }
}
