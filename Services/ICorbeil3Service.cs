using eConcours.Models;

namespace eConcours.Services
{
    public interface ICorbeil3Service
    {
        IEnumerable<SearchModel3> afficheCorbeil(int niveau);
        IEnumerable<SearchModel3> restoreCorbeil(string cne, int niveau);
        IEnumerable<SearchModel3> searchCriteria(string Criteria, string Key, string Diplome, string Filiere, int niveau);
    }
}
