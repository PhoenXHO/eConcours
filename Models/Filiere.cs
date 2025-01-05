using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class Filiere
    {
        public int ID { get; set; }
        public string Nom { get; set; }

        //relation manyToOne avec la classe Candidat 
        public virtual IList<Candidat> Candidats { get; set; }
    }
}
