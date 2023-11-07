using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.API.Models.DTOs
{
    public class CreateUserDto
    {

        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        //public string Password { get; set; } = null!;

        //[Compare("Password")]
        //public string ConfirmPassword { get; set; } = null!;

        [JsonProperty("attributes")]
        public Dictionary<string, IEnumerable<string>>? Attributes { get; set; } = null;

        [JsonProperty("groups")]
        public IEnumerable<string>? Groups { get; set; } = null;


    }
}
