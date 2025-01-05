﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class ListEnregistrement
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Filiere { get; set; }
        public string Cin { get; set; }
        public int Num_dossier { get; set; }
        public string Sexe { get; set; }
    }
}
