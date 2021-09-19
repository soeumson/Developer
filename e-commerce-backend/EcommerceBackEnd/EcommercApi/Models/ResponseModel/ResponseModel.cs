using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercApi.Models.ResponseModel
{
    public class ResponseModel<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
    public class ResponseModelSingle<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
    public class AuthorizeModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
}
