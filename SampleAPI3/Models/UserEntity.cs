using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserEntity
    {
        public UserEntity()
        {
            Credentials = new HashSet<Credential>();
            FederatedIdentities = new HashSet<FederatedIdentity>();
            UserAttributes = new HashSet<UserAttribute>();
            UserConsents = new HashSet<UserConsent>();
            UserGroupMemberships = new HashSet<UserGroupMembership>();
            UserRequiredActions = new HashSet<UserRequiredAction>();
            UserRoleMappings = new HashSet<UserRoleMapping>();
        }

        public string Id { get; set; } = null!;
        public string? Email { get; set; }
        public string? EmailConstraint { get; set; }
        public bool EmailVerified { get; set; }
        public bool Enabled { get; set; }
        public string? FederationLink { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RealmId { get; set; }
        public string? Username { get; set; }
        public long? CreatedTimestamp { get; set; }
        public string? ServiceAccountClientLink { get; set; }
        public int NotBefore { get; set; }

        public virtual ICollection<Credential> Credentials { get; set; }
        public virtual ICollection<FederatedIdentity> FederatedIdentities { get; set; }
        public virtual ICollection<UserAttribute> UserAttributes { get; set; }
        public virtual ICollection<UserConsent> UserConsents { get; set; }
        public virtual ICollection<UserGroupMembership> UserGroupMemberships { get; set; }
        public virtual ICollection<UserRequiredAction> UserRequiredActions { get; set; }
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
