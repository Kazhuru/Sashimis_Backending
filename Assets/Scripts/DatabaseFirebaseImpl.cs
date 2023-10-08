using Firebase.Firestore;
using Firebase.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SashimisBackending.Datamodels;

public class DatabaseFirebaseImpl
{
    public static string GetIdForNewEntry(string collection)
    {
        FirebaseFirestore _database = FirebaseFirestore.DefaultInstance;

        DocumentReference docRef = _database.Collection(collection).Document();
        return docRef.Id;
    }

    internal static void SetData(string collection, string documentId, object data)
    {
        FirebaseFirestore _database = FirebaseFirestore.DefaultInstance;

        DocumentReference docRef = _database.Collection(collection).Document(documentId);
        docRef.SetAsync(data);
    }
}
