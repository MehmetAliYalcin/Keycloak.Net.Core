using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserSession
    {
        public UserSession()
        {
            ClientSessions = new HashSet<ClientSession>();
            UserSessionNotes = new HashSet<UserSessionNote>();
        }

        public string Id { get; set; } = null!;
        public string? AuthMethod { get; set; }
        public string? IpAddress { get; set; }
        public int? LastSessionRefresh { get; set; }
        public string? LoginUsername { get; set; }
        public string? RealmId { get; set; }
        public bool RememberMe { get; set; }
        public int? Started { get; set; }
        public string? UserId { get; set; }
        public int? UserSessionState { get; set; }
        public string? BrokerSessionId { get; set; }
        public string? BrokerUserId { get; set; }

        public virtual ICollection<ClientSession> ClientSessions { get; set; }
        public virtual ICollection<UserSessionNote> UserSessionNotes { get; set; }
    }
}
