using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class DeleteFromNonWorkDaysViewModel
    {
        [Required]
        public decimal emp_code { get; set; }
        [Required]
        public decimal ser { get; set; }
    }
}
