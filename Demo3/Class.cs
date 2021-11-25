using System;

namespace Demo3
{
    public record Personne(string prenom, string Nom);
    //public class Class
    //{

    //}

    public class Enfant
    {
        public string Prenom { get; init; }
        public string Nom { get; init; }

        public Enfant(string  prenom,string nom)
        {
            Prenom = prenom;
            Nom = Nom;
        }
    }
}

