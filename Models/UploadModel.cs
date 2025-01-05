using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class UploadModel
    {
        [Required]
        public string matiere { get; set; }
        [Required]
        public string annee { get; set; }
        [Required]
        public IFormFile fichier { get; set; }
    }
}
