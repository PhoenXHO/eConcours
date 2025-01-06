using GestionConcoursCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services
{
    public interface IEnregistrementService
    {
        IEnumerable<ListEnregistrement> listetByNiveau(int niveau);
        void enregisterByCin(string cin);
        IEnumerable<EnregistrementInfo> infosCandidatByCin(string cin);
    }
}
