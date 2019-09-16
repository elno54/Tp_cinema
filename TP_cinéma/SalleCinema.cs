using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_cinéma
{
    class SalleCinema
    {
        private string titre;
        private int nbPlacesSalle;
        private float prixUnitaire;
        private int nbPlacesNormal;
        private int nbPlacesReduites;


        public SalleCinema(string leTitre, int nbPsalle, float lePunitaire, int nbPnormal, int nbPreduites)
        {
            this.titre = leTitre;
            this.nbPlacesSalle = nbPsalle;
            this.prixUnitaire = lePunitaire;
            this.nbPlacesNormal = nbPnormal;
            this.nbPlacesReduites = nbPreduites;
        }

        public string getTitre()
        {
            return this.titre;
        }

        public void setTitre(string t)
        {
            this.titre = t;
        }

        public int getnbPlaces()
        {
            return this.nbPlacesSalle;
        }

        public void setnbPlaces(int nb)
        {
            this.nbPlacesSalle = nb;
        }

        public float getPrix()
        {
            return this.prixUnitaire;
        }

        public void setPrix(float p)
        {
            this.prixUnitaire = p;
        }

        public int getnbN()
        {
            return this.nbPlacesNormal;
        }

        public void setnbN(int nN)
        {
            this.nbPlacesNormal = nN;
        }

        public int getnbR()
        {
            return this.nbPlacesReduites;
        }

        public void setnbR(int nR)
        {
            this.nbPlacesReduites = nR;
        }

        public int nbPlacesDisponibles()
        {
            int nbPlacesdispo;
            nbPlacesdispo = nbPlacesSalle - (nbPlacesNormal + nbPlacesReduites);

            return nbPlacesdispo;
        }


    }
}
