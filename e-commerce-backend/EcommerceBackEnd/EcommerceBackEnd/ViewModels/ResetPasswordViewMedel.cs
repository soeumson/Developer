using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.ViewModels
{
    public class ResetPasswordViewMedel 
    {
        [DataType(DataType.Password)]
        [Required]
        public string NewPassoword { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string ConfirmNewPassword { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Key { get; set; }
        
    }
}
