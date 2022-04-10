using JopSelectData.Enums;

namespace JopSelectData.Models;

public class Favorite: BaseModel
{
    public Guid FavoriteId { get; set; }
    public ModelType ModelType { get; set; }
    public Guid ModelId { get; set; }
    
    //Relation with user model
    public Guid UserId { get; set; }
    public User User { get; set; }
}