namespace TP_Csharp.classes.exercice4;

public class Employe
{

    public string Nom { get; set; }
    public int NumeroEmploye { get; set; }

    public Employe(string nom, int numeroEmploye)
    {
        Nom = nom;
        NumeroEmploye = numeroEmploye;
    }

    public virtual void AfficherDetails()
    {
        Console.WriteLine($"Nom : {Nom}, Numéro d'employé : {NumeroEmploye}");
    }

}
