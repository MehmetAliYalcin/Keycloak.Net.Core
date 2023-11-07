using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class UserRequiredAction
    {
        public string UserId { get; set; } = null!;
        public string RequiredAction { get; set; } = null!;

        public virtual UserEntity User { get; set; } = null!;
    }
}
