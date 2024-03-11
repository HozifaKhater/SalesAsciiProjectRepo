using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SaveNonWorkDayVoewModel
    {
        [Required]
        public decimal saleman_code { get; set; }
          [Required]
        [StringLength(50)]
        public string day_date { get; set; }
        [Required]
        public decimal reason_code { get; set; }
    }
}
