using System;
using System.Collections.Generic;
using TP_Csharp.classes.exercice1;
using TP_Csharp.classes.exercice2;
using TP_Csharp.classes.exercice3;
using TP_Csharp.classes.exercice4;
using TP_Csharp.classes.devoir;

namespace TP_Csharp
{
    class Program
    {
        static List<Article> articles = new List<Article>();
        static List<Personne> personnes = new List<Personne>();
        static Voiture[] voitures = new Voiture[5];
        static List<Employe> employes = new List<Employe>();
        static GestionnaireContacts gestionnaire = new GestionnaireContacts();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n---- Menu Principal ----");
                Console.WriteLine("1. Exercice 1 : Article");
                Console.WriteLine("2. Exercice 2 : Personne");
                Console.WriteLine("3. Exercice 3 : Voiture");
                Console.WriteLine("4. Exercice 4 : Employé");
                Console.WriteLine("5. Devoir : Gestionnaire de Contacts");
                Console.WriteLine("0. Quitter");
                Console.Write("Choisissez un exercice : ");
                
                int choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        MenuExercice1();
                        break;
                    case 2:
                        MenuExercice2();
                        break;
                    case 3:
                        MenuExercice3();
                        break;
                    case 4:
                        MenuExercice4();
                        break;
                    case 5:
                        MenuDevoir();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        static void MenuExercice1()
        {
            Console.WriteLine("\n---- Menu Exercice 1 : Article ----");
            Console.WriteLine("1. Créer un article");
            Console.WriteLine("2. Afficher les articles");
            Console.WriteLine("0. Retour");
            Console.Write("Votre choix : ");
            
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Write("Nom de l'article : ");
                    string nom = Console.ReadLine();
                    Console.Write("Code de l'article : ");
                    string code = Console.ReadLine();
                    Console.Write("Prix de l'article : ");
                    double prix = double.Parse(Console.ReadLine());
                    articles.Add(new Article(nom, code, prix));
                    Console.WriteLine("Article créé !");
                    break;
                case 2:
                    if (articles.Count == 0)
                        Console.WriteLine("Aucun article n'a été créé.");
                    else
                        articles.ForEach(a => a.affiche());
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }

        static void MenuExercice2()
        {
            Console.WriteLine("\n---- Menu Exercice 2 : Personne ----");
            Console.WriteLine("1. Ajouter une personne");
            Console.WriteLine("2. Afficher les informations des personnes");
            Console.WriteLine("0. Retour");
            Console.Write("Votre choix : ");
            
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Write("Nom : ");
                    string nom = Console.ReadLine();
                    Console.Write("Prénom : ");
                    string prenom = Console.ReadLine();
                    Console.Write("Âge : ");
                    int age = int.Parse(Console.ReadLine());
                    personnes.Add(new Personne(nom, prenom, age));
                    Console.WriteLine("Personne ajoutée !");
                    break;
                case 2:
                    if (personnes.Count == 0)
                        Console.WriteLine("Aucune personne n'a été ajoutée.");
                    else
                        personnes.ForEach(p => p.getInfo());
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }

        static void MenuExercice3()
        {
            Console.WriteLine("\n---- Menu Exercice 3 : Voiture ----");
            Console.WriteLine("1. Ajouter une voiture");
            Console.WriteLine("2. Afficher les informations des voitures");
            Console.WriteLine("3. Augmenter les chevaux de toutes les voitures");
            Console.WriteLine("0. Retour");
            Console.Write("Votre choix : ");
            
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Write("Marque de la voiture : ");
                    string marque = Console.ReadLine();
                    Console.Write("Couleur : ");
                    string couleur = Console.ReadLine();
                    Console.Write("Plaque d'immatriculation : ");
                    string immatriculation = Console.ReadLine();
                    Console.Write("Nombre de chevaux : ");
                    int chevaux = int.Parse(Console.ReadLine());
                    voitures[0] = new Voiture(marque, couleur, immatriculation, chevaux);
                    Console.WriteLine("Voiture ajoutée !");
                    break;
                case 2:
                    bool anyVoiture = false;
                    foreach (var voiture in voitures)
                    {
                        if (voiture != null)
                        {
                            voiture.presentation();
                            anyVoiture = true;
                        }
                    }
                    if (!anyVoiture) Console.WriteLine("Aucune voiture n'a été ajoutée.");
                    break;
                case 3:
                    foreach (var voiture in voitures)
                    {
                        voiture?.augmenterChevaux();
                    }
                    Console.WriteLine("Nombre de chevaux augmenté pour toutes les voitures.");
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }

        static void MenuExercice4()
        {
            Console.WriteLine("\n---- Menu Exercice 4 : Employé ----");
            Console.WriteLine("1. Ajouter un employé à temps plein");
            Console.WriteLine("2. Ajouter un consultant");
            Console.WriteLine("3. Afficher les détails des employés");
            Console.WriteLine("0. Retour");
            Console.Write("Votre choix : ");
            
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Write("Nom de l'employé : ");
                    string nom = Console.ReadLine();
                    Console.Write("ID de l'employé : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Salaire de base : ");
                    double salaire = double.Parse(Console.ReadLine());
                    employes.Add(new EmployeATempsPlein(nom, id, salaire));
                    Console.WriteLine("Employé à temps plein ajouté !");
                    break;
                case 2:
                    Console.Write("Nom du consultant : ");
                    nom = Console.ReadLine();
                    Console.Write("ID du consultant : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Tarif horaire : ");
                    double tarifHoraire = double.Parse(Console.ReadLine());
                    Console.Write("Nombre d'heures travaillées : ");
                    int heures = int.Parse(Console.ReadLine());
                    employes.Add(new Consultant(nom, id, tarifHoraire, heures));
                    Console.WriteLine("Consultant ajouté !");
                    break;
                case 3:
                    if (employes.Count == 0)
                        Console.WriteLine("Aucun employé n'a été ajouté.");
                    else
                        employes.ForEach(e => e.AfficherDetails());
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }

        static void MenuDevoir()
        {
            Console.WriteLine("\n---- Menu Devoir : Gestionnaire de Contacts ----");
            Console.WriteLine("1. Ajouter un contact");
            Console.WriteLine("2. Modifier un contact");
            Console.WriteLine("3. Supprimer un contact");
            Console.WriteLine("4. Afficher les contacts");
            Console.WriteLine("0. Retour");
            Console.Write("Votre choix : ");
            
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    Console.Write("Nom du contact : ");
                    string nom = Console.ReadLine();
                    Console.Write("Téléphone : ");
                    string telephone = Console.ReadLine();
                    Console.Write("Email : ");
                    string email = Console.ReadLine();
                    gestionnaire.AjouterContact(nom, telephone, email);
                    break;
                case 2:
                    Console.Write("ID du contact à modifier : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nouveau nom : ");
                    nom = Console.ReadLine();
                    Console.Write("Nouveau téléphone : ");
                    telephone = Console.ReadLine();
                    Console.Write("Nouvel email : ");
                    email = Console.ReadLine();
                    gestionnaire.ModifierContact(id, nom, telephone, email);
                    break;
                case 3:
                    Console.Write("ID du contact à supprimer : ");
                    id = int.Parse(Console.ReadLine());
                    gestionnaire.SupprimerContact(id);
                    break;
                case 4:
                    gestionnaire.AfficherContacts();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }
        }
    }
}
