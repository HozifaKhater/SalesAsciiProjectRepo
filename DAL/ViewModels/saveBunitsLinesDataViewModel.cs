using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class saveBunitsLinesDataViewModel
    {
        [Required]
        public decimal bu { get; set; }
        [Required]

        public decimal line { get; set; }
        [Required]

        public decimal state { get; set; }



    }
}
