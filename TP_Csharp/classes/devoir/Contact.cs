namespace TP_Csharp.classes.devoir;

public class Contact
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string NumeroTelephone { get; set; }
    public string Email { get; set; }

    public Contact(int id, string nom, string numeroTelephone, string email)
    {
        ID = id;
        Nom = nom;
        NumeroTelephone = numeroTelephone;
        Email = email;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"ID: {ID}, Nom: {Nom}, Téléphone: {NumeroTelephone}, Email: {Email}");
    }

}
