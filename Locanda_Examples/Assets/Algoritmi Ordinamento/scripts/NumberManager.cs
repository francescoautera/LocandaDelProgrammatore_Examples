using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class NumberManager : MonoBehaviour {
   public int currentNumber;
   public Image image;
   public TMP_Text textNumber;

   private void Start() {
      currentNumber = Random.Range(0, 20);
      textNumber = GetComponentInChildren<TMP_Text>();
      textNumber.text = currentNumber.ToString();
   }

   public void UpdateText() {
      textNumber.text = currentNumber.ToString();
   }
   
   
}
