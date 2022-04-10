using JopSelectData.Enums;

namespace JopSelectData.Models;

public class SkillScore : BaseModel
{
    public Guid SkillScoreId { get; set; }
    public SkillScoreType SkillScoreType { get; set; }
    public LanguageType? LanguageType { get; set; }
    public ModelType ModelType { get; set; }

    public Guid? ResumeId { get; set; }
    public Resume? Resume { get; set; }
    
    public Guid? VacancyId { get; set; }
    public Vacancy? Vacancy { get; set; }
    
    public Guid SkillId { get; set; }
    public Skill Skill { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}