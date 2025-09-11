using System.Text.Json.Serialization;

namespace VisiTTracking
{
    /// <summary>
    /// Classe Personne
    /// </summary>
    public abstract class Personne
    {
        public int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;

        /// <summary>
        /// Constructeur de Personne
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        public Personne(int id, string nom, string prenom, string telephone, string email)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.email = email;
        }

        /// <summary>
        /// Récupère ou définit l'id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Récupère ou définit le nom
        /// </summary>
        [JsonPropertyName("nom")]
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Récupère ou définit le prénom
        /// </summary>
        [JsonPropertyName("prenom")]
        public string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Récupère ou définit le numéro de téléphone
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get => telephone; set => telephone = value; }

        /// <summary>
        /// Récupère ou définit l'adresse email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Renvoie les données de l'objet sous forme de chaine
        /// </summary>
        /// <returns>Renvoie une chaine de caractère</returns>
        public override string ToString()
        {
            string message = "Id : " + this.id
                + "\nNom : " + this.nom
                + "\nPrenom : " + this.prenom
                + "\nTelephone : " + this.telephone
                + "\nEmail : " + this.email;
            return message;
        }
    }
}
