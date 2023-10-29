using Firebase.Firestore;

namespace Sashimis.DataModels
{
    [FirestoreData]
    public class Sushi
    {
        [FirestoreProperty]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public float Cost { get; set; }
    }
}
