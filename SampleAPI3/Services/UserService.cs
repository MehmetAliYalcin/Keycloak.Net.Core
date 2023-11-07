using Keycloak.Net;
using Keycloak.Net.Models.Users;
using Newtonsoft.Json;

namespace SampleAPI3.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        //private readonly KeycloakClient _keycloakClient;

        private const string BaseUrl = "http://localhost:8080/admin/realms/sample/users";

        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
           // _keycloakClient = keycloakClient;
            //_httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJNbk5kd1V2cUd5Ql9YdDJkNzMxZTdZX3BVNE1DdEFIMjRneHhnUGRleGJzIn0.eyJleHAiOjE2OTkwMTM1NDcsImlhdCI6MTY5OTAxMzI0NywianRpIjoiODFjYTFmN2UtYTlkZi00ZTI1LWI4OGItOWQ5Yjk2ZTgwMWU3IiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo4MDgwL3JlYWxtcy9zYW1wbGUiLCJhdWQiOiJhY2NvdW50Iiwic3ViIjoiZTUyMWVmYzUtYWZkZS00ZjMzLWFkOWYtMTc2NzI2ZWExZTcyIiwidHlwIjoiQmVhcmVyIiwiYXpwIjoidGhpcmRDbGllbnQiLCJzZXNzaW9uX3N0YXRlIjoiOGFhNGRkNjctNGM4YS00ZWU1LTkxMmItZDUxZTg1ZWRiNTM2IiwiYWNyIjoiMSIsImFsbG93ZWQtb3JpZ2lucyI6WyIvKiJdLCJyZWFsbV9hY2Nlc3MiOnsicm9sZXMiOlsiZGVmYXVsdC1yb2xlcy1zYW1wbGUiLCJvZmZsaW5lX2FjY2VzcyIsImFkbWluIiwidW1hX2F1dGhvcml6YXRpb24iXX0sInJlc291cmNlX2FjY2VzcyI6eyJhY2NvdW50Ijp7InJvbGVzIjpbIm1hbmFnZS1hY2NvdW50IiwibWFuYWdlLWFjY291bnQtbGlua3MiLCJ2aWV3LXByb2ZpbGUiXX19LCJzY29wZSI6InByb2ZpbGUgZW1haWwiLCJzaWQiOiI4YWE0ZGQ2Ny00YzhhLTRlZTUtOTEyYi1kNTFlODVlZGI1MzYiLCJlbWFpbF92ZXJpZmllZCI6ZmFsc2UsIm5hbWUiOiJlcnR1Z3J1bCBlcnR1Z3J1bCIsInByZWZlcnJlZF91c2VybmFtZSI6ImVydHVncnVsNTQ2MSIsImdpdmVuX25hbWUiOiJlcnR1Z3J1bCIsImZhbWlseV9uYW1lIjoiZXJ0dWdydWwiLCJlbWFpbCI6ImVydHVncnVsbGF5ZGluY0BnbWFpbC5jb20ifQ.eQ64_XhbQw-lIKMHay-sVth8CK_B4wsh5JOllFKwe9nvwrmAVP-RmaZTRe2EO78hm-sWiO1ap3uzhWBVxqBhAPHK-AtlK8ypb5lYH3tPGCMVdCeAFl-7Lp6XDSnooi_ENgEUJHGTsUz7Lsp8iXpeHDJYMDpCY-RFj44nkm2Mpi6IB6KEDSz4O3ouTN1zLuMY2cXwRQprXa9qZpSBn3e31-sRduhTpbsMkGQMFJ2BNCaIo1o9K9nF24mVjaINLvWf3AygLzLFNikDkIi4L1ew_SQH5JMv-omTac0_PWb2vTU0IMzR7YSSwfKjmUkOLWvFfjaUGlPGrwJZqSCxXvOWqQ");

        }
        public async Task<bool> DeleteUserAsync(string userId)
        {
            //_httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJNbk5kd1V2cUd5Ql9YdDJkNzMxZTdZX3BVNE1DdEFIMjRneHhnUGRleGJzIn0.eyJleHAiOjE2OTkyNTM2MTMsImlhdCI6MTY5OTI1MzMxMywianRpIjoiZGM4NWQ3NDQtZTZlNy00YjI1LTljYTQtNmQ3YThhMDRhNDY5IiwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo4MDgwL3JlYWxtcy9zYW1wbGUiLCJhdWQiOlsicmVhbG0tbWFuYWdlbWVudCIsImZpcnN0Q2xpZW50IiwiYnJva2VyIiwiYWNjb3VudCJdLCJzdWIiOiJlNTIxZWZjNS1hZmRlLTRmMzMtYWQ5Zi0xNzY3MjZlYTFlNzIiLCJ0eXAiOiJCZWFyZXIiLCJhenAiOiJ0aGlyZENsaWVudCIsInNlc3Npb25fc3RhdGUiOiI4Zjg4NWUxYi1jZmM2LTQ2ZmYtYjNlNy1jY2Y1ZTk5YWZmYTYiLCJhY3IiOiIxIiwiYWxsb3dlZC1vcmlnaW5zIjpbIi8qIl0sInJlYWxtX2FjY2VzcyI6eyJyb2xlcyI6WyJkZWZhdWx0LXJvbGVzLXNhbXBsZSIsInJlYWxtLW1hbmFnZW1lbnQiLCJyZWFsbS1hZG1pbiIsIm9mZmxpbmVfYWNjZXNzIiwiYWRtaW4iLCJkZXZlbG9wZXIiLCJ1bWFfYXV0aG9yaXphdGlvbiJdfSwicmVzb3VyY2VfYWNjZXNzIjp7InJlYWxtLW1hbmFnZW1lbnQiOnsicm9sZXMiOlsidmlldy1yZWFsbSIsInZpZXctaWRlbnRpdHktcHJvdmlkZXJzIiwibWFuYWdlLWlkZW50aXR5LXByb3ZpZGVycyIsImltcGVyc29uYXRpb24iLCJyZWFsbS1hZG1pbiIsImNyZWF0ZS1jbGllbnQiLCJtYW5hZ2UtdXNlcnMiLCJxdWVyeS1yZWFsbXMiLCJ2aWV3LWF1dGhvcml6YXRpb24iLCJxdWVyeS1jbGllbnRzIiwicXVlcnktdXNlcnMiLCJtYW5hZ2UtZXZlbnRzIiwibWFuYWdlLXJlYWxtIiwidmlldy1ldmVudHMiLCJ2aWV3LXVzZXJzIiwidmlldy1jbGllbnRzIiwibWFuYWdlLWF1dGhvcml6YXRpb24iLCJtYW5hZ2UtY2xpZW50cyIsInF1ZXJ5LWdyb3VwcyJdfSwiZmlyc3RDbGllbnQiOnsicm9sZXMiOlsidW1hX3Byb3RlY3Rpb24iLCJkZXZlbG9wZXIiXX0sImJyb2tlciI6eyJyb2xlcyI6WyJyZWFkLXRva2VuIl19LCJhY2NvdW50Ijp7InJvbGVzIjpbIm1hbmFnZS1hY2NvdW50Iiwidmlldy1hcHBsaWNhdGlvbnMiLCJ2aWV3LWNvbnNlbnQiLCJ2aWV3LWdyb3VwcyIsIm1hbmFnZS1hY2NvdW50LWxpbmtzIiwibWFuYWdlLWNvbnNlbnQiLCJkZWxldGUtYWNjb3VudCIsInZpZXctcHJvZmlsZSJdfX0sInNjb3BlIjoicHJvZmlsZSBlbWFpbCIsInNpZCI6IjhmODg1ZTFiLWNmYzYtNDZmZi1iM2U3LWNjZjVlOTlhZmZhNiIsImVtYWlsX3ZlcmlmaWVkIjpmYWxzZSwibmFtZSI6ImVydHVncnVsIGVydHVncnVsIiwicHJlZmVycmVkX3VzZXJuYW1lIjoiZXJ0dWdydWw1NDYxIiwiZ2l2ZW5fbmFtZSI6ImVydHVncnVsIiwiZmFtaWx5X25hbWUiOiJlcnR1Z3J1bCIsImVtYWlsIjoiZXJ0dWdydWxsYXlkaW5jQGdtYWlsLmNvbSJ9.Bxc3kMeSccp9eGYZHKVXlPZygLJt-n4UdGN_KElJsiXGggi1gX1FsdZK3a3zVmd8k9Mh2cD4eu2ckHOPxarm30DdXF7awYDLHUNofzCSe4zAIyvnIWOsl_uHdbugFm3KXY_8LrcoTT0WIF7JlmqGDQZ7wpPSFVlBH77SIJhGCsLmqD4Ys5Evmvy1KXO6QglRuu9-ixHD4ODFAE84J_gmIGHz8uJiTYssoUXQhZ3DuNw2OOq8Tg-HEKO8xBvOmdGmE_axxdAIIGtxWFGr4XlQPhmJqP3sACSmsjhcpefvt-J0Mr7hIRFgTXYgn5F2ewJgs_ZHUrHKfzEkyb5tYFv04w");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"{_httpContextAccessor.HttpContext?.Request.Headers["Authorization"]}");
            //var x = await _httpClient.GetAsync($"{BaseUrl}/{userId}");
            //var myModel = JsonConvert.DeserializeObject<User>(x.Content.Headers.ToString());
            //var user = await _keycloakClient.GetUserAsync("sample", userId);

            HttpResponseMessage response = await _httpClient.DeleteAsync($"{BaseUrl}/{userId}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            Console.WriteLine($"Error: {response.StatusCode}");
            return false;
            
        }

    }
}
