using Firebase.Firestore;

namespace SashimisBackending.Datamodels
{
    [FirestoreData]
    public class Ramen
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public float Cost { get; set; }
    }
}


