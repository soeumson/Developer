using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.Currency
{
    [Table("Currency",Schema ="ecom")]
    public class Currency
    {
        [Key]
        [Required]
        public string CurrencyID { get; set; }
        [Required]
        [StringLength(50)]
        public string CurrencyName { get; set; }
        public bool Status { get; set; }

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
