using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiTTracking
{
    /// <summary>
    /// Classe visite
    /// </summary>
    public class Visite
    {
        public int id;
        private Medecin medecin;
        private Visiteur visiteur;
        private DateTime dateVisite;
        private TimeOnly heureArrive;
        private int tempsAttente;
        private TimeOnly heureDepart;
        private bool avecRdv;

        /// <summary>
        /// Constructeur Visite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="medecin"></param>
        /// <param name="visiteur"></param>
        /// <param name="dateVisite"></param>
        /// <param name="heureArrive"></param>
        /// <param name="tempsAttente"></param>
        /// <param name="heureDepart"></param>
        /// <param name="avecRdv"></param>
        public Visite(int id, Medecin medecin, Visiteur visiteur, DateTime dateVisite, TimeOnly heureArrive, int tempsAttente, TimeOnly heureDepart, bool avecRdv)
        {
            this.id = id;
            this.medecin = medecin;
            this.visiteur = visiteur;
            this.dateVisite = dateVisite;
            this.heureArrive = heureArrive;
            this.tempsAttente = tempsAttente;
            this.heureDepart = heureDepart;
            this.avecRdv = avecRdv;
        }

        /// <summary>
        /// Récupère l'id
        /// </summary>
        /// <returns>Renvoie l'id</returns>
        public int getId() { return this.id; }
        /// <summary>
        /// Récupère le médecin
        /// </summary>
        /// <returns>Renvoie le médecin</returns>
        public Medecin getMedecin() {  return this.medecin; }
        /// <summary>
        /// Récupère le visiteur
        /// </summary>
        /// <returns>Renvoie le visiteur</returns>
        public Visiteur getVisiteur() {  return this.visiteur; }
        /// <summary>
        /// Récupère la date de visite
        /// </summary>
        /// <returns>Renvoie la date de visite</returns>
        public DateTime getDateVisite() {  return this.dateVisite; }
        /// <summary>
        /// Recupère l'heure d'arrive
        /// </summary>
        /// <returns>Renvoie l'heure d'arrive</returns>
        public TimeOnly getHeureArrive() {  return this.heureArrive; }
        /// <summary>
        /// Récupère le temps d'attente
        /// </summary>
        /// <returns>Renvoie le temps d'attente</returns>
        public int getTempsAttente() {  return this.tempsAttente; }
        /// <summary>
        /// Récupère l'heure de départ
        /// </summary>
        /// <returns>Renvoie l'heure de départ</returns>
        public TimeOnly getHeureDepart() {  return this.heureDepart; }
        /// <summary>
        /// Recupère s'il y a un rendez vous
        /// </summary>
        /// <returns>Renvoie s'il y a un rendez vous</returns>
        public bool getAvecRdv() {  return this.avecRdv; }

        
        /// <summary>
        /// Définit l'id
        /// </summary>
        /// <param name="id"></param>
        public void setId(int id) { this.id = id; }
        /// <summary>
        /// Définit le médecin
        /// </summary>
        /// <param name="medecin"></param>
        public void setMedecin(Medecin medecin) {  this.medecin = medecin; }
        /// <summary>
        /// Définit le visiteur
        /// </summary>
        /// <param name="visiteur"></param>
        public void setVisiteur(Visiteur visiteur) {  this.visiteur = visiteur; }
        /// <summary>
        /// Définit la date de visite
        /// </summary>
        /// <param name="dateVisite"></param>
        public void setDateVisite(DateTime dateVisite) {  this.dateVisite = dateVisite; }
        /// <summary>
        /// Définit l'heure d'arrive
        /// </summary>
        /// <param name="heureArrive"></param>
        public void setHeureArrive(TimeOnly heureArrive) { this.heureArrive = heureArrive; }
        /// <summary>
        /// Définit le temps d'attente
        /// </summary>
        /// <param name="tempsAttente"></param>
        public void setTempsAttente(int tempsAttente) { this.tempsAttente = tempsAttente; }
        /// <summary>
        /// Définit l'heure de départ
        /// </summary>
        /// <param name="heureDepart"></param>
        public void setHeureDepart(TimeOnly heureDepart) { this.heureDepart = heureDepart; }
        /// <summary>
        /// Définit s'il a un rendez vous
        /// </summary>
        /// <param name="avecRdv"></param>
        public void setAvecRdv(bool avecRdv) { this.avecRdv = avecRdv; }

        /// <summary>
        /// Transforme l'objet en chaine de caractère
        /// </summary>
        /// <returns>Renvoie l'objet sous forme de chaine de caractère</returns>
        public override string ToString()
        {
            string message = "Id : " + this.id
                + "\nMedecin : " + this.medecin.ToString()
                + "\nVisiteur : " + this.visiteur.ToString()
                + "\nDate Visite : " + this.dateVisite.ToString()
                + "\nHeure d'arrivée : " + this.heureArrive.ToString() 
                + "\nTemps d'attente : " + this.tempsAttente.ToString()
                + "\nHeure de départ : " + this.heureDepart.ToString()
                + "\nAvec rendez-vous : " + this.avecRdv.ToString();
            return message;
        }

    }
}
