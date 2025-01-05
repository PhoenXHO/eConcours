using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class ConcourEcrit
    {
        [Key, ForeignKey("Candidat")]
        public string Cne { get; set; }

        public double NoteMath { get; set; }
        public double NoteSpecialite { get; set; }
        public double NoteGenerale { get; set; }

        public virtual Candidat Candidat { get; set; }
    }
}
