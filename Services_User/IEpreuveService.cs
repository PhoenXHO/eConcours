using eConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eConcours.Services_User
{
    public interface IEpreuveService
    {
        IEnumerable<Epreuves> getEpreuves();
    }
}
