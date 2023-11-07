using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserRoleMapping
    {
        public string RoleId { get; set; } = null!;
        public string UserId { get; set; } = null!;

        public virtual UserEntity User { get; set; } = null!;
    }
}
