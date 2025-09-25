using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VisiTTracking
{
    /// <summary>
    /// Classe passerelle
    /// </summary>
    public static class Passerelle
    {
        /// <summary>
        /// Liste des visiteurs
        /// </summary>
        static private List<Visiteur> ListeDesVisiteurs = new List<Visiteur> { };
        /// <summary>
        /// Liste des médecins
        /// </summary>
        static private List<Medecin> ListeDesMedecins = new List<Medecin> { };
        /// <summary>
        /// Liste des visites
        /// </summary>
        static private List<Visite> ListeDesVisites = new List<Visite> { };

        /// <summary>
        /// Récupère les visiteurs
        /// </summary>
        /// <returns>Renvoie les visiteurs de la classe</returns>
        // static public List<Visiteur> getLesVisiteurs() { return ListeDesVisiteurs; }
        /// <summary>
        /// Récupère les médecins
        /// </summary>
        /// <returns>Renvoie les médecins de la classe</returns>
        // static public List<Medecin> getLesMedecins() { return ListeDesMedecins; }
        /// <summary>
        /// Récupère les visites
        /// </summary>
        /// <returns>Renvoie les visites de la classe</returns>
        static public List<Visite> getLesVisites() { return ListeDesVisites; }

        /// <summary>
        /// Ajoute un visiteur à la liste des visiteurs
        /// </summary>
        /// <param name="visiteur"></param>
        public static void addVisiteur(Visiteur visiteur)
        {
            ListeDesVisiteurs.Add(visiteur);
        }
        /// <summary>
        /// Ajoute une visite à la liste des visites
        /// </summary>
        /// <param name="visite"></param>
        public static void addVisite(Visite visite)
        {
            ListeDesVisites.Add(visite);
        }
        /// <summary>
        /// Ajoute un visiteur à la liste des visiteurs
        /// </summary>
        /// <param name="medecin"></param>
        public static void addMedecin(Medecin medecin)
        {
            ListeDesMedecins.Add(medecin);
        }
        /// <summary>
        /// modifie un visiteur
        /// </summary>
        /// <param name="visiteur"></param>
        public static void editVisiteur(Visiteur visiteur)
        {
            int index = ListeDesVisiteurs.FindIndex(v => v.id == visiteur.id);

            if (index != -1)
            {
                ListeDesVisiteurs[index] = visiteur;
            }
            else
            {
                throw new Exception("Visiteur non trouvé");
            }
        }
        /// <summary>
        /// modifie une visite
        /// </summary>
        /// <param name="visite"></param>
        public static void editVisite(Visite visite)
        {
            int index = ListeDesVisites.FindIndex(v => v.id == visite.id);

            if (index != -1)
            {
                ListeDesVisites[index] = visite;
            }
            else
            {
                throw new Exception("Visite non trouvé");
            }
        }
        /// <summary>
        /// modifie un médecin
        /// </summary>
        /// <param name="medecin"></param>
        public static void editMedecin(Medecin medecin)
        {
            int index = ListeDesMedecins.FindIndex(m => m.id == medecin.id);

            if (index != -1)
            {
                ListeDesMedecins[index] = medecin;
            }
            else
            {
                throw new Exception("Médecin non trouvé");
            }
        }
        /// <summary>
        /// Supprime un visiteur de la liste des visiteurs
        /// </summary>
        /// <param name="visiteur"></param>
        public static void delVisiteur(Visiteur visiteur)
        {
            ListeDesVisiteurs.Remove(visiteur);
        }
        /// <summary>
        /// Supprime un médecin de la liste des médecin
        /// </summary>
        /// <param name="medecin"></param>
        public static void delMedecin(Medecin medecin)
        {
            ListeDesMedecins.Remove(medecin);
        }
        /// <summary>
        /// Supprime une visite de la liste des visites
        /// </summary>
        /// <param name="visite"></param>
        public static void delVisite(Visite visite)
        {
            ListeDesVisites.Remove(visite);
        }
        /// <summary>
        /// Jeu d'essai
        /// </summary>
        public static void jeuEssai()
        {
            Medecin medecin1 = new Medecin(1, "Dufour", "Floryan", "0600000000", "floduf1108@gmail.com", "Rue des paquerettes", 25, 62260, "Auchel");
            Medecin medecin2 = new Medecin(2, "Dutailly", "Rémi", "0605040302", "dut.remi@gmail.com", "Rue de perpignan", 150, 62500, "Saint-Omer");
            Medecin medecin3 = new Medecin(3, "Berthe", "Nolan", "0607080900", "nolan@gmail.com", "Rue de blendecques", 12, 62570, "Arques");
            Medecin medecin4 = new Medecin(4, "Bob", "Eleana", "0625341987", "eleana@gmail.com", "Rue du dr pontier", 11, 62380, "Lumbres");
            Visiteur visiteur1 = new Visiteur(1, "Dupont", "Jean", "0612345678", "jean.dupont@example.com");
            Visiteur visiteur2 = new Visiteur(2, "Dutailly", "Rémi", "0600000000", "duremi@fasol.fr");
            Visiteur visiteur3 = new Visiteur(3, "Martin", "Claire", "0623456789", "claire.martin@example.com");
            Visiteur visiteur4 = new Visiteur(4, "Leroy", "Pierre", "0634567890", "pierre.leroy@example.com");
            Visiteur visiteur5 = new Visiteur(5, "Bernard", "Sophie", "0645678901", "sophie.bernard@example.com");
            Visiteur visiteur6 = new Visiteur(6, "Moreau", "Antoine", "0656789012", "antoine.moreau@example.com");
            Visiteur visiteur7 = new Visiteur(7, "Fournier", "Julie", "0667890123", "julie.fournier@example.com");
            Visiteur visiteur8 = new Visiteur(8, "Rousseau", "Louis", "0678901234", "louis.rousseau@example.com");
            Visiteur visiteur9 = new Visiteur(9, "Petit", "Camille", "0689012345", "camille.petit@example.com");
            Visiteur visiteur10 = new Visiteur(10, "Girard", "Lucas", "0690123456", "lucas.girard@example.com");

            Visite uneVisite1 = new Visite(1, medecin1, visiteur2, new DateTime(2024, 08, 15), new TimeOnly(15, 30), 15, new TimeOnly(15, 45), false);
            Visite uneVisite2 = new Visite(2, medecin4, visiteur5, new DateTime(2024, 09, 20), new TimeOnly(14, 00), 15, new TimeOnly(15, 45), false);
            Visite uneVisite3 = new Visite(3, medecin2, visiteur8, new DateTime(2024, 11, 25), new TimeOnly(10, 50), 15, new TimeOnly(15, 45), false);
            Visite uneVisite4 = new Visite(4, medecin3, visiteur4, new DateTime(2024, 12, 30), new TimeOnly(16, 20), 15, new TimeOnly(15, 45), false);

            addMedecin(medecin1);
            addMedecin(medecin2);
            addMedecin(medecin3);
            addMedecin(medecin4);
            addVisiteur(visiteur1);
            addVisiteur(visiteur2);
            addVisiteur(visiteur3);
            addVisiteur(visiteur4);
            addVisiteur(visiteur5);
            addVisiteur(visiteur6);
            addVisiteur(visiteur7);
            addVisiteur(visiteur8);
            addVisiteur(visiteur9);
            addVisiteur(visiteur10);
            addVisite(uneVisite1);
            addVisite(uneVisite2);
            addVisite(uneVisite3);
            addVisite(uneVisite4);
        }

        public static async Task<List<Visiteur>> getLesVisiteurs()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIVisiteur.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (!response.IsSuccessStatusCode)
                    throw new Exception();
                repAPIenJson = response.Content.ReadAsStringAsync().Result;
                lesVisiteurs = JsonSerializer.Deserialize<List<Visiteur>>(repAPIenJson);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }
            return lesVisiteurs;
        }

        public static async Task ajouteVisiteur(string nom, string prenom, string tel, string mail)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIVisiteur.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("nom", nom));
                postData.Add(new KeyValuePair<string, string>("prenom", prenom));
                postData.Add(new KeyValuePair<string, string>("telephone", tel));
                postData.Add(new KeyValuePair<string, string>("email", mail));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);
                request.Content = new FormUrlEncodedContent(postData);
                HttpResponseMessage response = await client.PostAsync(url, new FormUrlEncodedContent(postData));
                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                    throw new Exception();


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }
        }

        public static async Task modifieVisiteur(string id, string nom, string prenom, string tel, string mail)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIVisiteur.php";

            string repAPIenJson;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("id", id));
                postData.Add(new KeyValuePair<string, string>("nom", nom));
                postData.Add(new KeyValuePair<string, string>("prenom", prenom));
                postData.Add(new KeyValuePair<string, string>("telephone", tel));
                postData.Add(new KeyValuePair<string, string>("email", mail));

                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), client.BaseAddress);
                request.Content = new FormUrlEncodedContent(postData);

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                    throw new Exception();


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }

        }

        public static async Task deleteVisiteur(int id)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIVisiteur.php";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                List<KeyValuePair<string, string>> deleteData = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("id", id.ToString())
        };

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url)
                {
                    Content = new FormUrlEncodedContent(deleteData)
                };

                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Problème lors de la suppression de l'utilisateur");
                Console.WriteLine(e.Message);
            }
        }

        // Medecin //

        public static async Task<List<Medecin>> getLesMedecins()
        {
            List<Medecin> lesMedecins = new List<Medecin>();
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIMedecin.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new
           MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (!response.IsSuccessStatusCode)
                    throw new Exception();
                repAPIenJson = response.Content.ReadAsStringAsync().Result;
                lesMedecins = JsonSerializer.Deserialize<List<Medecin>>(repAPIenJson);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }
            return lesMedecins;
        }

        public static async Task ajouteMedecin(string nom, string prenom, string tel, string mail, string rue, int numRue, int cp, string ville)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIMedecin.php";
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("nom", nom));
                postData.Add(new KeyValuePair<string, string>("prenom", prenom));
                postData.Add(new KeyValuePair<string, string>("telephone", tel));
                postData.Add(new KeyValuePair<string, string>("email", mail));
                postData.Add(new KeyValuePair<string, string>("rue", rue));
                postData.Add(new KeyValuePair<string, string>("numRue", numRue.ToString()));
                postData.Add(new KeyValuePair<string, string>("cp", cp.ToString()));
                postData.Add(new KeyValuePair<string, string>("ville", ville));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);
                request.Content = new FormUrlEncodedContent(postData);
                HttpResponseMessage response = await client.PostAsync(url, new FormUrlEncodedContent(postData));
                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                    throw new Exception();


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }
        }

        public static async Task modifieMedecin(string id, string nom, string prenom, string tel, string mail, string rue, int numRue, int cp, string ville)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIMedecin.php";

            string repAPIenJson;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("id", id));
                postData.Add(new KeyValuePair<string, string>("nom", nom));
                postData.Add(new KeyValuePair<string, string>("prenom", prenom));
                postData.Add(new KeyValuePair<string, string>("telephone", tel));
                postData.Add(new KeyValuePair<string, string>("email", mail));
                postData.Add(new KeyValuePair<string, string>("rue", rue));
                postData.Add(new KeyValuePair<string, string>("numRue", numRue.ToString()));
                postData.Add(new KeyValuePair<string, string>("cp", cp.ToString()));
                postData.Add(new KeyValuePair<string, string>("ville", ville));

                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), client.BaseAddress);
                request.Content = new FormUrlEncodedContent(postData);

                HttpResponseMessage response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (!response.IsSuccessStatusCode)
                    throw new Exception();


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }

        }

        public static async Task deleteMedecin(int id)
        {
            string url = "https://s5-4237.nuage-peda.fr/VTT/APIMedecin.php";
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                List<KeyValuePair<string, string>> deleteData = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("id", id.ToString())
        };

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, url)
                {
                    Content = new FormUrlEncodedContent(deleteData)
                };

                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Problème lors de la suppression de l'utilisateur");
                Console.WriteLine(e.Message);
            }
        }


    }
}
