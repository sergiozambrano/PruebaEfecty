using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesRest.Application.Dto
{
    public class ResponseDto<T>
    {
        public bool IsSuccess { get; set; } = false;
        public List<T> Data { get; set; }
        public string? Message { get; set; }
        public string? MessageEx { get; set; }
    }
}
