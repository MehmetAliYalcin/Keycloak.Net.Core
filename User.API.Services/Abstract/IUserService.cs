using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.API.Models.DTOs;

namespace User.API.Services.Abstract
{
    public interface IUserService
    {
        Task<ResponseDto> DeleteUserAsync(string userId);

        Task<ResponseDtoWithData> LoginUserAsync(UserLoginDto loginDto);

        Task<ResponseDtoWithData> AddUserAsync(CreateUserDto user);

        Task<ResponseDtoWithData> UpdateUserAsync(UpdateUserDto updateUserDto);
    }
}
