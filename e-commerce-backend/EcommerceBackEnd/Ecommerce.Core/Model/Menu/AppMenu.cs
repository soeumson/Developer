using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Menu
{
    [Table("AppMenu", Schema ="ecom")]
    public class AppMenu
    {
        [Key]
        [StringLength(450)]
        public string MenuId { get; set; }
        [StringLength(250)]
        public string Parent { get; set; } 
        [StringLength(250)]
        [Required]
        public string MenuTitle { get; set; }
        [StringLength(250)]
        public string Controller { get; set; }
        [StringLength(250)]
        public string Action { get; set; }
        [StringLength(3)]
        public string HasChild { get; set; } // Yes, No
        [StringLength(25)]
        public string Icon { get; set; } // only fontawesome
        public string QueryString { get; set; }
        [StringLength(10)]
        public string Status { get; set; } // Active, Inactive
        [StringLength(3)]
        public string IsPublic  { get; set; } // Yes / No
        public int Order { get; set; }
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
        public string AccessRight { get; set; } // C = Create, U = Update , V = View, D = Delete, M = Menu , R = Role , A =Aproval User 

    }
}
