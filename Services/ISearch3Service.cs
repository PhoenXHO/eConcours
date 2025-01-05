

using eConcours.Models;

namespace eConcours.Services
{
    public interface ISearch3Service
    {
        IEnumerable<SearchModel3> generalSearch(int niveau);
        IEnumerable<SearchModel3> specifiedSearch(string Criteria, string Key, string Diplome, string Filiere, int niveau);
        IEnumerable<SearchModel3> deleteCandidat(string cne, int niveau);
        IEnumerable<SearchModel3> conformCandidat(string cne, int niveau);
    }
}
