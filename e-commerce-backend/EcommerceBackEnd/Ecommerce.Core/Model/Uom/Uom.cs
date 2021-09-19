using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Uom
{
    [Table("Uom",Schema ="ecom")]
    public class Uom
    {
        [Key]
        [StringLength(450)]
        public string UomID { get; set; }
        [Required]
        [StringLength(30)]
        public string UomName { get; set; }
        public bool Delete { get; set; }
        [StringLength(450)]
        public string CompanyID { get; set; }


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
    }
}
