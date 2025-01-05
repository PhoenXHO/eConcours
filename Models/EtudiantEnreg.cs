using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eConcours.Models
{
    public class EtudiantEnreg
    {
        string Cne, Cin, Nom, Prenom, Ville, Num_dossier, Photo, Matricule;
        Boolean Convoque;

        public EtudiantEnreg(string Cne, string Cin, string Nom, string Prenom, string Ville)
        {
            this.Cin = Cin;
            this.Cne = Cne;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Ville = Ville;

        }
    }
}
