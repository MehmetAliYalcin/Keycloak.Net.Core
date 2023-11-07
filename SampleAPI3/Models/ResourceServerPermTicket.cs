using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ResourceServerPermTicket
    {
        public string Id { get; set; } = null!;
        public string Owner { get; set; } = null!;
        public string Requester { get; set; } = null!;
        public long CreatedTimestamp { get; set; }
        public long? GrantedTimestamp { get; set; }
        public string ResourceId { get; set; } = null!;
        public string? ScopeId { get; set; }
        public string ResourceServerId { get; set; } = null!;
        public string? PolicyId { get; set; }

        public virtual ResourceServerPolicy? Policy { get; set; }
        public virtual ResourceServerResource Resource { get; set; } = null!;
        public virtual ResourceServer ResourceServer { get; set; } = null!;
        public virtual ResourceServerScope? Scope { get; set; }
    }
}
