using Demo3;
using Demo22;
using System;
Console.WriteLine("Hello World!");
Console.WriteLine($"Somme de x et y = :{Addition(10,5)}");


 static double Addition(double x, double y)
{
    return x + y;
}

// Démo2

EmployeModel employe1 = new EmployeModel { Id = 1, Prenom = "Nestor", Nom = "Kameni" };
Console.WriteLine($"Bonjour {employe1.Prenom} {employe1.Nom} ({employe1.Id})");

//employe1.Id = 2;
employe1.Prenom = "Joe";

//var employe2 = new EmployeModel(2, "Joe", "Bloe");

//Demo3

Personne p1 = new("Abdel", "joe");
Personne p2 = new("Abdel", "joe");
Personne p3 = new("Alice", "joe");

Console.WriteLine("type record:");
Console.WriteLine($"Les deux objets sont égaux:{Equals(p1,p2)}");
Console.WriteLine($"Les deux objets ont la même référence:{ReferenceEquals(p1, p2)}");
Console.WriteLine($"Les deux objets ==:{p1==p2}");
Console.WriteLine($"Les deux objets !=:{p1 != p2}");
Console.WriteLine($"Hash de l'objet p1:{p1.GetHashCode()}");
Console.WriteLine($"Hash de l'objet p1:{p2.GetHashCode()}");
Console.WriteLine($"Hash de l'objet p1:{p3.GetHashCode()}");

Console.WriteLine("****************************************************************");
Console.WriteLine("type class:");
Enfant e1 = new("jean", "Denis");
Enfant e2 = new ("jean", "Denis");
Enfant e3 = new ("Bob", "Lagachette");
Console.WriteLine($"Les deux objets sont égaux:{Equals(e1, e2)}");
Console.WriteLine($"Les deux objets ont la même référence:{ReferenceEquals(e1, e2)}");
Console.WriteLine($"Les deux objets ==:{e1 == e2}");
Console.WriteLine($"Les deux objets !=:{e1 != e2}");
Console.WriteLine($"Hash de l'objet p1:{e1.GetHashCode()}");
Console.WriteLine($"Hash de l'objet p1:{e1.GetHashCode()}");
Console.WriteLine($"Hash de l'objet p1:{e3.GetHashCode()}");


//Demo4: 

var p4 = p1 with { prenom = "Nestor" };