using EcommercApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercApi.Services
{
    public interface IAuthenticationManager
    {
        string GenerateJsonToken(UserModel model);
    }
}
