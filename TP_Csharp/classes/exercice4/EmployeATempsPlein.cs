namespace TP_Csharp.classes.exercice4;

public class EmployeATempsPlein: Employe
{
    public double SalaireMensuel { get; set; }

    public EmployeATempsPlein(string nom, int numeroEmploye, double salaireMensuel)
        : base(nom, numeroEmploye)
    {
        SalaireMensuel = salaireMensuel;
    }

    public override void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine($"Salaire Mensuel : {SalaireMensuel} DH");
    }
}