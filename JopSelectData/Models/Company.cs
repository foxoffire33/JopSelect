namespace JopSelectData.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class Company: BaseModel
{
    public Guid CompanyID { get; set;  }
    public string Name { get; set;  }
    public string ContactPerson { get; set;  }
    public string Address { get; set;  }
    public string Postal { get; set;  }
    public string Province { get; set;  }
    public string City { get; set;  }
    public string Country { get; set;  }
    public string Kvk { get; set;  }
    public string Phone { get; set;  }
    public string Webpage { get; set;  }
    public string Description { get; set;  }
    public int NumberOfEmployees { get; set;  }
    
}