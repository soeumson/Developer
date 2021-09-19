using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.RoleManager
{
    public class Role :IdentityRole
    {
        [StringLength(450)]
        public string CompanyID { get; set; }
        public bool Delete { get; set; }
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
