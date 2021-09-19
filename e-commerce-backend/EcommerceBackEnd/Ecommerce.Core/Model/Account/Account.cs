using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Account
{
    public class Account : IdentityUser
    {
        [StringLength(250)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(250)]
        [Required]
        public string LastName { get; set; }
        [StringLength(250)]
        public string FullName { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public bool ResetPassword { get; set; }
        public bool Status { get; set; }
        [DataType("date")]
        public DateTime StartDateProfile { get; set; }
        [StringLength(450)]
        public string CompanyID { get; set; }
        [StringLength(50)]
        public string UserType { get; set; }
        public bool Delete { get; set; }
        public bool Approval { get; set; }
        public string MainMenuId { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public string Encryted { get; set; }
        // defualt 
        [StringLength(250)]
        public string CreateBy { get; set; }
        [StringLength(250)]
        public string UpdateBy { get; set; }
        [StringLength(50)]
        public string CreateDate { get; set; }
        [StringLength(50)]
        public string UpdateDate { get; set; }
    }
}
