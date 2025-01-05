using System.ComponentModel.DataAnnotations;

namespace eConcours.ViewModels
{
    public class Statistique
    {
        public int nbDut { get; set; }
        public int nbDeug { get; set; }
        public int nbLicencePro { get; set; }
        public int nbLicenceSt { get; set; }
        public int nbLicenceFnd { get; set; }
        public string nomFiliere { get; set; }

        public int getTotal()
        { 
            return nbDut + nbDeug + nbLicencePro + nbLicenceSt + nbLicenceFnd;
        }
    }
}
