﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Category
{
    [Table("SubCategory", Schema = "ecom")]
    public class SubCategory
    {
        [Key]
        [StringLength(450)]
        public string SubCategoryID { get; set; }
        [Required]
        [StringLength(80)]
        public string SubCategoryName { get; set; }
        [StringLength(450)]
        [Required]
        public string CategoryID { get; set; }
        public bool Status { get; set; }
        [StringLength(450)]
        public string CompanyID { get; set; }
        public bool Delete { get; set; }

        [StringLength(250)]
        public string CreateBy { get; set; }
        [StringLength(250)]
        public string UpdateBy { get; set; }
        [StringLength(50)]
        public string CreateDate { get; set; }
        [StringLength(50)]
        public string UpdateDate { get; set; }

        [NotMapped]
        public string Encryted { get; set; }
        [NotMapped]
        public string CategroyName { get; set; }
    }
}
