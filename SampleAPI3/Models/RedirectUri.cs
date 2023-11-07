using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class RedirectUri
    {
        public string ClientId { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;
    }
}
