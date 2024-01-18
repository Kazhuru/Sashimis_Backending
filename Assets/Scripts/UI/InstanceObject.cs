using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SashimisBackending.Datamodels;

public class InstanceObject : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    public void Instanciate(List<Sushi> objectList)
    {
        foreach (Sushi sushi in objectList)
        {
            GameObject instance = Instantiate(prefab, this.transform);
            CardSushiManager card = instance.GetComponent<CardSushiManager>();
            card.SetData(sushi);
        }
    }

}
