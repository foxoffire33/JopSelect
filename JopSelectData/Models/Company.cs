namespace JopSelectData.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class Company: BaseModel
{
    private string _ContactName;
    
    public Guid CompanyID { get; set;  }
    public string Name { get; set;  }

    /**
     * If the is no Contact name specified then return Name attribute
     */
    public string ContactName
    {
        get => _ContactName ?? Name;
        set => _ContactName = value;
    }

    public Address Address { get; set;  }
    public string Kvk { get; set;  }
    public string Phone { get; set;  }
    public Uri Webpage { get; set;  }
    public string Description { get; set;  }
    public ushort NumberOfEmployees { get; set;  }
    
}