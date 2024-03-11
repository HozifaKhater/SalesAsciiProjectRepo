using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class UpdateSalesDocListViewModel
    {
        [Required]
        [StringLength(50)]
        public string thedate { get; set; }
        [Required]
        public decimal saleman_code { get; set; }
        [Required]
        public decimal serial{ get; set; }
    }
}
