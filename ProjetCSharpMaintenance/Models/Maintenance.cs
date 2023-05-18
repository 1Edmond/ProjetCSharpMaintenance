using SQLite;

namespace ProjetCSharpMaintenance.Models;

[Table("Maintenance")]
public class Maintenance
{
    [PrimaryKey]
    public Guid Id { get; set; }

    public string Libelle { get; set; }
    public string Description { get; set; }
    public int Etat { get; set; }
    public Guid UtilisateurId { get; set; }
    public Guid TypeMaintenanceId { get; set; }

    [Ignore]
    public TypeMaintenance  TypeMaintenance { get; set; }

}
