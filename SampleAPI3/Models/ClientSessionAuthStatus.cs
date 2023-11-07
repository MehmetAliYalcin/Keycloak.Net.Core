using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientSessionAuthStatus
    {
        public string Authenticator { get; set; } = null!;
        public int? Status { get; set; }
        public string ClientSession { get; set; } = null!;

        public virtual ClientSession ClientSessionNavigation { get; set; } = null!;
    }
}
