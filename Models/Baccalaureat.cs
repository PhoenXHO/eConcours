﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Models
{
    public class Baccalaureat
    {
        [Key, ForeignKey("Candidat")]
        public string Cne { get; set; }
        public string TypeBac { get; set; }
        public string DateObtentionBac { get; set; }
        public double NoteBac { get; set; }
        public string MentionBac { get; set; }
        public string BacPdf { get; set; }


        public virtual Candidat Candidat { get; set; }
    }
}
