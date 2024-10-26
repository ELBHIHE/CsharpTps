namespace TP_Csharp.classes.devoir;

public class GestionnaireContacts
{
    private List<Contact> contacts = new List<Contact>();
    private int idCounter = 1;

    public void AjouterContact(string nom, string numeroTelephone, string email)
    {
        var contact = new Contact(idCounter++, nom, numeroTelephone, email);
        contacts.Add(contact);
        Console.WriteLine("Contact ajouté avec succès !");
    }

    public void ModifierContact(int id, string nom, string numeroTelephone, string email)
    {
        var contact = contacts.FirstOrDefault(c => c.ID == id);
        if (contact != null)
        {
            contact.Nom = nom;
            contact.NumeroTelephone = numeroTelephone;
            contact.Email = email;
            Console.WriteLine("Contact modifié avec succès !");
        }
        else
        {
            Console.WriteLine("Contact non trouvé.");
        }
    }

    public void AfficherContacts()
    {
        if (contacts.Count > 0)
        {
            Console.WriteLine("Liste des contacts:");
            foreach (var contact in contacts)
            {
                contact.AfficherDetails();
            }
        }
        else
        {
            Console.WriteLine("Aucun contact à afficher.");
        }
    }

    public void SupprimerContact(int id)
    {
        var contact = contacts.FirstOrDefault(c => c.ID == id);
        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine("Contact supprimé avec succès !");
        }
        else
        {
            Console.WriteLine("Contact non trouvé.");
        }
    }

}
