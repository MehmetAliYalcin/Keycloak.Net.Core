using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UsernameLoginFailure
    {
        public string RealmId { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int? FailedLoginNotBefore { get; set; }
        public long? LastFailure { get; set; }
        public string? LastIpFailure { get; set; }
        public int? NumFailures { get; set; }
    }
}
