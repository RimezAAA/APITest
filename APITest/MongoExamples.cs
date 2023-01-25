using MongoDB.Driver;

namespace APITest
{
    public class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DD");
            var collection = database.GetCollection<User>("DDs");
            collection.InsertOne(user);

        }

        public static List<User> FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("DD");
            var collection = database.GetCollection<User>("DDs");
            var list = collection.Find(x => true).ToList();
            return list;
        }
    }
}
