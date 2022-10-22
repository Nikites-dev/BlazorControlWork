using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KonrolnayaBlazor.MongoDB;

public class User
{
    public User()
    {
        
    }
    [BsonIgnoreIfDefault]
    public ObjectId _id;
    [BsonIgnoreIfDefault]
    public String Login { get; set; }
    [BsonIgnoreIfDefault]
    public String Password { get; set; }
    [BsonIgnoreIfDefault]
    public String FName { get; set; }
    [BsonIgnoreIfDefault]
    public String LName { get; set; }
    [BsonIgnoreIfDefault]
    public String Email { get; set; }
}