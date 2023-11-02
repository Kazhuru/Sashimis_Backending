using Firebase.Firestore;
using System;

namespace SashimisBackending.Datamodels
{
    [Serializable]
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


