using Firebase.Firestore;
using Firebase.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SashimisBackending.Datamodels;
using System.Threading.Tasks;

namespace SashimisBackending.Database
{
    public class DatabaseFirebaseImpl
    {
        public static string GetIdForNewEntry(string collection)
        {
            FirebaseFirestore _database = FirebaseFirestore.DefaultInstance;

            DocumentReference docRef = _database.Collection(collection).Document();
            return docRef.Id;
        }

        public static void SetData(string collection, string documentId, object data, Action<bool> sucessCallback = null)
        {
            FirebaseFirestore _database = FirebaseFirestore.DefaultInstance;
            DocumentReference docRef = _database.Collection(collection).Document(documentId);
            docRef.SetAsync(data).ContinueWithOnMainThread(task => 
            {
                if (task.IsCompletedSuccessfully)
                {
                    Debug.Log("Task was successfull");
                    sucessCallback(true);
                }
                else if (task.IsFaulted)
                {
                    Debug.Log("Task was faulted: " + task.Exception.ToString());
                    sucessCallback(false);
                }
                else if (task.IsCanceled)
                {
                    Debug.Log("Task was canceled");
                    sucessCallback(false);
                }
            });
        }
    }
}
