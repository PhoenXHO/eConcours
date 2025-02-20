﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.ViewModels
{
    public class BaccalaureatModel
    {
        [Key]
        public string Cne { get; set; }
        [Required]
        public string TypeBac { get; set; }
        [Required]
        public string DateObtentionBac { get; set; }
        [Required]
        [Range(10, 20)]
        public double NoteBac { get; set; }
        [Required]
        public string MentionBac { get; set; }
        public string BacPdf { get; set; }
    }
}
