using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services_User
{
    public class FicheImp : IFiche
    {
        GestionConcourCoreDbContext db;

        public FicheImp(GestionConcourCoreDbContext db)
        {
            this.db = db;
        }

        public Candidat GetCandidat(string cne)
        {
            var candidat = db.Candidats.Include("Filiere").Include("Diplome").Where(c => c.Cne == cne).SingleOrDefault();
            return candidat as Candidat;
        }
    }
}
