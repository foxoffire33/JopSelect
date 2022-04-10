using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Reaction: BaseModel
{
    public Guid ReactionId { get; set; }
    public ModelType ModelType { get; set; }
    public ReactionStatus ReactionStatus { get; set; }
    public string Description { get; set; }
    
    public Guid? ResumeId { get; set; }
    public Resume? Resume { get; set; }
    
    public Guid? VacancyOd { get; set; }
    public Vacancy? Vacancy { get; set; }
    
    public Guid UserId { get; set; }
    public User User { get; set; }
}
