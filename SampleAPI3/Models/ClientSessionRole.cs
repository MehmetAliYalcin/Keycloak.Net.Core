using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientSessionRole
    {
        public string RoleId { get; set; } = null!;
        public string ClientSession { get; set; } = null!;

        public virtual ClientSession ClientSessionNavigation { get; set; } = null!;
    }
}
