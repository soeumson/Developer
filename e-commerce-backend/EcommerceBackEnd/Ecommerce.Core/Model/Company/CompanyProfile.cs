using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Company
{
    [Table("CompanyProfile", Schema = "ecom")]
    public class CompanyProfile
    {
        [Key]
        [StringLength(450)]
        public string CompanyID { get; set; }
        [Required]
        [StringLength(250)]
        public string CompanyName { get; set; }
        [StringLength(250)]
        public string CompanyDescription { get; set; }
        [Required]
        [StringLength(250)]
        public string CompanyAddress { get; set; }
        [Phone]
        [Required]
        [StringLength(10)]
        public string CompanyPhone { get; set; }
        [EmailAddress]
        [StringLength(50)]
        [Required]
        public string CompanyEmail { get; set; }
        [StringLength(250)]
        public string Logo { get; set; }
        [StringLength(250)]
        public string BannerImage { get; set; }
        [Required]
        public string CurrencyID { get; set; }
        [StringLength(450)]
        public string UserID { get; set; }
        public bool Status { get; set; }
        [NotMapped]
        public string Encryted { get; set; }
        [NotMapped]
        public string CurrencyName { get; set; }

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
