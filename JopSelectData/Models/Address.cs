namespace JopSelectData.Models;

public class Address: BaseModel
{
    public Guid AddressId { get; set; }
    public string Postal { get; set; }
    public string Street { get; set; }
    public ushort HouseNumber { get; set; }
    public City City { get; set; }
    public Country Country { get; set; }
}