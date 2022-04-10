using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Experiance: BaseModel
{
    public Guid ExperianceId { get; set; }
    public ExperianceType ExperianceType { get; set; }
    public string Function { get; set; }

    public DateOnly StartDateOnly  { get; set; }
    public DateOnly EndedDateOnly { get; set; }

    public string Description { get; set; }

    public Guid CompanyId { get; set; }
    public Company Company { get; set; }

    public Guid ResumeId { get; set; }
    public Resume Resume { get; set; }
    
    public Guid BrancheId { get; set; }
    public Branche Branche { get; set; }
}
