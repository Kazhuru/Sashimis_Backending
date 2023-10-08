using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SashimisBackending.Datamodels;

public class DataManager : MonoBehaviour
{
    private List<Sushi> _shushisCollection;

    void Start()
    {
        // Request Sashimis from DB
        _shushisCollection = new List<Sushi>();
    }

  
    void Update()
    {
        
    }
}
