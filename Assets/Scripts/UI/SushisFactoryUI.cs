using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SashimisBackending.Controllers;

namespace SashimisBackending.UI
{
    public class SushisFactoryUI : MonoBehaviour
    {
        [SerializeField] private TMP_InputField _inputName;
        [SerializeField] private TMP_InputField _inputDescription;
        [SerializeField] private TMP_InputField _inputCost;
        
        public void CreateSushiButton()
        {
            string name = _inputName.text;
            string description = _inputDescription.text;
            float cost = float.Parse(_inputCost.text);

            SushiController sushiCtrl = new SushiController();
            sushiCtrl.CreateAndSave(name, description, cost);   
        }
    }
}
