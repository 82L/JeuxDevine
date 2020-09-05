using System;
using System.Diagnostics;


namespace JeuxDevine
{
    class Devine
    {   
        private int _nombreEntre;
        private int _nombreSecret;
        private string _nom;
        private int _coups;
        private int result;
        private string Profile;
        private double resprofil;
        public Devine(int _nouveaunombre, string _joueur)
        {
            _nombreEntre = _nouveaunombre;
            _nom = _joueur;
            _coups = 0;
        }
    public void DetermineNombreSecret()
        {
            Random rnd = new Random();
            _nombreSecret = rnd.Next(0, _nombreEntre);
        }
  
        public int nombrejoue(int _nombredonne)
            {
              if (_nombredonne == _nombreSecret)
              {
                  result=1; // Correspond au bon resultat !
            }
              else if (_nombredonne < _nombreSecret)
              {
                  result=2; // Correspond à un resultat trop petit !
            }
              else if (_nombredonne > _nombreSecret)
              {
                  result=3; // Correspond à un resultat trop grand !
            }
               _coups++;
               return result; 
              }

        private double qualite()
        {
            double resprofil;
            resprofil = Math.Log(_nombreEntre, 2); // Correspond au nombre de coup rationnel
            return resprofil;
        }

        public string DefineProfile()
        {
            resprofil = Math.Round(qualite());
            if (_coups > resprofil) //Si le nombre de coup joué est supérieur au nombre rationnel
            {
                Profile = "Pas très malin";
            } 
            else if (_coups < resprofil) // Si le nombre de coup joué est inférieur au nombre rationnel
            {
                Profile = "Chanceux (ou intuitif)";
            }
            else //Si le nombre de coup joué est égal au nombre rationnel
            {
                Profile = "Rationnel";
            }
            return Profile;
        }

     }
}

