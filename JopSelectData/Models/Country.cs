namespace JopSelectData.Models;

public class Country: BaseModel
{
    public Guid CountryId { get; set; }
    public string Name { get; set; }
}