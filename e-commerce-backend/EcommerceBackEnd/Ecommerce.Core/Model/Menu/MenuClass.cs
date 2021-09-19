using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Menu
{
    public class MenuClass
    {
        public class MainMenu
        {
            [Key]
            [Required]
            public string Id { get; set; }
            [Required]
            public string Description { get; set; }
            public string MenuId { get; set; }
            public string CompanyId { get; set; }
            [NotMapped]
            [Required]
            public string[] Menus { get; set; }
            [NotMapped]

            public string Encryted { get; set; }
            [NotMapped]
            public string ShowMenu { get; set; }
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
        public class Menu
        {
            [Key]
            [Required]
            public string Id { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public string KhmerDescription { get; set; }
            public string MenuItemId { get; set; }
            public string CompanyId { get; set; }
            [Required]
            public string Icon { get; set; }
            [NotMapped]
            [Required]
            public string[] MenuItems { get; set; }
            [NotMapped]
            public string ShowMenuItem { get; set; }
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
        public class MenuItem
        {
            [Key]
            [Required]
            public string Id { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public string KhmerDescription { get; set; }
            [Required]
            public string Url { get; set; }
            public string CompanyId { get; set; }
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
}
