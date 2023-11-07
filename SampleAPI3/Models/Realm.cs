using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class Realm
    {
        public Realm()
        {
            AuthenticationExecutions = new HashSet<AuthenticationExecution>();
            AuthenticationFlows = new HashSet<AuthenticationFlow>();
            AuthenticatorConfigs = new HashSet<AuthenticatorConfig>();
            ClientInitialAccesses = new HashSet<ClientInitialAccess>();
            Components = new HashSet<Component>();
            DefaultClientScopes = new HashSet<DefaultClientScope>();
            IdentityProviderMappers = new HashSet<IdentityProviderMapper>();
            IdentityProviders = new HashSet<IdentityProvider>();
            KeycloakRoles = new HashSet<KeycloakRole>();
            RealmAttributes = new HashSet<RealmAttribute>();
            RealmDefaultGroups = new HashSet<RealmDefaultGroup>();
            RealmEnabledEventTypes = new HashSet<RealmEnabledEventType>();
            RealmEventsListeners = new HashSet<RealmEventsListener>();
            RealmRequiredCredentials = new HashSet<RealmRequiredCredential>();
            RealmSmtpConfigs = new HashSet<RealmSmtpConfig>();
            RealmSupportedLocales = new HashSet<RealmSupportedLocale>();
            RequiredActionProviders = new HashSet<RequiredActionProvider>();
            UserFederationMappers = new HashSet<UserFederationMapper>();
            UserFederationProviders = new HashSet<UserFederationProvider>();
        }

        public string Id { get; set; } = null!;
        public int? AccessCodeLifespan { get; set; }
        public int? UserActionLifespan { get; set; }
        public int? AccessTokenLifespan { get; set; }
        public string? AccountTheme { get; set; }
        public string? AdminTheme { get; set; }
        public string? EmailTheme { get; set; }
        public bool Enabled { get; set; }
        public bool EventsEnabled { get; set; }
        public long? EventsExpiration { get; set; }
        public string? LoginTheme { get; set; }
        public string? Name { get; set; }
        public int? NotBefore { get; set; }
        public string? PasswordPolicy { get; set; }
        public bool RegistrationAllowed { get; set; }
        public bool RememberMe { get; set; }
        public bool ResetPasswordAllowed { get; set; }
        public bool Social { get; set; }
        public string? SslRequired { get; set; }
        public int? SsoIdleTimeout { get; set; }
        public int? SsoMaxLifespan { get; set; }
        public bool UpdateProfileOnSocLogin { get; set; }
        public bool VerifyEmail { get; set; }
        public string? MasterAdminClient { get; set; }
        public int? LoginLifespan { get; set; }
        public bool InternationalizationEnabled { get; set; }
        public string? DefaultLocale { get; set; }
        public bool RegEmailAsUsername { get; set; }
        public bool AdminEventsEnabled { get; set; }
        public bool AdminEventsDetailsEnabled { get; set; }
        public bool EditUsernameAllowed { get; set; }
        public int? OtpPolicyCounter { get; set; }
        public int? OtpPolicyWindow { get; set; }
        public int? OtpPolicyPeriod { get; set; }
        public int? OtpPolicyDigits { get; set; }
        public string? OtpPolicyAlg { get; set; }
        public string? OtpPolicyType { get; set; }
        public string? BrowserFlow { get; set; }
        public string? RegistrationFlow { get; set; }
        public string? DirectGrantFlow { get; set; }
        public string? ResetCredentialsFlow { get; set; }
        public string? ClientAuthFlow { get; set; }
        public int? OfflineSessionIdleTimeout { get; set; }
        public bool RevokeRefreshToken { get; set; }
        public int? AccessTokenLifeImplicit { get; set; }
        public bool? LoginWithEmailAllowed { get; set; }
        public bool DuplicateEmailsAllowed { get; set; }
        public string? DockerAuthFlow { get; set; }
        public int? RefreshTokenMaxReuse { get; set; }
        public bool AllowUserManagedAccess { get; set; }
        public int SsoMaxLifespanRememberMe { get; set; }
        public int SsoIdleTimeoutRememberMe { get; set; }
        public string? DefaultRole { get; set; }

        public virtual ICollection<AuthenticationExecution> AuthenticationExecutions { get; set; }
        public virtual ICollection<AuthenticationFlow> AuthenticationFlows { get; set; }
        public virtual ICollection<AuthenticatorConfig> AuthenticatorConfigs { get; set; }
        public virtual ICollection<ClientInitialAccess> ClientInitialAccesses { get; set; }
        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<DefaultClientScope> DefaultClientScopes { get; set; }
        public virtual ICollection<IdentityProviderMapper> IdentityProviderMappers { get; set; }
        public virtual ICollection<IdentityProvider> IdentityProviders { get; set; }
        public virtual ICollection<KeycloakRole> KeycloakRoles { get; set; }
        public virtual ICollection<RealmAttribute> RealmAttributes { get; set; }
        public virtual ICollection<RealmDefaultGroup> RealmDefaultGroups { get; set; }
        public virtual ICollection<RealmEnabledEventType> RealmEnabledEventTypes { get; set; }
        public virtual ICollection<RealmEventsListener> RealmEventsListeners { get; set; }
        public virtual ICollection<RealmRequiredCredential> RealmRequiredCredentials { get; set; }
        public virtual ICollection<RealmSmtpConfig> RealmSmtpConfigs { get; set; }
        public virtual ICollection<RealmSupportedLocale> RealmSupportedLocales { get; set; }
        public virtual ICollection<RequiredActionProvider> RequiredActionProviders { get; set; }
        public virtual ICollection<UserFederationMapper> UserFederationMappers { get; set; }
        public virtual ICollection<UserFederationProvider> UserFederationProviders { get; set; }
    }
}
