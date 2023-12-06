using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SashimisBackending.Datamodels;
using SashimisBackending.Database;
using System;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;


    private void Awake()
    {
        if(Instance != null &&  Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
    }

    private List<Sushi> _shushisCollection;

    public const string TABLE_SUSHI = "Sushi";


    void Start()
    {
        ObtainSushisList();
        PrintSushiName("bzCsD8jthQba70mNkWSI");

        

        _shushisCollection = new List<Sushi>();
    }

    private void ObtainSushisList()
    {
        DatabaseFirebaseImpl.GetDataList<Sushi>(TABLE_SUSHI, callbackResult =>
        {
            Debug.Log("Got all Sushis!");
            _shushisCollection = callbackResult;
        });
    }

    private void PrintSushiName( string sushiID)
    {
        DatabaseFirebaseImpl.GetDocument<Sushi>(TABLE_SUSHI, sushiID, sushi =>
        {
            Debug.Log(sushi.Name);
        });
    }

    public void AddSushiToList(Sushi sushi) 
    {
        _shushisCollection.Add(sushi);
    }
}
