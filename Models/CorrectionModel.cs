﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class CorrectionModel
    {
        public int Num_dossier { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Filiere { get; set; }
        public string Diplome { get; set; }
        public string Cne { get; set; }
        public double NoteMath { get; set; }
        public double NoteSpecialite { get; set; }
    }
}
