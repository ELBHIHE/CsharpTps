namespace TP_Csharp.classes.exercice2;

public class Personne
{

    private string nom;
    private string prenom;
    private int age;

    public Personne(string nom, string prenom, int age){
        this.nom = nom;
        this.prenom = prenom;
        this.age = age;
    }

    public void getInfo(){
        Console.WriteLine($"le nom est : {nom}");
        Console.WriteLine($"le prenom est : {prenom}");
        Console.WriteLine($"l'age est : {age}");
    }

   



}
