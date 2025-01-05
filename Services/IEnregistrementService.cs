

using eConcours.Models;

namespace eConcours.Services
{
    public interface IEnregistrementService
    {
        IEnumerable<ListEnregistrement> listetByNiveau(int niveau);
        void enregisterByCin(string cin);
        IEnumerable<EnregistrementInfo> infosCandidatByCin(string cin);
    }
}
