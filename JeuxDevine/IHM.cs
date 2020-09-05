using System;

namespace JeuxDevine
{
    class IHM
    {
        public void jeux()
        {
            int result=0;
            int _nbsaisie;
            int _nombreMaxSaisie;
            string _nomJoueur;

            // Saisie du nom du joueur et la valeur du
            // nombre maximal qu'il veut trouver
            _nomJoueur = ReadStringConsole("Entrez votre nom : ");
            while (_nomJoueur == "") // Vérification si le joueur a entré un nom
            {
                _nomJoueur = ReadStringConsole("Entrez un nom correct : ");
            }

            _nombreMaxSaisie = ReadIntegerConsole("Entrez un nombre > 0 : ");
            while (_nombreMaxSaisie <= 0) // Vérification si le nombre max est correct
            {
                _nombreMaxSaisie = ReadIntegerConsole("Veuillez entrer un nombre supérieur à 0 : ");
            }



            // création d'un représentant du jeu (un objet)
            // en fournissant la limite supérieure de
            // l'intervalle dans lequel le nombre secret
            // sera extrait : [0..n[
            // ainsi que le nom du joueur
            Devine devine = new Devine(_nombreMaxSaisie, _nomJoueur);
            // Lancement de l'initialisation du nombre aléatoire ainsi que le nom du joueur
            devine.DetermineNombreSecret();
            // on demande au programme de tirer un nombre aléatoire
            // séquence d'interactions avec l'utilisateur
            // jusqu'à ce que l'utilisateur trouve le nombre secret
            // ou abandonne.

            while (result != 1)
            {
                _nbsaisie = ReadIntegerConsole(" Veuillez entrer un nombre : ");
                result = devine.nombrejoue(_nbsaisie);
              
                switch(result)
                {   
                    case 1 : // Correspond au bon resultat !
                        Console.WriteLine(" Nombre Correct, Félicitation ");
                        break;
                    case 2: // Correspond à un resultat trop petit !
                        Console.WriteLine(" Nombre Incorrect, essayer un nombre plus grand ");
                        break;
                    case 3: // Correspond à un resultat trop grand !
                        Console.WriteLine(" Nombre Incorrect, essayer un nombre plus petit ");
                        break;
                }

            }
            Console.WriteLine(devine.DefineProfile());
        }

        private string ReadStringConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private int ReadIntegerConsole(string message)
        {
            int valInt = 0;
            string input = string.Empty;

            do
            {
                input = ReadStringConsole(message);
            } while (!int.TryParse(input, out valInt));

            return valInt;
        }

    }
}
