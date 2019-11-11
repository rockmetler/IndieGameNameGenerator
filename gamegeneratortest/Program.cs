using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamegeneratortest
{
    class Program
    {
        public static string[] Genre = { "Roguelike", "Shooter", "Stealth", "RPG", "Racer", "Adventure" };
        public static string[] Adjectives = new AdjectiveClass().Adjectives;
        public static string[] Nouns = new NounClass().Nouns;
        public static string[] Verbs = new VerbClass().Verbs;

        static string generator()
        {
            Random rnd = new Random();
            Random namernd = new Random();
            string G = Genre[rnd.Next(0, Genre.Length)];
            string N = Nouns[rnd.Next(0, Nouns.Length)];
            string N2 = Nouns[rnd.Next(0, Nouns.Length)];
            string Adj = Adjectives[rnd.Next(0, Adjectives.Length)];
            string V = Verbs[rnd.Next(0, Verbs.Length)];

            switch (namernd.Next(0, 6))
            {
                case 0:
                    return (string.Format("Your game is a {0} called: The {1} Of {2}", G, N, N2));
                    
                case 1:
                    return (string.Format("Your game is a {0} called: {1} Of {2}", G, N, V));
                case 2:
                    return (string.Format("Your game is a {0} called: {1} the {2}", G, V, N));
                    
                case 3:
                    return (string.Format("your game is a {0} called: {1} {2}", G, Adj, N));
                    
                case 4:
                    return (string.Format("your game is a {0} called: {1} of {2}", G, N, V));
                    
                case 5:
                    return (string.Format("your game is a {0} called: {1} the {2} {3}", G, V, Adj, N));
                    
                case 6:
                    return (string.Format("your game is a {0} called: {1} all {2}s", G, V, N));
                    
            }
            return "something went wrong";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(generator());
            Console.ReadLine();
        }
    }
}
