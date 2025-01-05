using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eConcours.Data;
using eConcours.Models;

namespace eConcours.Services_User
{
    public class EpreuveServiceImp : IEpreuveService
    {
        GestionConcourCoreDbContext db;

        public EpreuveServiceImp(GestionConcourCoreDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Epreuves> getEpreuves()
        {
            return db.Epreuves;
        }
    }
}
