using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.LockupClass
{
    [Table("LookupMenus", Schema = "dbo")]
    public class LookupMenus
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string KhmerDescription { get; set; }

    }
}
