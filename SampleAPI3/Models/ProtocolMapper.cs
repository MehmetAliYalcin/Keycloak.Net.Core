using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ProtocolMapper
    {
        public ProtocolMapper()
        {
            ProtocolMapperConfigs = new HashSet<ProtocolMapperConfig>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Protocol { get; set; } = null!;
        public string ProtocolMapperName { get; set; } = null!;
        public string? ClientId { get; set; }
        public string? ClientScopeId { get; set; }

        public virtual Client? Client { get; set; }
        public virtual ClientScope? ClientScope { get; set; }
        public virtual ICollection<ProtocolMapperConfig> ProtocolMapperConfigs { get; set; }
    }
}
