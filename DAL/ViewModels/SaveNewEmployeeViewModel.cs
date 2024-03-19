using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SaveNewEmployeeViewModel
    {
        [Required]
        public decimal emp_code { get; set; }
        [Required]
        public decimal type { get; set; }
        [Required]
        public decimal Class { get; set; }
        [Required]
        [StringLength(350)]
        public string pass { get; set; }
        [Required]
        [StringLength(350)]
        public string address { get; set; }
        [Required]
        [StringLength(350)]
        public string tel1 { get; set; }
        [Required]
        [StringLength(350)]
        public string tel2 { get; set; }
        [Required]
        [StringLength(350)]
        public string umane { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }

    }
}
