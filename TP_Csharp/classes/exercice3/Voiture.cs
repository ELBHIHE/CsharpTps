namespace TP_Csharp.classes.exercice3;

public class Voiture
{
    private string marque;
    private string couleur;
    private string matricule;
    private int nbChevaux;

    public string Marque{
        get{return marque;}
        set{marque = value;}
    }

    public string Couleur{
        get{return couleur;}
        set{couleur = value;}
    }

    public string Matricule{
        get{return matricule;}
    }

    public int NbChevaux{
        get{return nbChevaux;}
        set{nbChevaux = value;}
    }

    public Voiture(string marque,string couleur,string matricule,int nbChevaux){
        this.marque = marque;
        this.couleur = couleur;
        this.matricule = matricule;
        this.nbChevaux = nbChevaux;
    }

    public void presentation(){
        Console.WriteLine($"La marque de la voiture est : {marque}");
        Console.WriteLine($"La couleur de la voiture est : {couleur}");
        Console.WriteLine($"Le matricule de la voiture est : {matricule}");
        Console.WriteLine($"Le nombre de chevaux de la voiture est : {nbChevaux}");
    }

     public void augmenterChevaux(){
        this.nbChevaux++;
    }

}
