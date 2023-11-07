using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientSessionProtMapper
    {
        public string ProtocolMapperId { get; set; } = null!;
        public string ClientSession { get; set; } = null!;

        public virtual ClientSession ClientSessionNavigation { get; set; } = null!;
    }
}
