using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EcommerceBackEnd.Extension
{
    public static class ExtensionMethods
    {
        public static string Protection(this string message)
        {
            IDataProtector protector;
            protector = DataProtectionProvider.Create("EcommerceBackEnd").CreateProtector("RouteValue");
            message = protector.Protect(message);
            return message;
        }
        public static string UnProtection(this string message)
        {
            IDataProtector protector;
            protector = DataProtectionProvider.Create("EcommerceBackEnd").CreateProtector("RouteValue");
            message = protector.Unprotect(message);
            return message;
        }
    }
}
