using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.ViewModels
{
    public class UserClaimViewModel: IdentityUserClaim<string>
    {
        public string Encryted { get; set; }
        public string[] AccessRight { get; set; }
    }
    public class RoleClaimViewModel : IdentityRoleClaim<string>
    {
        public string Encryted { get; set; }
        public string[] AccessRight { get; set; }
    }
}
