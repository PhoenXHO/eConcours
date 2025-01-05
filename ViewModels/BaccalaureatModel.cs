using System.ComponentModel.DataAnnotations;

namespace eConcours.ViewModels
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
    }
}
