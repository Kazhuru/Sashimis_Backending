using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SashimisBackending.Datamodels;

public class CardSushiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text name;
    [SerializeField] private TMP_Text description;
    [SerializeField] private TMP_Text cost;
    private Sushi chuchi;

    public void SetData(Sushi chuchi)
    {
        this.chuchi = chuchi;
        name.text = chuchi.Name;
        description.text = chuchi.Description;
        cost.text = "$ " + chuchi.Cost.ToString();        
    }
}
