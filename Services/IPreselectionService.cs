﻿using GestionConcoursCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionConcoursCore.Services
{
    public interface IPreselectionService
    {
        void convoquerCandidats(List<string> cneList);

        IEnumerable<PreselectionModel> getAll(int niveau, string filiere, string diplome);

        void setConfig(ConfigurationPreselection config, int niveau);

        void calculerPreselec(int niveau, string fil, string diplome);

        IEnumerable<PreselectionModel> getConvoques(int niveau, string filiere, string diplome);

        ConfigurationPreselection getConfig(string filiere, string diplome);

        IEnumerable<string> getPourcentage(int niveau, string filiere, string diplome);
    }
}
