using Keycloak.Net.Models.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.API.Models.DTOs;
using User.API.Services.Abstract;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetRoleByName")]
        public async Task<IActionResult> GetRoleByName(  string search = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.GetRoleByName(  search, cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("GetRoleAttrebutesByRoleName")]
        public async Task<IActionResult> GetRoleAttrebutesByRoleName(string search = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.GetRoleByName(search, cancellationToken);
                return Ok(roles.Attributes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpGet("GetRealmRoleMappingsForUserAsync")]
        public async Task<IActionResult> GetRealmRoleMappingsForUserAsync(string userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.GetRealmRoleMappingsForUserAsync(userId, cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("getRoles")]
        public async Task<IActionResult> GetRolesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.GetRolessAsync( cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(Role role,CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.CreateRoleAsync(role,cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost("AddRealmRoleMappingsToUserAsync")]
        public async Task<IActionResult> AddRealmRoleMappingsToUserAsync(string userId, string roles, CancellationToken cancellationToken = default)
        {
            try
            {
                var roless = await _roleService.AddRealmRoleMappingsToUserAsync(userId,roles, cancellationToken);
                return Ok(roless);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpDelete("deleteRoles")]
        public async Task<IActionResult> DeleteRoleByNameAsync(string roleName,CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.DeleteRoleByNameAsync(roleName,cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
        [HttpPut("updateRoles")]
        public async Task<IActionResult> UpdateRoleByNameAsync(string roleName, Role role,CancellationToken cancellationToken = default)
        {
            try
            {
                var roles = await _roleService.DeleteRoleByNameAsync(roleName, cancellationToken);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
