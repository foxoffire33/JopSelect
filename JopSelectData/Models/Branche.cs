using System.ComponentModel.DataAnnotations.Schema;

namespace JopSelectData.Models;

public class Branche: BaseModel
{
    public Guid BrancheID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}