using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SaveAnotherCallDetail
    {
        [Required]
        [StringLength(50)]
        public string product_feed { get; set;}
        [Required]
        [StringLength(450)]
        public string product_notes { get; set; }
        [Required]
        public decimal myser { get; set; }
        [Required]
        public decimal product_code { get; set; }
        [Required]
        public int p1 { get; set; }
        [Required]
        public int p1_count { get; set; }
        [Required]
        public int p2 { get; set; }
        [Required]
        public int p2_count { get; set; }
    }
}
