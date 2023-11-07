using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.API.Models.DTOs
{
    public class ResponseDtoWithData  : ResponseDto
    {
        public object? Data { get; set; }
    }
}
