using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class OpenDoor : MonoBehaviour {
   
   public Door doorDx;
   public Door doorSx;
   


   private void OnTriggerEnter(Collider other) {
      if (other.CompareTag("Player")) {
         if (!doorDx.isOpening && !doorSx.isOpening) {
            if (!doorDx.doingAction && !doorSx.doingAction) {
               StartCoroutine(doorDx.OpenDoor());
               StartCoroutine(doorSx.OpenDoor());
            }
         }
      }
      
   }

   private void OnTriggerExit(Collider other) {
      if (other.CompareTag("Player")) {
         if (doorDx.isOpening && doorSx.isOpening) {
            if (!doorDx.doingAction && !doorSx.doingAction) {
               StartCoroutine(doorDx.CloseDoor());
               StartCoroutine(doorSx.CloseDoor());
            }
         }
      }
   }

}
