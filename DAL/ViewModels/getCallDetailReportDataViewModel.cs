﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class getCallDetailReportDataViewModel
    {
        [Required]
        public decimal master_visit_code { get; set; }

        [Required]
        public decimal master_visit_code1 { get; set; }
    }
}
