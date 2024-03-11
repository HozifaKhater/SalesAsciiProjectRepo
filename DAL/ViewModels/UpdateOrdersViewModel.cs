using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class UpdateOrdersViewModel
    {
        [Required] public int OrderID { get; set; } 
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        [Required]
        public string ProductName1 { get; set; } = string.Empty;
        [Required]
        public string ProductName2 { get; set; } = string.Empty;
        [Required]
        public string ProductName3 { get; set; } = string.Empty;
        [Required]
        public int Quantity1 { get; set; }
        [Required]
        public int Quantity2 { get; set; }
        [Required]
        public int Quantity3 { get; set; }
        [Required]
        public decimal Price1 { get; set; }
        [Required]
        public decimal Price2 { get; set; }
        [Required]
        public decimal Price3 { get; set; }
        [Required]
        public int  OrderDetailId1 { get; set; }
        [Required]

        public int OrderDetailId2 { get; set; }
        [Required]
        public int OrderDetailId3 { get; set; }

    }
}
