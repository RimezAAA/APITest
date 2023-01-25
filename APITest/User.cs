using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace APITest
{
    public class User
    {
        public User(string name, string email, string message)
        {
            Name = name;
            Email = email;
            Message = message;
        }
        [BsonId]
        ObjectId _id;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
