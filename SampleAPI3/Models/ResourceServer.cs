using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceServer
    {
        public ResourceServer()
        {
            ResourceServerPermTickets = new HashSet<ResourceServerPermTicket>();
            ResourceServerPolicies = new HashSet<ResourceServerPolicy>();
            ResourceServerResources = new HashSet<ResourceServerResource>();
            ResourceServerScopes = new HashSet<ResourceServerScope>();
        }

        public string Id { get; set; } = null!;
        public bool AllowRsRemoteMgmt { get; set; }
        public short PolicyEnforceMode { get; set; }
        public short DecisionStrategy { get; set; }

        public virtual ICollection<ResourceServerPermTicket> ResourceServerPermTickets { get; set; }
        public virtual ICollection<ResourceServerPolicy> ResourceServerPolicies { get; set; }
        public virtual ICollection<ResourceServerResource> ResourceServerResources { get; set; }
        public virtual ICollection<ResourceServerScope> ResourceServerScopes { get; set; }
    }
}
