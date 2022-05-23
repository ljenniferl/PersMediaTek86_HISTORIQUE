using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersMediaTek86.Connexion;
using PersMediaTek86.Modele;

namespace PersMediaTek86.Dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// Chaine de connexion à la BDD
        /// </summary>
        private static string connectionString = "server=localhost;user id=userDB;password=userDB;database=PersMediaTek86;SslMode=none";

        // PARTIE PERSONNEL

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "SELECT p.idpersonnel AS idpersonnel, p.nom AS nom, p.prenom AS prenom, p.tel AS tel, p.mail AS mail, s.idservice AS idservice, s.nom AS service";
            req += " FROM personnel p JOIN service s ON(p.idservice = s.idservice)";
            req += " ORDER BY nom, prenom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                lesPersonnels.Add(personnel);
            }
            curs.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>Liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service ORDER BY nom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }

        /// <summary>
        /// Supprime un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public static void DelPersonnel(Personnel personnel)
        {
            string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à ajouter</param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice)";
            req += " VALUES(@nom, @prenom, @tel, @mail, @idservice);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modifie un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à modifier</param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice";
            req += " WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }


        // PARTIE ABSENCE

        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <returns>Liste des absences</returns>
        public static List<Absence> GetLesAbsences(int monId)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT a.idpersonnel AS idpersonnel, a.datedebut AS dateDebut, a.idmotif AS idmotif, m.libelle AS libelle, a.datefin AS dateFin";
            req += " FROM absence a JOIN personnel p ON(a.idpersonnel = p.idpersonnel) JOIN motif m ON(a.idmotif = m.idmotif)";
            req += " WHERE a.idpersonnel = @idpersonnel";
            req += " ORDER BY datedebut DESC;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", monId);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            while (curs.Read())
            {
                Absence absence = new Absence((int)curs.Field("idpersonnel"), (DateTime)curs.Field("dateDebut"), (DateTime)curs.Field("dateFin"), (int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesAbsences.Add(absence);
            }
            curs.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Récupère et retourne les motifs d'absence provenant de la BDD
        /// </summary>
        /// <returns>Liste des motifs d'absence</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY libelle;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Motif motif = new Motif((int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curs.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Supprime une absence
        /// </summary>
        /// <param name="absence">Objet absence à supprimer</param>
        public static void DelAbsence(Absence absence)
        {
            string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND dateDebut = @dateDebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@dateDebut", absence.DateDebut);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence">Objet absence à ajouter</param>
        public static void AddAbsence(Absence absence)
        {
            string req = "INSERT INTO absence(idpersonnel, dateDebut, idmotif, dateFin)";
            req += " VALUES(@idpersonnel, @dateDebut, @idmotif, @dateFin);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@dateDebut", absence.DateDebut);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@dateFin", absence.DateFin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modifie une absence
        /// </summary>
        /// <param name="absence">Objet absence à modifier</param>
        public static void UpdateAbsence(Absence absence)
        {
            string req = "UPDATE absence SET dateFin = @dateFin, idmotif = @idmotif";
            req += " WHERE idpersonnel = @idpersonnel AND dateDebut = @dateDebut;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@dateDebut", absence.DateDebut);
            parameters.Add("@dateFin", absence.DateFin);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }


    }
}
