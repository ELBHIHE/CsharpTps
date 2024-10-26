namespace TP_Csharp.classes.exercice4;

public class Consultant: Employe
{
    public double TauxHoraire { get; set; }
    public int HeuresTravaillees { get; set; }

    public Consultant(string nom, int numeroEmploye, double tauxHoraire, int heuresTravaillees)
        : base(nom, numeroEmploye)
    {
        TauxHoraire = tauxHoraire;
        HeuresTravaillees = heuresTravaillees;
    }

    public override void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine($"Taux Horaire : {TauxHoraire} DH, Heures Travaillées : {HeuresTravaillees}");
    }
}

