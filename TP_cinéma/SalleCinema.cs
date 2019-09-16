﻿using System;
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
        private double prixUnitaire;
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

        public double getPrix()
        {
            return this.prixUnitaire;
        }

        public void setPrix(double p)
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
            nbPlacesdispo = this.nbPlacesSalle - (this.nbPlacesNormal + this.nbPlacesReduites);

            return nbPlacesdispo;
        }

        public bool vendrePlaces(int nbre, bool tarifReduit)        {

            if (tarifReduit == true)
            {
                this.prixUnitaire = this.nbPlacesReduites;

            }
            else
            {
                this.prixUnitaire = this.nbPlacesNormal;

            }

            if (nbre > nbPlacesDisponibles())
            {

                return false;

            }
            else
            {

                this.nbPlacesSalle = this.nbPlacesSalle - nbre;
                return true;

            }
        }

        public int remiseAZero()
            {
                 return 0; 
            }

        public double chiffreAffaires()
        {
            double chiffre = this.nbPlacesNormal + this.nbPlacesReduites;
            return chiffre;
        }


        public double tauxRemplissage()
        {
            double taux = (this.nbPlacesReduites + this.nbPlacesNormal) * 100 / this.nbPlacesSalle;
            return taux;

        }

        public string ToString()
        {

            return ("Film joué" + this.titre + ", Nombre de places: " + this.prixUnitaire + ", Prix de la place: " + this.prixUnitaire + nbPlacesReduites + " places vendues à tarif réduit" + nbPlacesNormal + " places vendues à tarif normal");

        }


    }


    }

