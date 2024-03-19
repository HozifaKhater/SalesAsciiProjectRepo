using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SaveEmpNewPasswordViewModel
    {

        [Required]
        public decimal emp_code { get; set; }
        [Required]
        [StringLength(350)]
        public string old_pass { get; set; }
        [Required]
        [StringLength(350)]
        public string new_pass { get; set; }
        [Required]
        [StringLength(350)]
        public string conf_pass { get; set; }
    }
}
