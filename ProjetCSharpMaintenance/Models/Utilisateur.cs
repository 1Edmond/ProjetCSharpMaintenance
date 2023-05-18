using SQLite;

namespace ProjetCSharpMaintenance.Models;

[Table("Utilisateur")]
public class Utilisateur
{
    [PrimaryKey]
    public Guid Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Pseudo { get; set; }
    public string Password { get; set; }
    public int Etat { get; set; }
    public UtilisateurRole Role { get; set; }

}
