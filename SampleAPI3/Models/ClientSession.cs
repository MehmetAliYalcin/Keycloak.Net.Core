using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class ClientSession
    {
        public ClientSession()
        {
            ClientSessionAuthStatuses = new HashSet<ClientSessionAuthStatus>();
            ClientSessionNotes = new HashSet<ClientSessionNote>();
            ClientSessionProtMappers = new HashSet<ClientSessionProtMapper>();
            ClientSessionRoles = new HashSet<ClientSessionRole>();
            ClientUserSessionNotes = new HashSet<ClientUserSessionNote>();
        }

        public string Id { get; set; } = null!;
        public string? ClientId { get; set; }
        public string? RedirectUri { get; set; }
        public string? State { get; set; }
        public int? Timestamp { get; set; }
        public string? SessionId { get; set; }
        public string? AuthMethod { get; set; }
        public string? RealmId { get; set; }
        public string? AuthUserId { get; set; }
        public string? CurrentAction { get; set; }

        public virtual UserSession? Session { get; set; }
        public virtual ICollection<ClientSessionAuthStatus> ClientSessionAuthStatuses { get; set; }
        public virtual ICollection<ClientSessionNote> ClientSessionNotes { get; set; }
        public virtual ICollection<ClientSessionProtMapper> ClientSessionProtMappers { get; set; }
        public virtual ICollection<ClientSessionRole> ClientSessionRoles { get; set; }
        public virtual ICollection<ClientUserSessionNote> ClientUserSessionNotes { get; set; }
    }
}
