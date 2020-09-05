using System;

namespace JeuxDevine
{
    class Program
    {
        static void Main(string[] args)
        {
            IHM ihm = new IHM();
            ihm.jeux();

            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }
    }
}
