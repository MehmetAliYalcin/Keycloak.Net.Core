using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using User.API.Models.DTOs;
using User.API.Services.Abstract;

namespace User.API.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;

        public UserService(HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ResponseDtoWithData> AddUserAsync(CreateUserDto createUserDto)
        {

            HttpContent content = new StringContent(JsonConvert.SerializeObject(createUserDto), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{_httpContextAccessor.HttpContext.Request.Headers["Authorization"]}");

            HttpResponseMessage response = await _httpClient.PostAsync($"{_configuration["AdminBaseUrl"]}/realms/deneme/users", content);

            if (response.IsSuccessStatusCode)
                return new()
                {
                    IsSuccess = true,
                    Message = "User created successfully",
                    StatusCode = 201,
                    Data = createUserDto
                };

            return new()
            {
                IsSuccess = false,
                Message = "An error occured when trying create user",
                StatusCode = 400,
                Data = null
            };
        }

        public async Task<ResponseDto> DeleteUserAsync(string userId)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{_httpContextAccessor.HttpContext?.Request.Headers["Authorization"]}");
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{_configuration["AdminBaseUrl"]}/realms/deneme/users/{userId}");

            if (response.IsSuccessStatusCode)
                return new ResponseDto
                {
                    IsSuccess = true,
                    Message = "User deleted successfully",
                    StatusCode = 204
                };

            return new ResponseDto
            {
                IsSuccess = false,
                Message = "An error occured when deleting the user",
                StatusCode = 400
            };


        }

        public async Task<ResponseDtoWithData> LoginUserAsync(UserLoginDto loginDto)
        {
            var client = _httpClientFactory.CreateClient("127.0.0.1");

            var requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("client_id",_configuration["Client:Id"]),
                new KeyValuePair<string, string>("client_secret", _configuration["Client:Secret"]),
                new KeyValuePair<string, string>("username", loginDto.Username),
                new KeyValuePair<string, string>("password", loginDto.Password),
                new KeyValuePair<string, string>("scope","openid")
            });

            var response = await client.PostAsync($"{_configuration["BaseUrl"]}/realms/deneme/protocol/openid-connect/token", requestContent);

            if (response.IsSuccessStatusCode)
            {

                var token = await response.Content.ReadAsStringAsync();
                return new ResponseDtoWithData
                {
                    IsSuccess = true,
                    Message = "Token created successfully",
                    StatusCode = (int)response.StatusCode,
                    Data = token.ToString()
                };
            }
            else
            {
                return new()
                {
                    IsSuccess = false,
                    Message = "Error retrieving access token",
                    StatusCode = (int)response.StatusCode,
                    Data = null
                };
                // Handle error cases
                //return StatusCode((int)response.StatusCode, "Error retrieving access token");
            }
        }

        public async Task<ResponseDtoWithData> UpdateUserAsync(UpdateUserDto updateUserDto)
        {
            HttpContent content = new StringContent(JsonConvert.SerializeObject(updateUserDto), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{_httpContextAccessor.HttpContext.Request.Headers["Authorization"]}");

            HttpResponseMessage response = await _httpClient.PutAsync($"{_configuration["AdminBaseUrl"]}/realms/deneme/users/{updateUserDto.Id}", content);

            if (response.IsSuccessStatusCode)
                return new()
                {
                    IsSuccess = true,
                    Message = "User created successfully",
                    StatusCode = 201,
                    Data = updateUserDto
                };

            return new()
            {
                IsSuccess = false,
                Message = "An error occured when trying create user",
                StatusCode = 400,
                Data = null
            };
        }
    }
}
