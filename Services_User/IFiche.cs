using GestionConcoursCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services_User
{
   public interface IFiche
    {
        Candidat GetCandidat(string cne);
    }
}
