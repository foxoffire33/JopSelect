using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Resume: BaseModel
{
    public Guid ResumeID { get; set; }
    
    public City BirthPlace { get; set; }
    public NationalityType Nationality { get; set; }
    public Address AddressID { get; set; }
    public int Phone { get; set; }
    public string Description { get; set; }
}
