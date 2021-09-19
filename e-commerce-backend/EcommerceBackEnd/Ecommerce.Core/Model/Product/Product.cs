using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Product
{
    [Table("Product",Schema ="ecom")]
    public class Product
    {
        [Key]
        [StringLength(450)]
        public string ProductID { get; set; }
        [StringLength(450)]
        [Required]
        public string ProductCode { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [StringLength(450)]
        [Required]
        public string CategoryID { get; set; }
        [StringLength(450)]
        public string SubCategoryID { get; set; }
        [StringLength(450)]
        public string ModelID { get; set; }
        [Required]
        [StringLength(450)]
        public string UomID { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public double Price { get; set; }
        [StringLength(450)]
        public string Description { get; set; }
        public string Images { get; set; }

        public bool ManageStock { get; set; }
        public bool StatusAvailable { get; set; }
        public bool DiscountActive { get; set; }
        public double? DiscountValue { get; set; } 
        [StringLength(8)]
        public string DiscountType { get; set; }
        public double? FeeIncluded { get; set; }
        public double? VatIncluded { get; set; } 
        public bool Status { get; set; }
        public bool Delete { get; set; }
        public double? TotalOrder { get; set; }
        public double? Favourite { get; set; }
        [StringLength(450)]
        public string CompanyID { get; set; }

        // defualt 
        [StringLength(250)]
        public string CreateBy { get; set; }
        [StringLength(250)]
        public string UpdateBy { get; set; }
        [StringLength(50)]
        public string CreateDate { get; set; }
        [StringLength(50)]
        public string UpdateDate { get; set; }

        // Not Mapperd 

        [NotMapped]
        public string CodeTemp { get; set; }
        [NotMapped]
        public string Encryted { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
        [NotMapped]
        public string SubCategoryName { get; set; }
        [NotMapped]
        public string ModelName { get; set; }
        [NotMapped]
        public string UomName { get; set; }
        [NotMapped]
        public string Currency { get; set; }
        [NotMapped]
        public string CompanyName { get; set; }
        [NotMapped]
        public List<IFormFile> FormFile { get; set; }

    }
}
