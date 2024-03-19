using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class updateDefDataViewModel
    {
        [Required]
        [StringLength(50)]
        public string scode { get; set; }
        [Required]
        [StringLength(350)]
        public string sname { get; set; }
        [Required]

        public decimal code { get; set; }
    }
}
