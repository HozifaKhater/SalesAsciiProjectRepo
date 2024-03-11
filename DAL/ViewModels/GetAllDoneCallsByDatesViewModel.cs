using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class GetAllDoneCallsByDatesViewModel
    {
        [Required]
        [StringLength(50)]
        public string to_date { get; set; }
        [Required]
        [StringLength(50)]
        public string from_date { get; set; }
        [Required]
        public decimal master_visit_code { get; set; }
    }
}
