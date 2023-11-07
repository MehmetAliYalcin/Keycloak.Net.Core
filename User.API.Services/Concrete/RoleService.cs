using Keycloak.Net;
using Keycloak.Net.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.API.Services.Abstract;

namespace User.API.Services.Concrete
{
    public class RoleService :IRoleService
    {
        private readonly KeycloakClient _keycloakClient;

        public RoleService(KeycloakClient keycloakClient)
        {
            _keycloakClient = keycloakClient ?? throw new ArgumentNullException(nameof(keycloakClient));
        }

        public async Task<IEnumerable<Role>> GetRolessAsync( CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.GetRolessAsync(cancellationToken);
        }

        public async Task<Role> GetRoleByName(  string search = null, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.GetRoleByName( search, cancellationToken);
        }

        public async Task<bool> DeleteRoleByNameAsync(string roleName, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.DeleteRoleByNameAsync(roleName, cancellationToken);
        }

        public async Task<bool> UpdateRoleByNameAsync(string roleName, Role role, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.UpdateRoleByNameAsync(roleName, role,cancellationToken);
        }

        public async Task<bool> CreateRoleAsync( Role role, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.CreateRoleAsync(role, cancellationToken);
        }

        public async Task<IEnumerable<Role>> GetRealmRoleMappingsForUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.GetRealmRoleMappingsForUserAsync(userId, cancellationToken);
        }

        public async Task<bool> AddRealmRoleMappingsToUserAsync(string userId, string roles, CancellationToken cancellationToken = default)
        {
            return await _keycloakClient.AddRealmRoleMappingsToUserAsync(userId,roles, cancellationToken);
        }
    }
}
