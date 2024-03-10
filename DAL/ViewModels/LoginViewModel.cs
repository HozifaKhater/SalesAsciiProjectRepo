using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string uname { get; set; } = string.Empty;
        [Required]
        public string upass { get; set; } = string.Empty;
    }
}
