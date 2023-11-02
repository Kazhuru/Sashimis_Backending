using Firebase.Firestore;
using System;

namespace SashimisBackending.Datamodels
{
    [Serializable]
    [FirestoreData]
    public class Sushi
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Description { get; set; }
        [FirestoreProperty]
        public float Cost { get; set; }

        public Sushi(string id, string name, string description, float cost)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
        }

        public Sushi() { }
    }
}

