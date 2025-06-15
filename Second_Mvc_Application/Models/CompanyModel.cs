﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Second_Mvc_Application.Models
{
    public class CompanyModel
    {
        public int Comp_No { get; set; }

        [Display(Name = "Company Name")]
        public string Comp_Name { get; set; }

        [Display(Name = "Strength")]
        public int Stength { get; set; } = 0;

        [Display(Name = "Remarks")]
        public string Remarks { get; set; }
    }
}