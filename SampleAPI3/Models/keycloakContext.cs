using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleAPI3.Models
{
    public partial class keycloakContext : DbContext
    {
        public keycloakContext()
        {
        }

        public keycloakContext(DbContextOptions<keycloakContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminEventEntity> AdminEventEntities { get; set; } = null!;
        public virtual DbSet<AuthenticationExecution> AuthenticationExecutions { get; set; } = null!;
        public virtual DbSet<AuthenticationFlow> AuthenticationFlows { get; set; } = null!;
        public virtual DbSet<AuthenticatorConfig> AuthenticatorConfigs { get; set; } = null!;
        public virtual DbSet<AuthenticatorConfigEntry> AuthenticatorConfigEntries { get; set; } = null!;
        public virtual DbSet<BrokerLink> BrokerLinks { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientAttribute> ClientAttributes { get; set; } = null!;
        public virtual DbSet<ClientAuthFlowBinding> ClientAuthFlowBindings { get; set; } = null!;
        public virtual DbSet<ClientInitialAccess> ClientInitialAccesses { get; set; } = null!;
        public virtual DbSet<ClientNodeRegistration> ClientNodeRegistrations { get; set; } = null!;
        public virtual DbSet<ClientScope> ClientScopes { get; set; } = null!;
        public virtual DbSet<ClientScopeAttribute> ClientScopeAttributes { get; set; } = null!;
        public virtual DbSet<ClientScopeClient> ClientScopeClients { get; set; } = null!;
        public virtual DbSet<ClientScopeRoleMapping> ClientScopeRoleMappings { get; set; } = null!;
        public virtual DbSet<ClientSession> ClientSessions { get; set; } = null!;
        public virtual DbSet<ClientSessionAuthStatus> ClientSessionAuthStatuses { get; set; } = null!;
        public virtual DbSet<ClientSessionNote> ClientSessionNotes { get; set; } = null!;
        public virtual DbSet<ClientSessionProtMapper> ClientSessionProtMappers { get; set; } = null!;
        public virtual DbSet<ClientSessionRole> ClientSessionRoles { get; set; } = null!;
        public virtual DbSet<ClientUserSessionNote> ClientUserSessionNotes { get; set; } = null!;
        public virtual DbSet<Component> Components { get; set; } = null!;
        public virtual DbSet<ComponentConfig> ComponentConfigs { get; set; } = null!;
        public virtual DbSet<Credential> Credentials { get; set; } = null!;
        public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; } = null!;
        public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; } = null!;
        public virtual DbSet<DefaultClientScope> DefaultClientScopes { get; set; } = null!;
        public virtual DbSet<EventEntity> EventEntities { get; set; } = null!;
        public virtual DbSet<FedUserAttribute> FedUserAttributes { get; set; } = null!;
        public virtual DbSet<FedUserConsent> FedUserConsents { get; set; } = null!;
        public virtual DbSet<FedUserConsentClScope> FedUserConsentClScopes { get; set; } = null!;
        public virtual DbSet<FedUserCredential> FedUserCredentials { get; set; } = null!;
        public virtual DbSet<FedUserGroupMembership> FedUserGroupMemberships { get; set; } = null!;
        public virtual DbSet<FedUserRequiredAction> FedUserRequiredActions { get; set; } = null!;
        public virtual DbSet<FedUserRoleMapping> FedUserRoleMappings { get; set; } = null!;
        public virtual DbSet<FederatedIdentity> FederatedIdentities { get; set; } = null!;
        public virtual DbSet<FederatedUser> FederatedUsers { get; set; } = null!;
        public virtual DbSet<GroupAttribute> GroupAttributes { get; set; } = null!;
        public virtual DbSet<GroupRoleMapping> GroupRoleMappings { get; set; } = null!;
        public virtual DbSet<IdentityProvider> IdentityProviders { get; set; } = null!;
        public virtual DbSet<IdentityProviderConfig> IdentityProviderConfigs { get; set; } = null!;
        public virtual DbSet<IdentityProviderMapper> IdentityProviderMappers { get; set; } = null!;
        public virtual DbSet<IdpMapperConfig> IdpMapperConfigs { get; set; } = null!;
        public virtual DbSet<KeycloakGroup> KeycloakGroups { get; set; } = null!;
        public virtual DbSet<KeycloakRole> KeycloakRoles { get; set; } = null!;
        public virtual DbSet<MigrationModel> MigrationModels { get; set; } = null!;
        public virtual DbSet<OfflineClientSession> OfflineClientSessions { get; set; } = null!;
        public virtual DbSet<OfflineUserSession> OfflineUserSessions { get; set; } = null!;
        public virtual DbSet<PolicyConfig> PolicyConfigs { get; set; } = null!;
        public virtual DbSet<ProtocolMapper> ProtocolMappers { get; set; } = null!;
        public virtual DbSet<ProtocolMapperConfig> ProtocolMapperConfigs { get; set; } = null!;
        public virtual DbSet<Realm> Realms { get; set; } = null!;
        public virtual DbSet<RealmAttribute> RealmAttributes { get; set; } = null!;
        public virtual DbSet<RealmDefaultGroup> RealmDefaultGroups { get; set; } = null!;
        public virtual DbSet<RealmEnabledEventType> RealmEnabledEventTypes { get; set; } = null!;
        public virtual DbSet<RealmEventsListener> RealmEventsListeners { get; set; } = null!;
        public virtual DbSet<RealmLocalization> RealmLocalizations { get; set; } = null!;
        public virtual DbSet<RealmRequiredCredential> RealmRequiredCredentials { get; set; } = null!;
        public virtual DbSet<RealmSmtpConfig> RealmSmtpConfigs { get; set; } = null!;
        public virtual DbSet<RealmSupportedLocale> RealmSupportedLocales { get; set; } = null!;
        public virtual DbSet<RedirectUri> RedirectUris { get; set; } = null!;
        public virtual DbSet<RequiredActionConfig> RequiredActionConfigs { get; set; } = null!;
        public virtual DbSet<RequiredActionProvider> RequiredActionProviders { get; set; } = null!;
        public virtual DbSet<ResourceAttribute> ResourceAttributes { get; set; } = null!;
        public virtual DbSet<ResourceServer> ResourceServers { get; set; } = null!;
        public virtual DbSet<ResourceServerPermTicket> ResourceServerPermTickets { get; set; } = null!;
        public virtual DbSet<ResourceServerPolicy> ResourceServerPolicies { get; set; } = null!;
        public virtual DbSet<ResourceServerResource> ResourceServerResources { get; set; } = null!;
        public virtual DbSet<ResourceServerScope> ResourceServerScopes { get; set; } = null!;
        public virtual DbSet<ResourceUri> ResourceUris { get; set; } = null!;
        public virtual DbSet<RoleAttribute> RoleAttributes { get; set; } = null!;
        public virtual DbSet<ScopeMapping> ScopeMappings { get; set; } = null!;
        public virtual DbSet<UserAttribute> UserAttributes { get; set; } = null!;
        public virtual DbSet<UserConsent> UserConsents { get; set; } = null!;
        public virtual DbSet<UserConsentClientScope> UserConsentClientScopes { get; set; } = null!;
        public virtual DbSet<UserEntity> UserEntities { get; set; } = null!;
        public virtual DbSet<UserFederationConfig> UserFederationConfigs { get; set; } = null!;
        public virtual DbSet<UserFederationMapper> UserFederationMappers { get; set; } = null!;
        public virtual DbSet<UserFederationMapperConfig> UserFederationMapperConfigs { get; set; } = null!;
        public virtual DbSet<UserFederationProvider> UserFederationProviders { get; set; } = null!;
        public virtual DbSet<UserGroupMembership> UserGroupMemberships { get; set; } = null!;
        public virtual DbSet<UserRequiredAction> UserRequiredActions { get; set; } = null!;
        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; } = null!;
        public virtual DbSet<UserSession> UserSessions { get; set; } = null!;
        public virtual DbSet<UserSessionNote> UserSessionNotes { get; set; } = null!;
        public virtual DbSet<UsernameLoginFailure> UsernameLoginFailures { get; set; } = null!;
        public virtual DbSet<WebOrigin> WebOrigins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=keycloak;Username=postgres;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminEventEntity>(entity =>
            {
                entity.ToTable("admin_event_entity");

                entity.HasIndex(e => new { e.RealmId, e.AdminEventTime }, "idx_admin_event_time");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AdminEventTime).HasColumnName("admin_event_time");

                entity.Property(e => e.AuthClientId)
                    .HasMaxLength(255)
                    .HasColumnName("auth_client_id");

                entity.Property(e => e.AuthRealmId)
                    .HasMaxLength(255)
                    .HasColumnName("auth_realm_id");

                entity.Property(e => e.AuthUserId)
                    .HasMaxLength(255)
                    .HasColumnName("auth_user_id");

                entity.Property(e => e.Error)
                    .HasMaxLength(255)
                    .HasColumnName("error");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.OperationType)
                    .HasMaxLength(255)
                    .HasColumnName("operation_type");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Representation).HasColumnName("representation");

                entity.Property(e => e.ResourcePath)
                    .HasMaxLength(2550)
                    .HasColumnName("resource_path");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(64)
                    .HasColumnName("resource_type");
            });

            modelBuilder.Entity<AuthenticationExecution>(entity =>
            {
                entity.ToTable("authentication_execution");

                entity.HasIndex(e => e.FlowId, "idx_auth_exec_flow");

                entity.HasIndex(e => new { e.RealmId, e.FlowId }, "idx_auth_exec_realm_flow");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.AuthConfig)
                    .HasMaxLength(36)
                    .HasColumnName("auth_config");

                entity.Property(e => e.AuthFlowId)
                    .HasMaxLength(36)
                    .HasColumnName("auth_flow_id");

                entity.Property(e => e.Authenticator)
                    .HasMaxLength(36)
                    .HasColumnName("authenticator");

                entity.Property(e => e.AuthenticatorFlow).HasColumnName("authenticator_flow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(36)
                    .HasColumnName("flow_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Requirement).HasColumnName("requirement");

                entity.HasOne(d => d.Flow)
                    .WithMany(p => p.AuthenticationExecutions)
                    .HasForeignKey(d => d.FlowId)
                    .HasConstraintName("fk_auth_exec_flow");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.AuthenticationExecutions)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_auth_exec_realm");
            });

            modelBuilder.Entity<AuthenticationFlow>(entity =>
            {
                entity.ToTable("authentication_flow");

                entity.HasIndex(e => e.RealmId, "idx_auth_flow_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.BuiltIn).HasColumnName("built_in");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'basic-flow'::character varying");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.TopLevel).HasColumnName("top_level");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.AuthenticationFlows)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_auth_flow_realm");
            });

            modelBuilder.Entity<AuthenticatorConfig>(entity =>
            {
                entity.ToTable("authenticator_config");

                entity.HasIndex(e => e.RealmId, "idx_auth_config_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.AuthenticatorConfigs)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_auth_realm");
            });

            modelBuilder.Entity<AuthenticatorConfigEntry>(entity =>
            {
                entity.HasKey(e => new { e.AuthenticatorId, e.Name })
                    .HasName("constraint_auth_cfg_pk");

                entity.ToTable("authenticator_config_entry");

                entity.Property(e => e.AuthenticatorId)
                    .HasMaxLength(36)
                    .HasColumnName("authenticator_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<BrokerLink>(entity =>
            {
                entity.HasKey(e => new { e.IdentityProvider, e.UserId })
                    .HasName("constr_broker_link_pk");

                entity.ToTable("broker_link");

                entity.Property(e => e.IdentityProvider)
                    .HasMaxLength(255)
                    .HasColumnName("identity_provider");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.BrokerUserId)
                    .HasMaxLength(255)
                    .HasColumnName("broker_user_id");

                entity.Property(e => e.BrokerUsername)
                    .HasMaxLength(255)
                    .HasColumnName("broker_username");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("storage_provider_id");

                entity.Property(e => e.Token).HasColumnName("token");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.ClientId, "idx_client_id");

                entity.HasIndex(e => new { e.RealmId, e.ClientId }, "uk_b71cjlbenv945rb6gcon438at")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AlwaysDisplayInConsole).HasColumnName("always_display_in_console");

                entity.Property(e => e.BaseUrl)
                    .HasMaxLength(255)
                    .HasColumnName("base_url");

                entity.Property(e => e.BearerOnly).HasColumnName("bearer_only");

                entity.Property(e => e.ClientAuthenticatorType)
                    .HasMaxLength(255)
                    .HasColumnName("client_authenticator_type");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ConsentRequired).HasColumnName("consent_required");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DirectAccessGrantsEnabled).HasColumnName("direct_access_grants_enabled");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FrontchannelLogout).HasColumnName("frontchannel_logout");

                entity.Property(e => e.FullScopeAllowed).HasColumnName("full_scope_allowed");

                entity.Property(e => e.ImplicitFlowEnabled).HasColumnName("implicit_flow_enabled");

                entity.Property(e => e.ManagementUrl)
                    .HasMaxLength(255)
                    .HasColumnName("management_url");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NodeReregTimeout)
                    .HasColumnName("node_rereg_timeout")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NotBefore).HasColumnName("not_before");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(255)
                    .HasColumnName("protocol");

                entity.Property(e => e.PublicClient).HasColumnName("public_client");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.RegistrationToken)
                    .HasMaxLength(255)
                    .HasColumnName("registration_token");

                entity.Property(e => e.RootUrl)
                    .HasMaxLength(255)
                    .HasColumnName("root_url");

                entity.Property(e => e.Secret)
                    .HasMaxLength(255)
                    .HasColumnName("secret");

                entity.Property(e => e.ServiceAccountsEnabled).HasColumnName("service_accounts_enabled");

                entity.Property(e => e.StandardFlowEnabled)
                    .IsRequired()
                    .HasColumnName("standard_flow_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SurrogateAuthRequired).HasColumnName("surrogate_auth_required");
            });

            modelBuilder.Entity<ClientAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Name })
                    .HasName("constraint_3c");

                entity.ToTable("client_attributes");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAttributes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk3c47c64beacca966");
            });

            modelBuilder.Entity<ClientAuthFlowBinding>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.BindingName })
                    .HasName("c_cli_flow_bind");

                entity.ToTable("client_auth_flow_bindings");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.BindingName)
                    .HasMaxLength(255)
                    .HasColumnName("binding_name");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(36)
                    .HasColumnName("flow_id");
            });

            modelBuilder.Entity<ClientInitialAccess>(entity =>
            {
                entity.ToTable("client_initial_access");

                entity.HasIndex(e => e.RealmId, "idx_client_init_acc_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Expiration).HasColumnName("expiration");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.RemainingCount).HasColumnName("remaining_count");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.ClientInitialAccesses)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_client_init_acc_realm");
            });

            modelBuilder.Entity<ClientNodeRegistration>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Name })
                    .HasName("constraint_84");

                entity.ToTable("client_node_registrations");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientNodeRegistrations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk4129723ba992f594");
            });

            modelBuilder.Entity<ClientScope>(entity =>
            {
                entity.ToTable("client_scope");

                entity.HasIndex(e => e.RealmId, "idx_realm_clscope");

                entity.HasIndex(e => new { e.RealmId, e.Name }, "uk_cli_scope")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(255)
                    .HasColumnName("protocol");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");
            });

            modelBuilder.Entity<ClientScopeAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ScopeId, e.Name })
                    .HasName("pk_cl_tmpl_attr");

                entity.ToTable("client_scope_attributes");

                entity.HasIndex(e => e.ScopeId, "idx_clscope_attrs");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(2048)
                    .HasColumnName("value");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.ClientScopeAttributes)
                    .HasForeignKey(d => d.ScopeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cl_scope_attr_scope");
            });

            modelBuilder.Entity<ClientScopeClient>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.ScopeId })
                    .HasName("c_cli_scope_bind");

                entity.ToTable("client_scope_client");

                entity.HasIndex(e => e.ScopeId, "idx_cl_clscope");

                entity.HasIndex(e => e.ClientId, "idx_clscope_cl");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(255)
                    .HasColumnName("scope_id");

                entity.Property(e => e.DefaultScope).HasColumnName("default_scope");
            });

            modelBuilder.Entity<ClientScopeRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.ScopeId, e.RoleId })
                    .HasName("pk_template_scope");

                entity.ToTable("client_scope_role_mapping");

                entity.HasIndex(e => e.ScopeId, "idx_clscope_role");

                entity.HasIndex(e => e.RoleId, "idx_role_clscope");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.ClientScopeRoleMappings)
                    .HasForeignKey(d => d.ScopeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cl_scope_rm_scope");
            });

            modelBuilder.Entity<ClientSession>(entity =>
            {
                entity.ToTable("client_session");

                entity.HasIndex(e => e.SessionId, "idx_client_session_session");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AuthMethod)
                    .HasMaxLength(255)
                    .HasColumnName("auth_method");

                entity.Property(e => e.AuthUserId)
                    .HasMaxLength(36)
                    .HasColumnName("auth_user_id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.CurrentAction)
                    .HasMaxLength(36)
                    .HasColumnName("current_action");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.RedirectUri)
                    .HasMaxLength(255)
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(36)
                    .HasColumnName("session_id");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.ClientSessions)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("fk_b4ao2vcvat6ukau74wbwtfqo1");
            });

            modelBuilder.Entity<ClientSessionAuthStatus>(entity =>
            {
                entity.HasKey(e => new { e.ClientSession, e.Authenticator })
                    .HasName("constraint_auth_status_pk");

                entity.ToTable("client_session_auth_status");

                entity.Property(e => e.ClientSession)
                    .HasMaxLength(36)
                    .HasColumnName("client_session");

                entity.Property(e => e.Authenticator)
                    .HasMaxLength(36)
                    .HasColumnName("authenticator");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.ClientSessionNavigation)
                    .WithMany(p => p.ClientSessionAuthStatuses)
                    .HasForeignKey(d => d.ClientSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_status_constraint");
            });

            modelBuilder.Entity<ClientSessionNote>(entity =>
            {
                entity.HasKey(e => new { e.ClientSession, e.Name })
                    .HasName("constraint_5e");

                entity.ToTable("client_session_note");

                entity.Property(e => e.ClientSession)
                    .HasMaxLength(36)
                    .HasColumnName("client_session");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.ClientSessionNavigation)
                    .WithMany(p => p.ClientSessionNotes)
                    .HasForeignKey(d => d.ClientSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk5edfb00ff51c2736");
            });

            modelBuilder.Entity<ClientSessionProtMapper>(entity =>
            {
                entity.HasKey(e => new { e.ClientSession, e.ProtocolMapperId })
                    .HasName("constraint_cs_pmp_pk");

                entity.ToTable("client_session_prot_mapper");

                entity.Property(e => e.ClientSession)
                    .HasMaxLength(36)
                    .HasColumnName("client_session");

                entity.Property(e => e.ProtocolMapperId)
                    .HasMaxLength(36)
                    .HasColumnName("protocol_mapper_id");

                entity.HasOne(d => d.ClientSessionNavigation)
                    .WithMany(p => p.ClientSessionProtMappers)
                    .HasForeignKey(d => d.ClientSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_33a8sgqw18i532811v7o2dk89");
            });

            modelBuilder.Entity<ClientSessionRole>(entity =>
            {
                entity.HasKey(e => new { e.ClientSession, e.RoleId })
                    .HasName("constraint_5");

                entity.ToTable("client_session_role");

                entity.Property(e => e.ClientSession)
                    .HasMaxLength(36)
                    .HasColumnName("client_session");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(255)
                    .HasColumnName("role_id");

                entity.HasOne(d => d.ClientSessionNavigation)
                    .WithMany(p => p.ClientSessionRoles)
                    .HasForeignKey(d => d.ClientSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_11b7sgqw18i532811v7o2dv76");
            });

            modelBuilder.Entity<ClientUserSessionNote>(entity =>
            {
                entity.HasKey(e => new { e.ClientSession, e.Name })
                    .HasName("constr_cl_usr_ses_note");

                entity.ToTable("client_user_session_note");

                entity.Property(e => e.ClientSession)
                    .HasMaxLength(36)
                    .HasColumnName("client_session");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(2048)
                    .HasColumnName("value");

                entity.HasOne(d => d.ClientSessionNavigation)
                    .WithMany(p => p.ClientUserSessionNotes)
                    .HasForeignKey(d => d.ClientSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cl_usr_ses_note");
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.ToTable("component");

                entity.HasIndex(e => e.ProviderType, "idx_component_provider_type");

                entity.HasIndex(e => e.RealmId, "idx_component_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(36)
                    .HasColumnName("parent_id");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderType)
                    .HasMaxLength(255)
                    .HasColumnName("provider_type");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.SubType)
                    .HasMaxLength(255)
                    .HasColumnName("sub_type");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_component_realm");
            });

            modelBuilder.Entity<ComponentConfig>(entity =>
            {
                entity.ToTable("component_config");

                entity.HasIndex(e => e.ComponentId, "idx_compo_config_compo");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ComponentId)
                    .HasMaxLength(36)
                    .HasColumnName("component_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(4000)
                    .HasColumnName("value");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.ComponentConfigs)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_component_config");
            });

            modelBuilder.Entity<Credential>(entity =>
            {
                entity.ToTable("credential");

                entity.HasIndex(e => e.UserId, "idx_user_credential");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CredentialData).HasColumnName("credential_data");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Salt).HasColumnName("salt");

                entity.Property(e => e.SecretData).HasColumnName("secret_data");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.Property(e => e.UserLabel)
                    .HasMaxLength(255)
                    .HasColumnName("user_label");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Credentials)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_pfyr0glasqyl0dei3kl69r6v0");
            });

            modelBuilder.Entity<Databasechangelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("databasechangelog");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.Contexts)
                    .HasMaxLength(255)
                    .HasColumnName("contexts");

                entity.Property(e => e.Dateexecuted)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dateexecuted");

                entity.Property(e => e.DeploymentId)
                    .HasMaxLength(10)
                    .HasColumnName("deployment_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Exectype)
                    .HasMaxLength(10)
                    .HasColumnName("exectype");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.Labels)
                    .HasMaxLength(255)
                    .HasColumnName("labels");

                entity.Property(e => e.Liquibase)
                    .HasMaxLength(20)
                    .HasColumnName("liquibase");

                entity.Property(e => e.Md5sum)
                    .HasMaxLength(35)
                    .HasColumnName("md5sum");

                entity.Property(e => e.Orderexecuted).HasColumnName("orderexecuted");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<Databasechangeloglock>(entity =>
            {
                entity.ToTable("databasechangeloglock");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Lockedby)
                    .HasMaxLength(255)
                    .HasColumnName("lockedby");

                entity.Property(e => e.Lockgranted)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("lockgranted");
            });

            modelBuilder.Entity<DefaultClientScope>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.ScopeId })
                    .HasName("r_def_cli_scope_bind");

                entity.ToTable("default_client_scope");

                entity.HasIndex(e => e.RealmId, "idx_defcls_realm");

                entity.HasIndex(e => e.ScopeId, "idx_defcls_scope");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");

                entity.Property(e => e.DefaultScope).HasColumnName("default_scope");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.DefaultClientScopes)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_r_def_cli_scope_realm");
            });

            modelBuilder.Entity<EventEntity>(entity =>
            {
                entity.ToTable("event_entity");

                entity.HasIndex(e => new { e.RealmId, e.EventTime }, "idx_event_time");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.DetailsJson)
                    .HasMaxLength(2550)
                    .HasColumnName("details_json");

                entity.Property(e => e.Error)
                    .HasMaxLength(255)
                    .HasColumnName("error");

                entity.Property(e => e.EventTime).HasColumnName("event_time");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(255)
                    .HasColumnName("session_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<FedUserAttribute>(entity =>
            {
                entity.ToTable("fed_user_attribute");

                entity.HasIndex(e => new { e.UserId, e.RealmId, e.Name }, "idx_fu_attribute");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(2024)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<FedUserConsent>(entity =>
            {
                entity.ToTable("fed_user_consent");

                entity.HasIndex(e => new { e.UserId, e.ClientStorageProvider, e.ExternalClientId }, "idx_fu_cnsnt_ext");

                entity.HasIndex(e => new { e.UserId, e.ClientId }, "idx_fu_consent");

                entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_consent_ru");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientStorageProvider)
                    .HasMaxLength(36)
                    .HasColumnName("client_storage_provider");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ExternalClientId)
                    .HasMaxLength(255)
                    .HasColumnName("external_client_id");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<FedUserConsentClScope>(entity =>
            {
                entity.HasKey(e => new { e.UserConsentId, e.ScopeId })
                    .HasName("constraint_fgrntcsnt_clsc_pm");

                entity.ToTable("fed_user_consent_cl_scope");

                entity.Property(e => e.UserConsentId)
                    .HasMaxLength(36)
                    .HasColumnName("user_consent_id");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");
            });

            modelBuilder.Entity<FedUserCredential>(entity =>
            {
                entity.ToTable("fed_user_credential");

                entity.HasIndex(e => new { e.UserId, e.Type }, "idx_fu_credential");

                entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_credential_ru");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CredentialData).HasColumnName("credential_data");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Salt).HasColumnName("salt");

                entity.Property(e => e.SecretData).HasColumnName("secret_data");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.UserLabel)
                    .HasMaxLength(255)
                    .HasColumnName("user_label");
            });

            modelBuilder.Entity<FedUserGroupMembership>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId })
                    .HasName("constr_fed_user_group");

                entity.ToTable("fed_user_group_membership");

                entity.HasIndex(e => new { e.UserId, e.GroupId }, "idx_fu_group_membership");

                entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_group_membership_ru");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("group_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");
            });

            modelBuilder.Entity<FedUserRequiredAction>(entity =>
            {
                entity.HasKey(e => new { e.RequiredAction, e.UserId })
                    .HasName("constr_fed_required_action");

                entity.ToTable("fed_user_required_action");

                entity.HasIndex(e => new { e.UserId, e.RequiredAction }, "idx_fu_required_action");

                entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_required_action_ru");

                entity.Property(e => e.RequiredAction)
                    .HasMaxLength(255)
                    .HasColumnName("required_action")
                    .HasDefaultValueSql("' '::character varying");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");
            });

            modelBuilder.Entity<FedUserRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("constr_fed_user_role");

                entity.ToTable("fed_user_role_mapping");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "idx_fu_role_mapping");

                entity.HasIndex(e => new { e.RealmId, e.UserId }, "idx_fu_role_mapping_ru");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("storage_provider_id");
            });

            modelBuilder.Entity<FederatedIdentity>(entity =>
            {
                entity.HasKey(e => new { e.IdentityProvider, e.UserId })
                    .HasName("constraint_40");

                entity.ToTable("federated_identity");

                entity.HasIndex(e => e.FederatedUserId, "idx_fedidentity_feduser");

                entity.HasIndex(e => e.UserId, "idx_fedidentity_user");

                entity.Property(e => e.IdentityProvider)
                    .HasMaxLength(255)
                    .HasColumnName("identity_provider");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.Property(e => e.FederatedUserId)
                    .HasMaxLength(255)
                    .HasColumnName("federated_user_id");

                entity.Property(e => e.FederatedUsername)
                    .HasMaxLength(255)
                    .HasColumnName("federated_username");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FederatedIdentities)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk404288b92ef007a6");
            });

            modelBuilder.Entity<FederatedUser>(entity =>
            {
                entity.ToTable("federated_user");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StorageProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("storage_provider_id");
            });

            modelBuilder.Entity<GroupAttribute>(entity =>
            {
                entity.ToTable("group_attribute");

                entity.HasIndex(e => e.GroupId, "idx_group_attr_group");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'sybase-needs-something-here'::character varying");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("group_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupAttributes)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_attribute_group");
            });

            modelBuilder.Entity<GroupRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.GroupId })
                    .HasName("constraint_group_role");

                entity.ToTable("group_role_mapping");

                entity.HasIndex(e => e.GroupId, "idx_group_role_mapp_group");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupRoleMappings)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_role_group");
            });

            modelBuilder.Entity<IdentityProvider>(entity =>
            {
                entity.HasKey(e => e.InternalId)
                    .HasName("constraint_2b");

                entity.ToTable("identity_provider");

                entity.HasIndex(e => e.RealmId, "idx_ident_prov_realm");

                entity.HasIndex(e => new { e.ProviderAlias, e.RealmId }, "uk_2daelwnibji49avxsrtuf6xj33")
                    .IsUnique();

                entity.Property(e => e.InternalId)
                    .HasMaxLength(36)
                    .HasColumnName("internal_id");

                entity.Property(e => e.AddTokenRole)
                    .IsRequired()
                    .HasColumnName("add_token_role")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AuthenticateByDefault).HasColumnName("authenticate_by_default");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FirstBrokerLoginFlowId)
                    .HasMaxLength(36)
                    .HasColumnName("first_broker_login_flow_id");

                entity.Property(e => e.LinkOnly).HasColumnName("link_only");

                entity.Property(e => e.PostBrokerLoginFlowId)
                    .HasMaxLength(36)
                    .HasColumnName("post_broker_login_flow_id");

                entity.Property(e => e.ProviderAlias)
                    .HasMaxLength(255)
                    .HasColumnName("provider_alias");

                entity.Property(e => e.ProviderDisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_display_name");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.StoreToken).HasColumnName("store_token");

                entity.Property(e => e.TrustEmail).HasColumnName("trust_email");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.IdentityProviders)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk2b4ebc52ae5c3b34");
            });

            modelBuilder.Entity<IdentityProviderConfig>(entity =>
            {
                entity.HasKey(e => new { e.IdentityProviderId, e.Name })
                    .HasName("constraint_d");

                entity.ToTable("identity_provider_config");

                entity.Property(e => e.IdentityProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("identity_provider_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.IdentityProvider)
                    .WithMany(p => p.IdentityProviderConfigs)
                    .HasForeignKey(d => d.IdentityProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkdc4897cf864c4e43");
            });

            modelBuilder.Entity<IdentityProviderMapper>(entity =>
            {
                entity.ToTable("identity_provider_mapper");

                entity.HasIndex(e => e.RealmId, "idx_id_prov_mapp_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.IdpAlias)
                    .HasMaxLength(255)
                    .HasColumnName("idp_alias");

                entity.Property(e => e.IdpMapperName)
                    .HasMaxLength(255)
                    .HasColumnName("idp_mapper_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.IdentityProviderMappers)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_idpm_realm");
            });

            modelBuilder.Entity<IdpMapperConfig>(entity =>
            {
                entity.HasKey(e => new { e.IdpMapperId, e.Name })
                    .HasName("constraint_idpmconfig");

                entity.ToTable("idp_mapper_config");

                entity.Property(e => e.IdpMapperId)
                    .HasMaxLength(36)
                    .HasColumnName("idp_mapper_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.IdpMapper)
                    .WithMany(p => p.IdpMapperConfigs)
                    .HasForeignKey(d => d.IdpMapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_idpmconfig");
            });

            modelBuilder.Entity<KeycloakGroup>(entity =>
            {
                entity.ToTable("keycloak_group");

                entity.HasIndex(e => new { e.RealmId, e.ParentGroup, e.Name }, "sibling_names")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentGroup)
                    .HasMaxLength(36)
                    .HasColumnName("parent_group");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");
            });

            modelBuilder.Entity<KeycloakRole>(entity =>
            {
                entity.ToTable("keycloak_role");

                entity.HasIndex(e => new { e.Name, e.ClientRealmConstraint }, "UK_J3RWUVD56ONTGSUHOGM184WW2-2")
                    .IsUnique();

                entity.HasIndex(e => e.Client, "idx_keycloak_role_client");

                entity.HasIndex(e => e.Realm, "idx_keycloak_role_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Client)
                    .HasMaxLength(36)
                    .HasColumnName("client");

                entity.Property(e => e.ClientRealmConstraint)
                    .HasMaxLength(255)
                    .HasColumnName("client_realm_constraint");

                entity.Property(e => e.ClientRole).HasColumnName("client_role");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Realm)
                    .HasMaxLength(36)
                    .HasColumnName("realm");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.RealmNavigation)
                    .WithMany(p => p.KeycloakRoles)
                    .HasForeignKey(d => d.Realm)
                    .HasConstraintName("fk_6vyqfe4cn4wlq8r6kt5vdsj5c");

                entity.HasMany(d => d.ChildRoles)
                    .WithMany(p => p.Composites)
                    .UsingEntity<Dictionary<string, object>>(
                        "CompositeRole",
                        l => l.HasOne<KeycloakRole>().WithMany().HasForeignKey("ChildRole").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_gr7thllb9lu8q4vqa4524jjy8"),
                        r => r.HasOne<KeycloakRole>().WithMany().HasForeignKey("Composite").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_a63wvekftu8jo1pnj81e7mce2"),
                        j =>
                        {
                            j.HasKey("Composite", "ChildRole").HasName("constraint_composite_role");

                            j.ToTable("composite_role");

                            j.HasIndex(new[] { "Composite" }, "idx_composite");

                            j.HasIndex(new[] { "ChildRole" }, "idx_composite_child");

                            j.IndexerProperty<string>("Composite").HasMaxLength(36).HasColumnName("composite");

                            j.IndexerProperty<string>("ChildRole").HasMaxLength(36).HasColumnName("child_role");
                        });

                entity.HasMany(d => d.Composites)
                    .WithMany(p => p.ChildRoles)
                    .UsingEntity<Dictionary<string, object>>(
                        "CompositeRole",
                        l => l.HasOne<KeycloakRole>().WithMany().HasForeignKey("Composite").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_a63wvekftu8jo1pnj81e7mce2"),
                        r => r.HasOne<KeycloakRole>().WithMany().HasForeignKey("ChildRole").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_gr7thllb9lu8q4vqa4524jjy8"),
                        j =>
                        {
                            j.HasKey("Composite", "ChildRole").HasName("constraint_composite_role");

                            j.ToTable("composite_role");

                            j.HasIndex(new[] { "Composite" }, "idx_composite");

                            j.HasIndex(new[] { "ChildRole" }, "idx_composite_child");

                            j.IndexerProperty<string>("Composite").HasMaxLength(36).HasColumnName("composite");

                            j.IndexerProperty<string>("ChildRole").HasMaxLength(36).HasColumnName("child_role");
                        });
            });

            modelBuilder.Entity<MigrationModel>(entity =>
            {
                entity.ToTable("migration_model");

                entity.HasIndex(e => e.UpdateTime, "idx_update_time");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.UpdateTime).HasColumnName("update_time");

                entity.Property(e => e.Version)
                    .HasMaxLength(36)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<OfflineClientSession>(entity =>
            {
                entity.HasKey(e => new { e.UserSessionId, e.ClientId, e.ClientStorageProvider, e.ExternalClientId, e.OfflineFlag })
                    .HasName("constraint_offl_cl_ses_pk3");

                entity.ToTable("offline_client_session");

                entity.HasIndex(e => new { e.ClientId, e.OfflineFlag }, "idx_offline_css_preload");

                entity.HasIndex(e => e.UserSessionId, "idx_us_sess_id_on_cl_sess");

                entity.Property(e => e.UserSessionId)
                    .HasMaxLength(36)
                    .HasColumnName("user_session_id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientStorageProvider)
                    .HasMaxLength(36)
                    .HasColumnName("client_storage_provider")
                    .HasDefaultValueSql("'local'::character varying");

                entity.Property(e => e.ExternalClientId)
                    .HasMaxLength(255)
                    .HasColumnName("external_client_id")
                    .HasDefaultValueSql("'local'::character varying");

                entity.Property(e => e.OfflineFlag)
                    .HasMaxLength(4)
                    .HasColumnName("offline_flag");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<OfflineUserSession>(entity =>
            {
                entity.HasKey(e => new { e.UserSessionId, e.OfflineFlag })
                    .HasName("constraint_offl_us_ses_pk2");

                entity.ToTable("offline_user_session");

                entity.HasIndex(e => new { e.UserId, e.RealmId, e.OfflineFlag }, "idx_offline_uss_by_user");

                entity.HasIndex(e => new { e.RealmId, e.OfflineFlag, e.UserSessionId }, "idx_offline_uss_by_usersess");

                entity.HasIndex(e => e.CreatedOn, "idx_offline_uss_createdon");

                entity.HasIndex(e => new { e.OfflineFlag, e.CreatedOn, e.UserSessionId }, "idx_offline_uss_preload");

                entity.Property(e => e.UserSessionId)
                    .HasMaxLength(36)
                    .HasColumnName("user_session_id");

                entity.Property(e => e.OfflineFlag)
                    .HasMaxLength(4)
                    .HasColumnName("offline_flag");

                entity.Property(e => e.CreatedOn).HasColumnName("created_on");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.LastSessionRefresh).HasColumnName("last_session_refresh");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<PolicyConfig>(entity =>
            {
                entity.HasKey(e => new { e.PolicyId, e.Name })
                    .HasName("constraint_dpc");

                entity.ToTable("policy_config");

                entity.Property(e => e.PolicyId)
                    .HasMaxLength(36)
                    .HasColumnName("policy_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.PolicyConfigs)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkdc34197cf864c4e43");
            });

            modelBuilder.Entity<ProtocolMapper>(entity =>
            {
                entity.ToTable("protocol_mapper");

                entity.HasIndex(e => e.ClientScopeId, "idx_clscope_protmap");

                entity.HasIndex(e => e.ClientId, "idx_protocol_mapper_client");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("client_scope_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Protocol)
                    .HasMaxLength(255)
                    .HasColumnName("protocol");

                entity.Property(e => e.ProtocolMapperName)
                    .HasMaxLength(255)
                    .HasColumnName("protocol_mapper_name");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProtocolMappers)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("fk_pcm_realm");

                entity.HasOne(d => d.ClientScope)
                    .WithMany(p => p.ProtocolMappers)
                    .HasForeignKey(d => d.ClientScopeId)
                    .HasConstraintName("fk_cli_scope_mapper");
            });

            modelBuilder.Entity<ProtocolMapperConfig>(entity =>
            {
                entity.HasKey(e => new { e.ProtocolMapperId, e.Name })
                    .HasName("constraint_pmconfig");

                entity.ToTable("protocol_mapper_config");

                entity.Property(e => e.ProtocolMapperId)
                    .HasMaxLength(36)
                    .HasColumnName("protocol_mapper_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.ProtocolMapper)
                    .WithMany(p => p.ProtocolMapperConfigs)
                    .HasForeignKey(d => d.ProtocolMapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pmconfig");
            });

            modelBuilder.Entity<Realm>(entity =>
            {
                entity.ToTable("realm");

                entity.HasIndex(e => e.MasterAdminClient, "idx_realm_master_adm_cli");

                entity.HasIndex(e => e.Name, "uk_orvsdmla56612eaefiq6wl5oi")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AccessCodeLifespan).HasColumnName("access_code_lifespan");

                entity.Property(e => e.AccessTokenLifeImplicit)
                    .HasColumnName("access_token_life_implicit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AccessTokenLifespan).HasColumnName("access_token_lifespan");

                entity.Property(e => e.AccountTheme)
                    .HasMaxLength(255)
                    .HasColumnName("account_theme");

                entity.Property(e => e.AdminEventsDetailsEnabled).HasColumnName("admin_events_details_enabled");

                entity.Property(e => e.AdminEventsEnabled).HasColumnName("admin_events_enabled");

                entity.Property(e => e.AdminTheme)
                    .HasMaxLength(255)
                    .HasColumnName("admin_theme");

                entity.Property(e => e.AllowUserManagedAccess).HasColumnName("allow_user_managed_access");

                entity.Property(e => e.BrowserFlow)
                    .HasMaxLength(36)
                    .HasColumnName("browser_flow");

                entity.Property(e => e.ClientAuthFlow)
                    .HasMaxLength(36)
                    .HasColumnName("client_auth_flow");

                entity.Property(e => e.DefaultLocale)
                    .HasMaxLength(255)
                    .HasColumnName("default_locale");

                entity.Property(e => e.DefaultRole)
                    .HasMaxLength(255)
                    .HasColumnName("default_role");

                entity.Property(e => e.DirectGrantFlow)
                    .HasMaxLength(36)
                    .HasColumnName("direct_grant_flow");

                entity.Property(e => e.DockerAuthFlow)
                    .HasMaxLength(36)
                    .HasColumnName("docker_auth_flow");

                entity.Property(e => e.DuplicateEmailsAllowed).HasColumnName("duplicate_emails_allowed");

                entity.Property(e => e.EditUsernameAllowed).HasColumnName("edit_username_allowed");

                entity.Property(e => e.EmailTheme)
                    .HasMaxLength(255)
                    .HasColumnName("email_theme");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.EventsEnabled).HasColumnName("events_enabled");

                entity.Property(e => e.EventsExpiration).HasColumnName("events_expiration");

                entity.Property(e => e.InternationalizationEnabled).HasColumnName("internationalization_enabled");

                entity.Property(e => e.LoginLifespan).HasColumnName("login_lifespan");

                entity.Property(e => e.LoginTheme)
                    .HasMaxLength(255)
                    .HasColumnName("login_theme");

                entity.Property(e => e.LoginWithEmailAllowed)
                    .IsRequired()
                    .HasColumnName("login_with_email_allowed")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MasterAdminClient)
                    .HasMaxLength(36)
                    .HasColumnName("master_admin_client");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NotBefore).HasColumnName("not_before");

                entity.Property(e => e.OfflineSessionIdleTimeout)
                    .HasColumnName("offline_session_idle_timeout")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtpPolicyAlg)
                    .HasMaxLength(36)
                    .HasColumnName("otp_policy_alg")
                    .HasDefaultValueSql("'HmacSHA1'::character varying");

                entity.Property(e => e.OtpPolicyCounter)
                    .HasColumnName("otp_policy_counter")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtpPolicyDigits)
                    .HasColumnName("otp_policy_digits")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.OtpPolicyPeriod)
                    .HasColumnName("otp_policy_period")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.OtpPolicyType)
                    .HasMaxLength(36)
                    .HasColumnName("otp_policy_type")
                    .HasDefaultValueSql("'totp'::character varying");

                entity.Property(e => e.OtpPolicyWindow)
                    .HasColumnName("otp_policy_window")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PasswordPolicy)
                    .HasMaxLength(2550)
                    .HasColumnName("password_policy");

                entity.Property(e => e.RefreshTokenMaxReuse)
                    .HasColumnName("refresh_token_max_reuse")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegEmailAsUsername).HasColumnName("reg_email_as_username");

                entity.Property(e => e.RegistrationAllowed).HasColumnName("registration_allowed");

                entity.Property(e => e.RegistrationFlow)
                    .HasMaxLength(36)
                    .HasColumnName("registration_flow");

                entity.Property(e => e.RememberMe).HasColumnName("remember_me");

                entity.Property(e => e.ResetCredentialsFlow)
                    .HasMaxLength(36)
                    .HasColumnName("reset_credentials_flow");

                entity.Property(e => e.ResetPasswordAllowed).HasColumnName("reset_password_allowed");

                entity.Property(e => e.RevokeRefreshToken).HasColumnName("revoke_refresh_token");

                entity.Property(e => e.Social).HasColumnName("social");

                entity.Property(e => e.SslRequired)
                    .HasMaxLength(255)
                    .HasColumnName("ssl_required");

                entity.Property(e => e.SsoIdleTimeout).HasColumnName("sso_idle_timeout");

                entity.Property(e => e.SsoIdleTimeoutRememberMe).HasColumnName("sso_idle_timeout_remember_me");

                entity.Property(e => e.SsoMaxLifespan).HasColumnName("sso_max_lifespan");

                entity.Property(e => e.SsoMaxLifespanRememberMe).HasColumnName("sso_max_lifespan_remember_me");

                entity.Property(e => e.UpdateProfileOnSocLogin).HasColumnName("update_profile_on_soc_login");

                entity.Property(e => e.UserActionLifespan).HasColumnName("user_action_lifespan");

                entity.Property(e => e.VerifyEmail).HasColumnName("verify_email");
            });

            modelBuilder.Entity<RealmAttribute>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.RealmId })
                    .HasName("constraint_9");

                entity.ToTable("realm_attribute");

                entity.HasIndex(e => e.RealmId, "idx_realm_attr_realm");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmAttributes)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_8shxd6l3e9atqukacxgpffptw");
            });

            modelBuilder.Entity<RealmDefaultGroup>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.GroupId })
                    .HasName("constr_realm_default_groups");

                entity.ToTable("realm_default_groups");

                entity.HasIndex(e => e.GroupId, "con_group_id_def_groups")
                    .IsUnique();

                entity.HasIndex(e => e.RealmId, "idx_realm_def_grp_realm");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("group_id");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmDefaultGroups)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_def_groups_realm");
            });

            modelBuilder.Entity<RealmEnabledEventType>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Value })
                    .HasName("constr_realm_enabl_event_types");

                entity.ToTable("realm_enabled_event_types");

                entity.HasIndex(e => e.RealmId, "idx_realm_evt_types_realm");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmEnabledEventTypes)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_h846o4h0w8epx5nwedrf5y69j");
            });

            modelBuilder.Entity<RealmEventsListener>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Value })
                    .HasName("constr_realm_events_listeners");

                entity.ToTable("realm_events_listeners");

                entity.HasIndex(e => e.RealmId, "idx_realm_evt_list_realm");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmEventsListeners)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_h846o4h0w8epx5nxev9f5y69j");
            });

            modelBuilder.Entity<RealmLocalization>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Locale })
                    .HasName("realm_localizations_pkey");

                entity.ToTable("realm_localizations");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Locale)
                    .HasMaxLength(255)
                    .HasColumnName("locale");

                entity.Property(e => e.Texts).HasColumnName("texts");
            });

            modelBuilder.Entity<RealmRequiredCredential>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Type })
                    .HasName("constraint_92");

                entity.ToTable("realm_required_credential");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.FormLabel)
                    .HasMaxLength(255)
                    .HasColumnName("form_label");

                entity.Property(e => e.Input).HasColumnName("input");

                entity.Property(e => e.Secret).HasColumnName("secret");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmRequiredCredentials)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_5hg65lybevavkqfki3kponh9v");
            });

            modelBuilder.Entity<RealmSmtpConfig>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Name })
                    .HasName("constraint_e");

                entity.ToTable("realm_smtp_config");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmSmtpConfigs)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_70ej8xdxgxd0b9hh6180irr0o");
            });

            modelBuilder.Entity<RealmSupportedLocale>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Value })
                    .HasName("constr_realm_supported_locales");

                entity.ToTable("realm_supported_locales");

                entity.HasIndex(e => e.RealmId, "idx_realm_supp_local_realm");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RealmSupportedLocales)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supported_locales_realm");
            });

            modelBuilder.Entity<RedirectUri>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Value })
                    .HasName("constraint_redirect_uris");

                entity.ToTable("redirect_uris");

                entity.HasIndex(e => e.ClientId, "idx_redir_uri_client");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RedirectUris)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_1burs8pb4ouj97h5wuppahv9f");
            });

            modelBuilder.Entity<RequiredActionConfig>(entity =>
            {
                entity.HasKey(e => new { e.RequiredActionId, e.Name })
                    .HasName("constraint_req_act_cfg_pk");

                entity.ToTable("required_action_config");

                entity.Property(e => e.RequiredActionId)
                    .HasMaxLength(36)
                    .HasColumnName("required_action_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<RequiredActionProvider>(entity =>
            {
                entity.ToTable("required_action_provider");

                entity.HasIndex(e => e.RealmId, "idx_req_act_prov_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.DefaultAction).HasColumnName("default_action");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.RequiredActionProviders)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_req_act_realm");
            });

            modelBuilder.Entity<ResourceAttribute>(entity =>
            {
                entity.ToTable("resource_attribute");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'sybase-needs-something-here'::character varying");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceAttributes)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_5hrm2vlf9ql5fu022kqepovbr");
            });

            modelBuilder.Entity<ResourceServer>(entity =>
            {
                entity.ToTable("resource_server");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AllowRsRemoteMgmt).HasColumnName("allow_rs_remote_mgmt");

                entity.Property(e => e.DecisionStrategy)
                    .HasColumnName("decision_strategy")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PolicyEnforceMode).HasColumnName("policy_enforce_mode");
            });

            modelBuilder.Entity<ResourceServerPermTicket>(entity =>
            {
                entity.ToTable("resource_server_perm_ticket");

                entity.HasIndex(e => new { e.Owner, e.Requester, e.ResourceServerId, e.ResourceId, e.ScopeId }, "uk_frsr6t700s9v50bu18ws5pmt")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedTimestamp).HasColumnName("created_timestamp");

                entity.Property(e => e.GrantedTimestamp).HasColumnName("granted_timestamp");

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .HasColumnName("owner");

                entity.Property(e => e.PolicyId)
                    .HasMaxLength(36)
                    .HasColumnName("policy_id");

                entity.Property(e => e.Requester)
                    .HasMaxLength(255)
                    .HasColumnName("requester");

                entity.Property(e => e.ResourceId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_id");

                entity.Property(e => e.ResourceServerId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_server_id");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.ResourceServerPermTickets)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("fk_frsrpo2128cx4wnkog82ssrfy");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceServerPermTickets)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frsrho213xcx4wnkog83sspmt");

                entity.HasOne(d => d.ResourceServer)
                    .WithMany(p => p.ResourceServerPermTickets)
                    .HasForeignKey(d => d.ResourceServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frsrho213xcx4wnkog82sspmt");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.ResourceServerPermTickets)
                    .HasForeignKey(d => d.ScopeId)
                    .HasConstraintName("fk_frsrho213xcx4wnkog84sspmt");
            });

            modelBuilder.Entity<ResourceServerPolicy>(entity =>
            {
                entity.ToTable("resource_server_policy");

                entity.HasIndex(e => e.ResourceServerId, "idx_res_serv_pol_res_serv");

                entity.HasIndex(e => new { e.Name, e.ResourceServerId }, "uk_frsrpt700s9v50bu18ws5ha6")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.DecisionStrategy).HasColumnName("decision_strategy");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Logic).HasColumnName("logic");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .HasColumnName("owner");

                entity.Property(e => e.ResourceServerId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_server_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.HasOne(d => d.ResourceServer)
                    .WithMany(p => p.ResourceServerPolicies)
                    .HasForeignKey(d => d.ResourceServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frsrpo213xcx4wnkog82ssrfy");

                entity.HasMany(d => d.AssociatedPolicies)
                    .WithMany(p => p.Policies)
                    .UsingEntity<Dictionary<string, object>>(
                        "AssociatedPolicy",
                        l => l.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("AssociatedPolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsr5s213xcx4wnkog82ssrfy"),
                        r => r.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("PolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpas14xcx4wnkog82ssrfy"),
                        j =>
                        {
                            j.HasKey("PolicyId", "AssociatedPolicyId").HasName("constraint_farsrpap");

                            j.ToTable("associated_policy");

                            j.HasIndex(new[] { "AssociatedPolicyId" }, "idx_assoc_pol_assoc_pol_id");

                            j.IndexerProperty<string>("PolicyId").HasMaxLength(36).HasColumnName("policy_id");

                            j.IndexerProperty<string>("AssociatedPolicyId").HasMaxLength(36).HasColumnName("associated_policy_id");
                        });

                entity.HasMany(d => d.Policies)
                    .WithMany(p => p.AssociatedPolicies)
                    .UsingEntity<Dictionary<string, object>>(
                        "AssociatedPolicy",
                        l => l.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("PolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpas14xcx4wnkog82ssrfy"),
                        r => r.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("AssociatedPolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsr5s213xcx4wnkog82ssrfy"),
                        j =>
                        {
                            j.HasKey("PolicyId", "AssociatedPolicyId").HasName("constraint_farsrpap");

                            j.ToTable("associated_policy");

                            j.HasIndex(new[] { "AssociatedPolicyId" }, "idx_assoc_pol_assoc_pol_id");

                            j.IndexerProperty<string>("PolicyId").HasMaxLength(36).HasColumnName("policy_id");

                            j.IndexerProperty<string>("AssociatedPolicyId").HasMaxLength(36).HasColumnName("associated_policy_id");
                        });
            });

            modelBuilder.Entity<ResourceServerResource>(entity =>
            {
                entity.ToTable("resource_server_resource");

                entity.HasIndex(e => e.ResourceServerId, "idx_res_srv_res_res_srv");

                entity.HasIndex(e => new { e.Name, e.Owner, e.ResourceServerId }, "uk_frsr6t700s9v50bu18ws5ha6")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.IconUri)
                    .HasMaxLength(255)
                    .HasColumnName("icon_uri");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .HasColumnName("owner");

                entity.Property(e => e.OwnerManagedAccess).HasColumnName("owner_managed_access");

                entity.Property(e => e.ResourceServerId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_server_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.HasOne(d => d.ResourceServer)
                    .WithMany(p => p.ResourceServerResources)
                    .HasForeignKey(d => d.ResourceServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frsrho213xcx4wnkog82ssrfy");

                entity.HasMany(d => d.Policies)
                    .WithMany(p => p.Resources)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResourcePolicy",
                        l => l.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("PolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpp213xcx4wnkog82ssrfy"),
                        r => r.HasOne<ResourceServerResource>().WithMany().HasForeignKey("ResourceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpos53xcx4wnkog82ssrfy"),
                        j =>
                        {
                            j.HasKey("ResourceId", "PolicyId").HasName("constraint_farsrpp");

                            j.ToTable("resource_policy");

                            j.HasIndex(new[] { "PolicyId" }, "idx_res_policy_policy");

                            j.IndexerProperty<string>("ResourceId").HasMaxLength(36).HasColumnName("resource_id");

                            j.IndexerProperty<string>("PolicyId").HasMaxLength(36).HasColumnName("policy_id");
                        });

                entity.HasMany(d => d.Scopes)
                    .WithMany(p => p.Resources)
                    .UsingEntity<Dictionary<string, object>>(
                        "ResourceScope",
                        l => l.HasOne<ResourceServerScope>().WithMany().HasForeignKey("ScopeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrps213xcx4wnkog82ssrfy"),
                        r => r.HasOne<ResourceServerResource>().WithMany().HasForeignKey("ResourceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpos13xcx4wnkog82ssrfy"),
                        j =>
                        {
                            j.HasKey("ResourceId", "ScopeId").HasName("constraint_farsrsp");

                            j.ToTable("resource_scope");

                            j.HasIndex(new[] { "ScopeId" }, "idx_res_scope_scope");

                            j.IndexerProperty<string>("ResourceId").HasMaxLength(36).HasColumnName("resource_id");

                            j.IndexerProperty<string>("ScopeId").HasMaxLength(36).HasColumnName("scope_id");
                        });
            });

            modelBuilder.Entity<ResourceServerScope>(entity =>
            {
                entity.ToTable("resource_server_scope");

                entity.HasIndex(e => e.ResourceServerId, "idx_res_srv_scope_res_srv");

                entity.HasIndex(e => new { e.Name, e.ResourceServerId }, "uk_frsrst700s9v50bu18ws5ha6")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.IconUri)
                    .HasMaxLength(255)
                    .HasColumnName("icon_uri");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceServerId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_server_id");

                entity.HasOne(d => d.ResourceServer)
                    .WithMany(p => p.ResourceServerScopes)
                    .HasForeignKey(d => d.ResourceServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frsrso213xcx4wnkog82ssrfy");

                entity.HasMany(d => d.Policies)
                    .WithMany(p => p.Scopes)
                    .UsingEntity<Dictionary<string, object>>(
                        "ScopePolicy",
                        l => l.HasOne<ResourceServerPolicy>().WithMany().HasForeignKey("PolicyId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrasp13xcx4wnkog82ssrfy"),
                        r => r.HasOne<ResourceServerScope>().WithMany().HasForeignKey("ScopeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fk_frsrpass3xcx4wnkog82ssrfy"),
                        j =>
                        {
                            j.HasKey("ScopeId", "PolicyId").HasName("constraint_farsrsps");

                            j.ToTable("scope_policy");

                            j.HasIndex(new[] { "PolicyId" }, "idx_scope_policy_policy");

                            j.IndexerProperty<string>("ScopeId").HasMaxLength(36).HasColumnName("scope_id");

                            j.IndexerProperty<string>("PolicyId").HasMaxLength(36).HasColumnName("policy_id");
                        });
            });

            modelBuilder.Entity<ResourceUri>(entity =>
            {
                entity.HasKey(e => new { e.ResourceId, e.Value })
                    .HasName("constraint_resour_uris_pk");

                entity.ToTable("resource_uris");

                entity.Property(e => e.ResourceId)
                    .HasMaxLength(36)
                    .HasColumnName("resource_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceUris)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_resource_server_uris");
            });

            modelBuilder.Entity<RoleAttribute>(entity =>
            {
                entity.ToTable("role_attribute");

                entity.HasIndex(e => e.RoleId, "idx_role_attribute");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAttributes)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_role_attribute_id");
            });

            modelBuilder.Entity<ScopeMapping>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.RoleId })
                    .HasName("constraint_81");

                entity.ToTable("scope_mapping");

                entity.HasIndex(e => e.RoleId, "idx_scope_mapping_role");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ScopeMappings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ouse064plmlr732lxjcn1q5f1");
            });

            modelBuilder.Entity<UserAttribute>(entity =>
            {
                entity.ToTable("user_attribute");

                entity.HasIndex(e => e.UserId, "idx_user_attribute");

                entity.HasIndex(e => new { e.Name, e.Value }, "idx_user_attribute_name");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'sybase-needs-something-here'::character varying");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAttributes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_5hrm2vlf9ql5fu043kqepovbr");
            });

            modelBuilder.Entity<UserConsent>(entity =>
            {
                entity.ToTable("user_consent");

                entity.HasIndex(e => e.UserId, "idx_user_consent");

                entity.HasIndex(e => new { e.ClientId, e.ClientStorageProvider, e.ExternalClientId, e.UserId }, "uk_jkuwuvd56ontgsuhogm8uewrt")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientStorageProvider)
                    .HasMaxLength(36)
                    .HasColumnName("client_storage_provider");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ExternalClientId)
                    .HasMaxLength(255)
                    .HasColumnName("external_client_id");

                entity.Property(e => e.LastUpdatedDate).HasColumnName("last_updated_date");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserConsents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grntcsnt_user");
            });

            modelBuilder.Entity<UserConsentClientScope>(entity =>
            {
                entity.HasKey(e => new { e.UserConsentId, e.ScopeId })
                    .HasName("constraint_grntcsnt_clsc_pm");

                entity.ToTable("user_consent_client_scope");

                entity.HasIndex(e => e.UserConsentId, "idx_usconsent_clscope");

                entity.Property(e => e.UserConsentId)
                    .HasMaxLength(36)
                    .HasColumnName("user_consent_id");

                entity.Property(e => e.ScopeId)
                    .HasMaxLength(36)
                    .HasColumnName("scope_id");

                entity.HasOne(d => d.UserConsent)
                    .WithMany(p => p.UserConsentClientScopes)
                    .HasForeignKey(d => d.UserConsentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grntcsnt_clsc_usc");
            });

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("user_entity");

                entity.HasIndex(e => e.Email, "idx_user_email");

                entity.HasIndex(e => new { e.RealmId, e.ServiceAccountClientLink }, "idx_user_service_account");

                entity.HasIndex(e => new { e.RealmId, e.EmailConstraint }, "uk_dykn684sl8up1crfei6eckhd7")
                    .IsUnique();

                entity.HasIndex(e => new { e.RealmId, e.Username }, "uk_ru8tt6t700s9v50bu18ws5ha6")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.CreatedTimestamp).HasColumnName("created_timestamp");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailConstraint)
                    .HasMaxLength(255)
                    .HasColumnName("email_constraint");

                entity.Property(e => e.EmailVerified).HasColumnName("email_verified");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FederationLink)
                    .HasMaxLength(255)
                    .HasColumnName("federation_link");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.NotBefore).HasColumnName("not_before");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.ServiceAccountClientLink)
                    .HasMaxLength(255)
                    .HasColumnName("service_account_client_link");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserFederationConfig>(entity =>
            {
                entity.HasKey(e => new { e.UserFederationProviderId, e.Name })
                    .HasName("constraint_f9");

                entity.ToTable("user_federation_config");

                entity.Property(e => e.UserFederationProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("user_federation_provider_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.UserFederationProvider)
                    .WithMany(p => p.UserFederationConfigs)
                    .HasForeignKey(d => d.UserFederationProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_t13hpu1j94r2ebpekr39x5eu5");
            });

            modelBuilder.Entity<UserFederationMapper>(entity =>
            {
                entity.ToTable("user_federation_mapper");

                entity.HasIndex(e => e.FederationProviderId, "idx_usr_fed_map_fed_prv");

                entity.HasIndex(e => e.RealmId, "idx_usr_fed_map_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.FederationMapperType)
                    .HasMaxLength(255)
                    .HasColumnName("federation_mapper_type");

                entity.Property(e => e.FederationProviderId)
                    .HasMaxLength(36)
                    .HasColumnName("federation_provider_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.FederationProvider)
                    .WithMany(p => p.UserFederationMappers)
                    .HasForeignKey(d => d.FederationProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fedmapperpm_fedprv");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.UserFederationMappers)
                    .HasForeignKey(d => d.RealmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fedmapperpm_realm");
            });

            modelBuilder.Entity<UserFederationMapperConfig>(entity =>
            {
                entity.HasKey(e => new { e.UserFederationMapperId, e.Name })
                    .HasName("constraint_fedmapper_cfg_pm");

                entity.ToTable("user_federation_mapper_config");

                entity.Property(e => e.UserFederationMapperId)
                    .HasMaxLength(36)
                    .HasColumnName("user_federation_mapper_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.UserFederationMapper)
                    .WithMany(p => p.UserFederationMapperConfigs)
                    .HasForeignKey(d => d.UserFederationMapperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fedmapper_cfg");
            });

            modelBuilder.Entity<UserFederationProvider>(entity =>
            {
                entity.ToTable("user_federation_provider");

                entity.HasIndex(e => e.RealmId, "idx_usr_fed_prv_realm");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.ChangedSyncPeriod).HasColumnName("changed_sync_period");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.FullSyncPeriod).HasColumnName("full_sync_period");

                entity.Property(e => e.LastSync).HasColumnName("last_sync");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.HasOne(d => d.Realm)
                    .WithMany(p => p.UserFederationProviders)
                    .HasForeignKey(d => d.RealmId)
                    .HasConstraintName("fk_1fj32f6ptolw2qy60cd8n01e8");
            });

            modelBuilder.Entity<UserGroupMembership>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId })
                    .HasName("constraint_user_group");

                entity.ToTable("user_group_membership");

                entity.HasIndex(e => e.UserId, "idx_user_group_mapping");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("group_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroupMemberships)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_group_user");
            });

            modelBuilder.Entity<UserRequiredAction>(entity =>
            {
                entity.HasKey(e => new { e.RequiredAction, e.UserId })
                    .HasName("constraint_required_action");

                entity.ToTable("user_required_action");

                entity.HasIndex(e => e.UserId, "idx_user_reqactions");

                entity.Property(e => e.RequiredAction)
                    .HasMaxLength(255)
                    .HasColumnName("required_action")
                    .HasDefaultValueSql("' '::character varying");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRequiredActions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_6qj3w1jw9cvafhe19bwsiuvmd");
            });

            modelBuilder.Entity<UserRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("constraint_c");

                entity.ToTable("user_role_mapping");

                entity.HasIndex(e => e.UserId, "idx_user_role_mapping");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(255)
                    .HasColumnName("role_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleMappings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_c4fqv34p1mbylloxang7b1q3l");
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.ToTable("user_session");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.AuthMethod)
                    .HasMaxLength(255)
                    .HasColumnName("auth_method");

                entity.Property(e => e.BrokerSessionId)
                    .HasMaxLength(255)
                    .HasColumnName("broker_session_id");

                entity.Property(e => e.BrokerUserId)
                    .HasMaxLength(255)
                    .HasColumnName("broker_user_id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(255)
                    .HasColumnName("ip_address");

                entity.Property(e => e.LastSessionRefresh).HasColumnName("last_session_refresh");

                entity.Property(e => e.LoginUsername)
                    .HasMaxLength(255)
                    .HasColumnName("login_username");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(255)
                    .HasColumnName("realm_id");

                entity.Property(e => e.RememberMe).HasColumnName("remember_me");

                entity.Property(e => e.Started).HasColumnName("started");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id");

                entity.Property(e => e.UserSessionState).HasColumnName("user_session_state");
            });

            modelBuilder.Entity<UserSessionNote>(entity =>
            {
                entity.HasKey(e => new { e.UserSession, e.Name })
                    .HasName("constraint_usn_pk");

                entity.ToTable("user_session_note");

                entity.Property(e => e.UserSession)
                    .HasMaxLength(36)
                    .HasColumnName("user_session");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(2048)
                    .HasColumnName("value");

                entity.HasOne(d => d.UserSessionNavigation)
                    .WithMany(p => p.UserSessionNotes)
                    .HasForeignKey(d => d.UserSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk5edfb00ff51d3472");
            });

            modelBuilder.Entity<UsernameLoginFailure>(entity =>
            {
                entity.HasKey(e => new { e.RealmId, e.Username })
                    .HasName("CONSTRAINT_17-2");

                entity.ToTable("username_login_failure");

                entity.Property(e => e.RealmId)
                    .HasMaxLength(36)
                    .HasColumnName("realm_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.FailedLoginNotBefore).HasColumnName("failed_login_not_before");

                entity.Property(e => e.LastFailure).HasColumnName("last_failure");

                entity.Property(e => e.LastIpFailure)
                    .HasMaxLength(255)
                    .HasColumnName("last_ip_failure");

                entity.Property(e => e.NumFailures).HasColumnName("num_failures");
            });

            modelBuilder.Entity<WebOrigin>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Value })
                    .HasName("constraint_web_origins");

                entity.ToTable("web_origins");

                entity.HasIndex(e => e.ClientId, "idx_web_orig_client");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(36)
                    .HasColumnName("client_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WebOrigins)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lojpho213xcx4wnkog82ssrfy");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
