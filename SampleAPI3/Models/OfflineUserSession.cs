using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class OfflineUserSession
    {
        public string UserSessionId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public int CreatedOn { get; set; }
        public string OfflineFlag { get; set; } = null!;
        public string? Data { get; set; }
        public int LastSessionRefresh { get; set; }
    }
}
