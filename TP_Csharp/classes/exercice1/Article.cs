namespace TP_Csharp.classes.exercice1;

public class Article
{
    private string nom;
    private string reference;
    private double prixUnitaire;


    public Article(){
        this.nom = "";
        this.reference = "";
        this.prixUnitaire = 0.0;
    }

    public Article(string nom, string reference, double prixUnitaire){
        this.nom = nom;
        this.reference = reference;
        this.prixUnitaire = prixUnitaire;
    }

    public Article(Article _article){
        this.nom = _article.nom;
        this.reference = _article.reference;
        this.prixUnitaire = _article.prixUnitaire;
    }

    public string Nom{
        get{return nom;}
        set{nom = value;}
    }

    public string Reference{
        get{return reference;}
        set{reference = value;}
    }

    public double PrixUnitaire{
        get{return prixUnitaire;}
        set{prixUnitaire=value;}
    }

    public void affiche(){
        Console.WriteLine($"le nom de l'article est : {nom}");
        Console.WriteLine($"la référence de l'article est : {reference}");
        Console.WriteLine($"le prix unitaire de l'article est : {prixUnitaire}");
    }


}
