using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserAttribute
    {
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public string UserId { get; set; } = null!;
        public string Id { get; set; } = null!;

        public virtual UserEntity User { get; set; } = null!;
    }
}
