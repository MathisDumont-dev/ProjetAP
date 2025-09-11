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
        public Visiteur(int id, string nom, string prenom, string telephone, string email) : base(id, nom, prenom, telephone, email)
        {

        }
    }
}
