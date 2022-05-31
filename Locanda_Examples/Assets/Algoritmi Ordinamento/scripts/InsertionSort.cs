using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertionSort : MonoBehaviour {

   public List<NumberManager> numbers;
   [SerializeField] private int currentIndex;
   private float timer = 0f;
   public GameObject buttonOrder;

   private void Start() {
      currentIndex = 1;
      numbers[currentIndex].GetComponent<Image>().color=Color.red;
   }

 
   


   public void OrderInserionSort() {
      int val = numbers[currentIndex].currentNumber;
      var index = currentIndex-1;
      while (index >= 0 && numbers[index].currentNumber > val)
      {
         numbers[index + 1].currentNumber = numbers[index].currentNumber;
         numbers[index+1].UpdateText();
         index -= 1;
      }
      numbers[index + 1].currentNumber = val;
      numbers[index+1].UpdateText();
      numbers[currentIndex].GetComponent<Image>().color=Color.white;
      currentIndex++;
      if (currentIndex > numbers.Count-1) {
         buttonOrder.SetActive(false);
      }
     
      if (currentIndex <= numbers.Count - 1) {
         numbers[currentIndex].GetComponent<Image>().color = Color.red;
      }

   }








}
