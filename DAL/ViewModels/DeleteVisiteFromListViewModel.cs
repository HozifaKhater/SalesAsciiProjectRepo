using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class DeleteVisiteFromListViewModel
    {
        [Required]
        public decimal doc_code { get; set; }
        [Required]
        public decimal master_visit_code { get; set; }
        [Required]
        public decimal myser { get; set; }

    }
}
