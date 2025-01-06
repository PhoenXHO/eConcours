using GestionConcoursCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services
{
	public interface ICorrectionService
	{
		IEnumerable<CorrectionModel> corr(string type_fil);
		IEnumerable<CorrectionModel4> corr4(string type_fil);
	}
}
