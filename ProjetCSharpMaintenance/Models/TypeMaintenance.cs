using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCSharpMaintenance.Models;

[Table("TypeMaintenance")]
public class TypeMaintenance
{
    [PrimaryKey]
    public Guid Id { get; set; }
    public string Libelle { get; set; }
    public string Description { get; set; }
    public int Etat { get; set; }
    public Guid UtilisateurId { get; set; }

}
