using System.ComponentModel.DataAnnotations;

namespace eConcours.ViewModels
{
    public class FiliereModel
    {
        
        public int ID { get; set; }
        public string Nom { get; set; }
        public bool isChecked { get; set; }

    }
}
