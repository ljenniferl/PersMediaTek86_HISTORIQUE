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
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel"></param>
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
        /// <param name="personnel"></param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice";
            req += " WHERE idpersonnel = 12;";
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



    }
}
