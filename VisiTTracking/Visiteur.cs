using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiTTracking
{
    /// <summary>
    /// Classe visiteur
    /// </summary>
    public class Visiteur : Personne
    {
        /// <summary>
        /// Constructeur de la classe visiteur (personne)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        private string nom;
        public string Nom
        {
            get => nom;
            set
            {
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Le nom ne doit pas contenir de chiffres.");
                nom = value;
            }
        }

        private string prenom;
        public string Prenom
        {
            get => prenom;
            set
            {
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Le prénom ne doit pas contenir de chiffres.");
                prenom = value;
            }
        }

        public Visiteur(int id, string nom, string prenom, string telephone, string email) : base(id, nom, prenom, telephone, email)
        {
            if (nom.Any(char.IsDigit))
                throw new ArgumentException("Le nom ne doit pas contenir de chiffres.");
            if (prenom.Any(char.IsDigit))
                throw new ArgumentException("Le prénom ne doit pas contenir de chiffres.");
        }
    }
}
