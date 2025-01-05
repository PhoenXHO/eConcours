using eConcours.Models;

namespace eConcours.Data
{
    public class Generer
    {
        //###################################### CANDIDATS ###################################

        public static IEnumerable<Candidat> GenererCandidats()
        {

            List<Candidat> list = new List<Candidat>()
            {
                new Candidat()
                {
                    Cne = "test5",
                    Cin = "test5",
                    Nom = "xxxx",
                    Prenom = "xxx",
                    Email = "xxxs@gmail.com",
                    Adresse="saada",
                    Ville = "Casablanca",
                    Nationalite = "Marocaine",
                    Num_dossier = 0,
                    Sexe = "Femme",
                    Gsm="ghh",
                    Photo = "icon.jpg",
                    Convoque = false,
                    Niveau = 3,
                    Verified = 1,
                    Password = "test",
                    Matricule = "A123",
                    Presence = false,
                    Conforme = false,
                    ID = 1,
                    DateInscription = DateTime.Now,
                    DateNaissance = DateTime.Now
                },

            };

            return list;
        }


        //###################################### ANNEE UNIVERSITAIRE ###################################
        public static IEnumerable<AnneeUniversitaire> GenererAnneeUniversitaire()
        {

            List<AnneeUniversitaire> list = new List<AnneeUniversitaire>()
            {
                new AnneeUniversitaire()
                {
                    Cne = "test5",
                    Semestre1 = 14.2,
                    Semestre2 = 14.8,
                    Semestre3 = 15,
                    Semestre4 = 17,
                    Redoublant1 = "Non",
                    Redoublant2 = "Non",
                    Redoublant3 = "Non",
                    AnneUni1 = "2020/2021",
                    AnneUni2 = "2022/2023",
                    AnneUni3 = "2023/2024"
                },


            };

            return list;
        }

        //###################################### BACCALAUREAT ###################################
        public static IEnumerable<Baccalaureat> GenererBaccalaureat()
        {

            List<Baccalaureat> list = new List<Baccalaureat>()
            {
                new Baccalaureat()
                {
                    Cne = "test5",
                    TypeBac = "SMA",
                    DateObtentionBac = "2019",
                    NoteBac = 16,
                    MentionBac = "Bien"
                },

            };

            return list;
        }

        //###################################### CONCOURS ECRIT ###################################

        public static IEnumerable<ConcourEcrit> GenererConcoursEcrit()
        {

            List<ConcourEcrit> list = new List<ConcourEcrit>()
            {
                new ConcourEcrit()
                {
                    Cne = "test5",
                    NoteMath = 15,
                    NoteSpecialite = 15.5
                },

            };

            return list;
        }

        //######################################  CONCOURS ORAL ###################################

        public static IEnumerable<ConcourOral> GenererConcoursOral()
        {

            List<ConcourOral> list = new List<ConcourOral>()
            {
                new ConcourOral()
                {
                    Cne = "test5"
                },

            };

            return list;
        }

        //###################################### DIPLOME ###################################

        public static IEnumerable<Diplome> GenererDiplome()
        {

            List<Diplome> list = new List<Diplome>()
            {
                new Diplome()
                {
                    Cne = "test5",
                    Type = "DUT",
                    Etablissement = "EST",
                    VilleObtention = "safi",
                    NoteDiplome = 16.42,
                    Specialite = "Informatique"
                },

            };

            return list;
        }


    }



}
