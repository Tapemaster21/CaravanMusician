using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScript : MonoBehaviour {

	public float damage;
	
	
	void Start () {
		
	}
	
	void FixedUpdate () {
		
	}
	
	void OnTriggerEnter(Collider target)
	{
	//	transform.LookAt (target.transform);
	//	target.BroadcastMessage("Damage", damage, SendMessageOptions.DontRequireReceiver);	
	}

	void OnTriggerStay(Collider target){
		Vector3 targetPostition = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
		this.transform.LookAt(targetPostition) ;

		//transform.LookAt (target.transform);
		//transform.RotateAround (transform.parent.up, Vector3.up, (transform.forward));
	}
}
