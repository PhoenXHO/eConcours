

using eConcours.Models;

namespace eConcours.Services
{
   public interface ISelectionService
    {
        ConfigurationSelection getConfigurationSelection(string filiere, int niveau);
        void updateConfigurationSelection(ConfigurationSelection configurationSelection);
        void calculeNoteGlobale(string filiere);
        IEnumerable<AdmisModel> selectStudents(string filiere, string niveau);
        IEnumerable<ListFinal> getListPrincipale(string filiere);
        IEnumerable<ListFinal> getListPrincipaleSup(string filiere);
        IEnumerable<ListFinal> getListAttente(string filiere);
        IEnumerable<ListFinal> getListAttenteSup(string filiere);
    }
}
