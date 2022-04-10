using System.ComponentModel.DataAnnotations.Schema;

namespace JopSelectData.Models;

public class BaseModel
{
    //Create by relation to user
    public Guid CreatedByForeignKey { get; set;  }
    [ForeignKey("CreatedByForeignKey")]
    public User CreatedBy  { get; set;  }
    
    //Updated by relation to user
    public Guid UpdatedByForeignKey { get; set;  }
    [ForeignKey("UpdatedByForeignKey")]
    public User UpdatedBy  { get; set;  }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}