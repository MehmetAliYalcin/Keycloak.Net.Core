﻿using System;
using System.Collections.Generic;

namespace SampleAPI3.Models
{
    public partial class FedUserRequiredAction
    {
        public string RequiredAction { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string RealmId { get; set; } = null!;
        public string? StorageProviderId { get; set; }
    }
}
