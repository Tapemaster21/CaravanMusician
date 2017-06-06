using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeTrigger : MonoBehaviour 
{

	void OnTriggerEnter(Collider target)
	{
		Destroy(target.gameObject);
	}
}
