using JopSelectData.Enums;

namespace JopSelectData.Models;

public class CarLicense: BaseModel
{
    public Guid CarLicenseId { get; set; }
    public ModelType ModelType { get; set; }
    public CarLicenseType CarLicenseType { get; set; }
}
