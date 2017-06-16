using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScript : MonoBehaviour {

	public int damage;
	public int reload;
	private int currentReload;
	public GameObject bullet;

	
	
	void Start () {
		currentReload = reload;
	}
	
	void FixedUpdate () {
		if (currentReload > 0) {
			currentReload--;
		}

	}
	
	void OnTriggerEnter(Collider target)
	{
	//	transform.LookAt (target.transform);
	//	target.BroadcastMessage("Damage", damage, SendMessageOptions.DontRequireReceiver);	
	}

	void OnTriggerStay(Collider target){
		Vector3 targetPostition = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
		this.transform.LookAt(targetPostition);
		if (currentReload <= 0) {
			//make particle bullshit with collision detection to take damage
			//target.BroadcastMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
			currentReload = reload;
			Shoot (target);
		}

	}

	void Shoot(Collider target){
		bullet b = Object.Instantiate(bullet, transform.position, transform.rotation).GetComponent<bullet>();

		//###
		//speed,target
		b.Initialize(10f, damage, target);
	
	}
}
