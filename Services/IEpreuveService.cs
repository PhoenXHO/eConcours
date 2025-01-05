

using eConcours.Models;

namespace eConcours.Services
{
    public interface IEpreuveService
    {
        int Upload(UploadModel epreuve);
        IEnumerable<DiplomeFichierModel> diplomeFile(string cne, int niveau);
    }
}
