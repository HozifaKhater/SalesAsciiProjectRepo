using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SaveCallMasterDetailViewModel
    {
        [Required]
        public decimal emp_code { get; set; }
        [Required]
        public decimal doc_code { get; set; }
        [Required]
        public decimal product_code { get; set; }
        [Required]
        public decimal who_with { get; set; }

        [Required]
        [StringLength(50)]
        public string call_date { get; set; }
        [Required]
        [StringLength(450)]
        public string g_notes { get; set; }
        [Required]
        [StringLength(50)]
        public string bu_feed { get; set; }
        [Required]
        [StringLength(50)]
        public string product_feed { get; set; }
        [Required]
        [StringLength(450)]
        public string product_notes { get; set; }
        [Required]
        [StringLength(50)]
        public string visit_type { get; set; }
        [Required]
        [StringLength(50)]
        public string NA { get; set; }
        [Required]
        [StringLength(350)]
        public string p1_notes { get; set; }
        [Required]
        [StringLength(50)]
        public string p2_notes { get; set; }

        [Required]
        public int p1 { get; set; }
        [Required]
        public int p2 { get; set; }
        [Required]
        public int p1_count { get; set; }
        [Required]
        public int p2_count { get; set; }
    }
}
