using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.API.Models.DTOs
{
    public class Credential
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public bool Temporary { get; set; }
    }
}
