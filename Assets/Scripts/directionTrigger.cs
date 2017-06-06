using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionTrigger : MonoBehaviour 
{

	public Vector3 sendVec;

	void FixedUpdate ()
	{
		
	}

	void OnTriggerEnter(Collider target)
	{
		target.BroadcastMessage("Message", sendVec, SendMessageOptions.DontRequireReceiver);
		//Debug.Log(sendVec);
	}
}
