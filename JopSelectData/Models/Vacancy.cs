using System.ComponentModel.DataAnnotations.Schema;
using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Vacancy: BaseModel
{
    public Guid VacancyId { get; set; }
    
    public int MinimalAge { get; set; }
    public int MaximumAge { get; set; }
    
    public int EducationLevel { get; set; }
    public int HoursAWeek { get; set; }
    public VacancyType VacancyType { get; set; }
    public ushort HolidaysAYear { get; set; }
    public int MinimalSalary { get; set; }
    public int MaximumSalary { get; set; }
    public City City { get; set; }
    
    public string FunctionRequirements { get; set;  }
    public string FunctionDescription { get; set;  }
    public string VacancyDescription { get; set;  }
    //Relations
    
    //Relation to company
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    
    //Relation to branch
    public Guid BranchId { get; set; }
    public Branche Branche { get; set; }
    
}