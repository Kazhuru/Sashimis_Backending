using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Sashimis.Controller;

namespace SushiCard.UI 
{
    public class SushiCardManager : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _inputName;
        [SerializeField] private TMP_InputField _inputDescription;
        [SerializeField] private TMP_InputField _inputCost;

        public void SendSushiInfo()
        {
            SushiController sushiController = new SushiController();
            sushiController.CreateAndSave(_inputName.text, _inputDescription.text, float.Parse(_inputCost.text));
        }
    }

}


