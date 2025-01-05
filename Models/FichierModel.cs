using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class FichierModel
    {
        [Required(ErrorMessage = "Please select file.")]
        //[Display(Name = "Browse File")]
        public IFormFile[] files { get; set; }
    }
}
