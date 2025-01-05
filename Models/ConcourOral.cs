using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class ConcourOral
    {
        [Key, ForeignKey("Candidat")]
        public string Cne { get; set; }
        public int Classement { get; set; }


        public virtual Candidat Candidat { get; set; }
    }
}
