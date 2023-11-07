using Keycloak.Net.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.API.Models.DTOs;

namespace User.API.Services.Abstract
{
    public interface IRoleService
    {
        Task<Role> GetRoleByName(  string search = null, CancellationToken cancellationToken = default);
        Task<IEnumerable<Role>> GetRolessAsync(CancellationToken cancellationToken = default);
        Task<bool> DeleteRoleByNameAsync(string roleName, CancellationToken cancellationToken = default);
        Task<bool> UpdateRoleByNameAsync(string roleName, Role role, CancellationToken cancellationToken = default);
        Task<bool> CreateRoleAsync( Role role, CancellationToken cancellationToken = default);
        Task<IEnumerable<Role>> GetRealmRoleMappingsForUserAsync(string userId, CancellationToken cancellationToken = default);
        Task<bool> AddRealmRoleMappingsToUserAsync(string userId, string roleName, CancellationToken cancellationToken = default);
    }
}
