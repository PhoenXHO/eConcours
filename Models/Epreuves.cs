using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class Epreuves
    {
        public int ID { get; set; }
        [Required]
        public string Matiere { get; set; }
        [Required]
        public string Annee { get; set; }
        [Required]
        public string NomFichier { get; set; }
    }
}
