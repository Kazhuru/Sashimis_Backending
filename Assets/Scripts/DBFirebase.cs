using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;

public class DBFirebase : MonoBehaviour
{
    private FirebaseFirestore _dataBase;

    void Start()
    {
        _dataBase = FirebaseFirestore.DefaultInstance;
    }
}
