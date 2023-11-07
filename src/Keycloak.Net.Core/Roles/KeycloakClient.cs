using Flurl.Http;
using Keycloak.Net.Models.Clients;
using Keycloak.Net.Models.Common;
using Keycloak.Net.Models.Groups;
using Keycloak.Net.Models.RealmsAdmin;
using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Keycloak.Net
{
    public partial class KeycloakClient
    {
        public async Task<bool> CreateRoleAsync( Role role, CancellationToken cancellationToken = default)
        {
                        
            var response = await GetBaseUrl("deneme")
                .AppendPathSegment($"/admin/realms/deneme/clients/4be8f005-6820-40d2-84ce-1dd23c08ebd2/roles")
                .PostJsonAsync(role, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }
        public async Task<IEnumerable<Role>> GetRolessAsync( CancellationToken cancellationToken = default)
        {
            
            return await GetBaseUrl("deneme")
                .AppendPathSegment($"/admin/realms/deneme/roles")
                .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
                .ConfigureAwait(false);
        }

        
        public async Task<Role> GetRoleByName( string search = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
              [nameof(search)] = search
            };
       
            return await GetBaseUrl("deneme")
                .AppendPathSegment($"/admin/realms/deneme/clients/4be8f005-6820-40d2-84ce-1dd23c08ebd2/roles/{search}")
                .SetQueryParams(queryParams)
                .GetJsonAsync<Role>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<Role> GetRoleByNameAsync(string realm, string clientId, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}")
            .GetJsonAsync<Role>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRoleByNameAsync(string roleName, Role role, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl("deneme")
                .AppendPathSegment($"/admin/realms/deneme/clients/4be8f005-6820-40d2-84ce-1dd23c08ebd2/roles/{roleName}")
                .PutJsonAsync(role, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRoleByNameAsync(string realm, string clientId, string roleName, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> AddCompositesToRoleAsync(string realm, string clientId, string roleName, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/composites")
                .PostJsonAsync(roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRoleCompositesAsync(string realm, string clientId, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/composites")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> RemoveCompositesFromRoleAsync(string realm, string clientId, string roleName, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/composites")
                .SendJsonAsync(HttpMethod.Delete, roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetApplicationRolesForCompositeAsync(string realm, string clientId, string roleName, string forClientId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/composites/clients/{forClientId}")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetRealmRolesForCompositeAsync(string realm, string clientId, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/composites/realm")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        [Obsolete("Not working yet")]
        public async Task<IEnumerable<Group>> GetGroupsWithRoleNameAsync(string realm, string clientId, string roleName, int? first = null, bool? full = null, int? max = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(first)] = first,
                [nameof(full)] = full,
                [nameof(max)] = max
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/groups")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Group>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<ManagementPermission> GetRoleAuthorizationPermissionsInitializedAsync(string realm, string clientId, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/management/permissions")
            .GetJsonAsync<ManagementPermission>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<ManagementPermission> SetRoleAuthorizationPermissionsInitializedAsync(string realm, string clientId, string roleName, ManagementPermission managementPermission, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/management/permissions")
            .PutJsonAsync(managementPermission, cancellationToken)
            .ReceiveJson<ManagementPermission>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<User>> GetUsersWithRoleNameAsync(string realm, string clientId, string roleName, int? first = null, int? max = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(first)] = first,
                [nameof(max)] = max
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/clients/{clientId}/roles/{roleName}/users")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<User>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<bool> CreateRoleAsync(string realm, Role role, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles")
                .PostJsonAsync(role, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync(string realm, string clientId,int? first = null, int? max = null, string search = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(first)] = first,
                [nameof(max)] = max,
                [nameof(search)] = search
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<Role> GetRoleByNameAsync(string realm, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}")
            .GetJsonAsync<Role>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> UpdateRoleByNameAsync(string realm, string roleName, Role role, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}")
                .PutJsonAsync(role, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteRoleByNameAsync(string roleName, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl("deneme")
                .AppendPathSegment($"/admin/realms/deneme/roles/{roleName}")
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> AddCompositesToRoleAsync(string realm, string roleName, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/composites")
                .PostJsonAsync(roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetRoleCompositesAsync(string realm, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/composites")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<bool> RemoveCompositesFromRoleAsync(string realm, string roleName, IEnumerable<Role> roles, CancellationToken cancellationToken = default)
        {
            var response = await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/composites")
                .SendJsonAsync(HttpMethod.Delete, roles, cancellationToken)
                .ConfigureAwait(false);
            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Role>> GetApplicationRolesForCompositeAsync(string realm, string roleName, string forClientId, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/composites/clients/{forClientId}")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<IEnumerable<Role>> GetRealmRolesForCompositeAsync(string realm, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/composites/realm")
            .GetJsonAsync<IEnumerable<Role>>(cancellationToken)
            .ConfigureAwait(false);

        [Obsolete("Not working yet")]
        public async Task<IEnumerable<Group>> GetGroupsWithRoleNameAsync(string realm, string roleName, int? first = null, bool? full = null, int? max = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(first)] = first,
                [nameof(full)] = full,
                [nameof(max)] = max
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/groups")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<Group>>(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<ManagementPermission> GetRoleAuthorizationPermissionsInitializedAsync(string realm, string roleName, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/management/permissions")
            .GetJsonAsync<ManagementPermission>(cancellationToken)
            .ConfigureAwait(false);

        public async Task<ManagementPermission> SetRoleAuthorizationPermissionsInitializedAsync(string realm, string roleName, ManagementPermission managementPermission, CancellationToken cancellationToken = default) => await GetBaseUrl(realm)
            .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/management/permissions")
            .PutJsonAsync(managementPermission, cancellationToken)
            .ReceiveJson<ManagementPermission>()
            .ConfigureAwait(false);

        public async Task<IEnumerable<User>> GetUsersWithRoleNameAsync(string realm, string roleName, int? first = null, int? max = null, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, object>
            {
                [nameof(first)] = first,
                [nameof(max)] = max
            };

            return await GetBaseUrl(realm)
                .AppendPathSegment($"/admin/realms/{realm}/roles/{roleName}/users")
                .SetQueryParams(queryParams)
                .GetJsonAsync<IEnumerable<User>>(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
