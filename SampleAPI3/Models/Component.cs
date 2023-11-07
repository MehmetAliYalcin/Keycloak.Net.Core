using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class Component
    {
        public Component()
        {
            ComponentConfigs = new HashSet<ComponentConfig>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? ParentId { get; set; }
        public string? ProviderId { get; set; }
        public string? ProviderType { get; set; }
        public string? RealmId { get; set; }
        public string? SubType { get; set; }

        public virtual Realm? Realm { get; set; }
        public virtual ICollection<ComponentConfig> ComponentConfigs { get; set; }
    }
}
