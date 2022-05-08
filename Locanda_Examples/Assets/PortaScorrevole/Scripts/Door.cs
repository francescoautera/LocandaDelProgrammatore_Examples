using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Door : MonoBehaviour { 
	public bool isOpening;
   public float shiftFromHisPos;
   public float initPosX;
   public bool doingAction;
   
   private void Start() {
	   initPosX = transform.position.x;
   }

   public IEnumerator OpenDoor() {
	   Vector3 finalPos = new Vector3(transform.position.x + shiftFromHisPos, transform.position.y, transform.position.z);
	   isOpening = true;
	   doingAction = true;
	   float t = 0f;	
	   while (Mathf.Abs(transform.position.x-finalPos.x)>0.1f) {
		   transform.position=Vector3.Lerp(transform.position,finalPos,t/10f);
		   t += Time.deltaTime;
		   yield return null;
	   }

	   doingAction = false;


   }


   public IEnumerator CloseDoor() {
	   Vector3 finalPos = new Vector3(initPosX, transform.position.y, transform.position.z);
	   isOpening = false;
	   doingAction = true;
	   float t = 0f;	
	   while (Mathf.Abs(transform.position.x-finalPos.x)>0.01f) {
		   transform.position=Vector3.Lerp(transform.position,finalPos,t/10f);
		   t += Time.deltaTime;
		   yield return null;
	   }
	   doingAction = false;
   }




}

