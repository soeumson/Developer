using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.ViewModels
{
    public class ProvidUserViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        [Required]
        public string MainMenuId { get; set; }
        [Required]
        public string[] Roles { get; set; }
    }
    public class ProvidUserAccessRightViewModel
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        [Required]
        public string MenuItemId { get; set; }
        [Required]
        public string[] AccessRight { get; set; }
    }
    public class ProvidRoleAccessRightViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        [Required]
        public string MenuItemId { get; set; }
        [Required]
        public string[] AccessRight { get; set; }
    }
}
