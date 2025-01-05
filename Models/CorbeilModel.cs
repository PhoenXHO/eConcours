using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class CorbeilModel
    {
        public string Cne { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
