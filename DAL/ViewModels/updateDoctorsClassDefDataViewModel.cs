using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class updateDoctorsClassDefDataViewModel
    {
        [Required]
       public decimal class_code { get; set; }
        [Required]
        public decimal doc_code { get; set; }
        [Required]
        public decimal y { get; set; }	 
    }
}
