using System.ComponentModel.DataAnnotations.Schema;
using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Skill: BaseModel
{
    public Guid SkillId { get; set; }
    public SkillType SkillType { get; set; }
    public string Description { get; set; }
}
