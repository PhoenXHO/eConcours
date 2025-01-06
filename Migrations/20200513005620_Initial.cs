using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionConcoursCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationPreselections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Filiere = table.Column<string>(nullable: true),
                    TypeDiplome = table.Column<string>(nullable: true),
                    CoeffBac = table.Column<int>(nullable: false),
                    CoeffS1 = table.Column<int>(nullable: false),
                    CoeffS2 = table.Column<int>(nullable: false),
                    CoeffS3 = table.Column<int>(nullable: false),
                    CoeffS4 = table.Column<int>(nullable: false),
                    CoeffS5 = table.Column<int>(nullable: false),
                    CoeffS6 = table.Column<int>(nullable: false),
                    NoteJoker = table.Column<double>(nullable: false),
                    NoteSeuil = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPreselections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationSelections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Filiere = table.Column<string>(nullable: true),
                    CoeffMath = table.Column<int>(nullable: false),
                    CoeffSpecialite = table.Column<int>(nullable: false),
                    NbrPlace = table.Column<int>(nullable: false),
                    NbrPlaceListAtt = table.Column<int>(nullable: false),
                    NoteMin = table.Column<double>(nullable: false),
                    TypeClassement = table.Column<string>(nullable: true),
                    Niveau = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationSelections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Corbeilles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CNE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corbeilles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Epreuves",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Matiere = table.Column<string>(nullable: false),
                    Annee = table.Column<string>(nullable: false),
                    NomFichier = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epreuves", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fichiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cne = table.Column<string>(nullable: true),
                    nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichiers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Candidats",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    Cin = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true),
                    LieuNaissance = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Nationalite = table.Column<string>(nullable: true),
                    Num_dossier = table.Column<int>(nullable: false),
                    Sexe = table.Column<string>(nullable: true),
                    Gsm = table.Column<string>(nullable: true),
                    DateInscription = table.Column<DateTime>(nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    NotePreselec = table.Column<double>(nullable: false),
                    Convoque = table.Column<bool>(nullable: false),
                    Admis = table.Column<bool>(nullable: false),
                    Niveau = table.Column<int>(nullable: false),
                    Verified = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Matricule = table.Column<string>(nullable: true),
                    Presence = table.Column<bool>(nullable: false),
                    Conforme = table.Column<bool>(nullable: false),
                    listDatt = table.Column<bool>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidats", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_Candidats_Filieres_ID",
                        column: x => x.ID,
                        principalTable: "Filieres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnneeUniversitaires",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    Semestre1 = table.Column<double>(nullable: false),
                    Semestre2 = table.Column<double>(nullable: false),
                    Semestre3 = table.Column<double>(nullable: false),
                    Semestre4 = table.Column<double>(nullable: false),
                    Semestre5 = table.Column<double>(nullable: false),
                    Semestre6 = table.Column<double>(nullable: false),
                    Redoublant1 = table.Column<string>(nullable: true),
                    Redoublant2 = table.Column<string>(nullable: true),
                    Redoublant3 = table.Column<string>(nullable: true),
                    AnneUni1 = table.Column<string>(nullable: true),
                    AnneUni2 = table.Column<string>(nullable: true),
                    AnneUni3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnneeUniversitaires", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_AnneeUniversitaires_Candidats_Cne",
                        column: x => x.Cne,
                        principalTable: "Candidats",
                        principalColumn: "Cne",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baccalaureats",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    TypeBac = table.Column<string>(nullable: true),
                    DateObtentionBac = table.Column<string>(nullable: true),
                    NoteBac = table.Column<double>(nullable: false),
                    MentionBac = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baccalaureats", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_Baccalaureats_Candidats_Cne",
                        column: x => x.Cne,
                        principalTable: "Candidats",
                        principalColumn: "Cne",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouncourEcrits",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    NoteMath = table.Column<double>(nullable: false),
                    NoteSpecialite = table.Column<double>(nullable: false),
                    NoteGenerale = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouncourEcrits", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_CouncourEcrits_Candidats_Cne",
                        column: x => x.Cne,
                        principalTable: "Candidats",
                        principalColumn: "Cne",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouncourOrals",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    Classement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouncourOrals", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_CouncourOrals_Candidats_Cne",
                        column: x => x.Cne,
                        principalTable: "Candidats",
                        principalColumn: "Cne",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diplomes",
                columns: table => new
                {
                    Cne = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Etablissement = table.Column<string>(nullable: true),
                    VilleObtention = table.Column<string>(nullable: true),
                    NoteDiplome = table.Column<double>(nullable: false),
                    Specialite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diplomes", x => x.Cne);
                    table.ForeignKey(
                        name: "FK_Diplomes_Candidats_Cne",
                        column: x => x.Cne,
                        principalTable: "Candidats",
                        principalColumn: "Cne",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidats_ID",
                table: "Candidats",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AnneeUniversitaires");

            migrationBuilder.DropTable(
                name: "Baccalaureats");

            migrationBuilder.DropTable(
                name: "ConfigurationPreselections");

            migrationBuilder.DropTable(
                name: "ConfigurationSelections");

            migrationBuilder.DropTable(
                name: "Corbeilles");

            migrationBuilder.DropTable(
                name: "CouncourEcrits");

            migrationBuilder.DropTable(
                name: "CouncourOrals");

            migrationBuilder.DropTable(
                name: "Diplomes");

            migrationBuilder.DropTable(
                name: "Epreuves");

            migrationBuilder.DropTable(
                name: "Fichiers");

            migrationBuilder.DropTable(
                name: "Candidats");

            migrationBuilder.DropTable(
                name: "Filieres");
        }
    }
}
