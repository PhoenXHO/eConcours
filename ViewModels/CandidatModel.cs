using System.ComponentModel.DataAnnotations;

namespace eConcours.ViewModels
{
    public class CandidatModel
    {
            [Required]
            public string Cne { get; set; }
            [Required]
            [StringLength(8)]
            public string Cin { get; set; }
            [Required]
            public string Nom { get; set; }
            [Required]
            public string Prenom { get; set; }
            [Required]
            public string Adresse { get; set; }
            [Required]
            public string Ville { get; set; }
            [Required]
            public string LieuNaissance { get; set; }
            [Required]
            public string Telephone { get; set; }
            [Required]
            public string Nationalite { get; set; }
            [Required]
            public string Sexe { get; set; }
            [Required]
            public string Gsm { get; set; }
            [Required]
            public string Password { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public DateTime DateNaissance { get; set; }
            public string Photo { get; set; }
        
    }
}
