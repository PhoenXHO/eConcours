using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class Fichier
    {
        [Key]
        public int ID { get; set; }
        public string Cne { get; set; }
        public string nom { get; set; }
    }
}
