using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VisiTTracking
{
    /// <summary>
    /// Classe Médecin (Personne)
    /// </summary>
    public class Medecin : Personne
    {
        private string rue;
        private int numRue;
        private int cp;
        private string ville;

        /// <summary>
        /// Constructeur de la classe medecin
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        /// <param name="rue"></param>
        /// <param name="numRue"></param>
        /// <param name="cp"></param>
        /// <param name="ville"></param>
        public Medecin(int id, string nom, string prenom, string telephone, string email, string rue, int numRue, int cp, string ville) : base(id, nom, prenom, telephone, email)
        {
            this.rue = rue;
            this.numRue = numRue;
            this.cp = cp;
            this.ville = ville;
        }

        /// <summary>
        /// Récupère ou définit la rue
        /// </summary>
        [JsonPropertyName("rue")]
        public string Rue { get => rue; set => rue = value; }

        /// <summary>
        /// Récupère ou définit le numéro de la rue
        /// </summary>
        [JsonPropertyName("numRue")]
        public int NumRue { get => numRue; set => numRue = value; }

        /// <summary>
        /// Récupère ou définit le code postal
        /// </summary>
        [JsonPropertyName("cp")]
        public int Cp { get => cp; set => cp = value; }

        /// <summary>
        /// Récupère ou définit la ville
        /// </summary>
        [JsonPropertyName("ville")]
        public string Ville { get => ville; set => ville = value; }


        public override string ToString()
        {
            string message = base.ToString();
            message = message + "\nRue : " + this.rue
                + "\nNuméro de rue : " + this.numRue.ToString()
                + "\nCode Postal : " + this.cp
                + "\nVille : " + this.ville;
            return message;
        }
    }
}
