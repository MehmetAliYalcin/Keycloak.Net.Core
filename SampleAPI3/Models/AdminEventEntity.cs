using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class AdminEventEntity
    {
        public string Id { get; set; } = null!;
        public long? AdminEventTime { get; set; }
        public string? RealmId { get; set; }
        public string? OperationType { get; set; }
        public string? AuthRealmId { get; set; }
        public string? AuthClientId { get; set; }
        public string? AuthUserId { get; set; }
        public string? IpAddress { get; set; }
        public string? ResourcePath { get; set; }
        public string? Representation { get; set; }
        public string? Error { get; set; }
        public string? ResourceType { get; set; }
    }
}
